
using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Net.Security;

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

        float min = 1;
        float max = 1;
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
                CvInvoke.CvtColor(frame, frame, ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(frame, frame, min, max, Emgu.CV.CvEnum.ThresholdType.Binary);


                VideoPictureBox2.Image = frame.ToBitmap();

                int whitePixels = CvInvoke.CountNonZero(frame);
                Invoke(new Action(() =>
                {
                    if (trackBar1.Value > trackBar2.Value)
                    {
                        trackBar2.Value = trackBar1.Value;

                    }

                    if (trackBar2.Value < trackBar1.Value)
                    {
                        trackBar1.Value = trackBar2.Value;

                    }

                    min = trackBar1.Value;
                    max = trackBar2.Value;

                }


                ));



            }
        }

        private void VideoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }




}