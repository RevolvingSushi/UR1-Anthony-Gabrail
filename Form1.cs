
using Emgu.CV;

namespace UR1_Anthony_Gabrail
{
    public partial class Form1 : Form
    {

        VideoCapture mCapture;

        Thread mCaptureThread;

        CancellationTokenSource m;
        private Button StartStopButton;
        private PictureBox VideoPictureBox;
        bool mIsCapturing = false;

        public Form1()
        {

            InitializeComponent();
        }

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

        private void InitializeComponent()
        {
            StartStopButton = new Button();
            VideoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(1010, 748);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(188, 58);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Start";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += button1_Click;
            // 
            // VideoPictureBox
            // 
            VideoPictureBox.Location = new Point(273, 94);
            VideoPictureBox.Name = "VideoPictureBox";
            VideoPictureBox.Size = new Size(785, 593);
            VideoPictureBox.TabIndex = 1;
            VideoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(1340, 942);
            Controls.Add(VideoPictureBox);
            Controls.Add(StartStopButton);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }

}
