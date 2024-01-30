
using Emgu.CV;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {


        VideoCapture mCapture;

        Thread mCaptureThread;

        CancellationTokenSource mCancellationToken = new();

        bool mIsCapturing = false;

       

        public Form1()
        {
            InitializeComponent();

        }






        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                mCapture = new VideoCapture(0);

                if (mCapture.Height == 0)
                    throw new Exception("No Cameras Found)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            //Dispose all processing threads to avoid orphaned processes
            if (mIsCapturing)
            {
                mCancellationToken.Cancel();

            }
            mCapture.Dispose();
            mCancellationToken.Dispose();

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (mIsCapturing) // if cam is live, stop it
            {

                mCancellationToken.Cancel(); //request stop
                mIsCapturing = false; //indicate new state

                StartStopBtn.Text = "Start";


            }
            else // if it is dead start it
            {

                mCancellationToken = new(); //reinitalize
                //Initalize new thread 

                mCaptureThread = new(() => DisplayWebcam(mCancellationToken.Token));

                mCaptureThread.Start();//start it

                mIsCapturing = true; // Change state

                StartStopBtn.Text = "Stop";




            }



        }

        private void DisplayWebcam(CancellationToken token)
        {
            while (!token.IsCancellationRequested)//White no requested cancellation
            {


                Mat frame = mCapture.QueryFrame(); //grab a new frame
                //resize to picturebox aspect ratio
                int newHeight = (frame.Size.Height * VideoPictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(VideoPictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                //~60fps -> 1000ms/60 = 16.6

                Task.Delay(16);

                VideoPictureBox.Image = frame.ToBitmap(); //Display current frame



            }
        }

        private void VideoPictureBox_Click(object sender, EventArgs e)
        {

        }
    }




}