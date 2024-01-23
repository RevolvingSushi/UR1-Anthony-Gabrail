
using Emgu.CV;

namespace UR1_Anthony_Gabrail
{
    public partial class Form1 : Form
    {

        VideoCapture mCapture;

        Thread mCaptureThread;

        CancellationTokenSource mCancellationToken = new();
        private PictureBox VideoPictureBox;
        private Button StartStopBtn;
        bool mIsCapturing = false;

       // public Form1()
        //{

        //    InitializeComponent();
      //  }

        private void Form1_Load(object sender, EventArgs e)
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


        private void StartStopBtn_Click(object sender, EventArgs e)
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




        private void InitializeComponent()
        {
            VideoPictureBox = new PictureBox();
            StartStopBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // VideoPictureBox
            // 
            VideoPictureBox.Location = new Point(273, 94);
            VideoPictureBox.Name = "VideoPictureBox";
            VideoPictureBox.Size = new Size(785, 593);
            VideoPictureBox.TabIndex = 1;
            VideoPictureBox.TabStop = false;
            // 
            // StartStopBtn
            // 
            StartStopBtn.Location = new Point(374, 820);
            StartStopBtn.Name = "StartStopBtn";
            StartStopBtn.Size = new Size(188, 58);
            StartStopBtn.TabIndex = 2;
            StartStopBtn.Text = "Start";
            StartStopBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(1340, 942);
            Controls.Add(StartStopBtn);
            Controls.Add(VideoPictureBox);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).EndInit();
            ResumeLayout(false);
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

    }


}
