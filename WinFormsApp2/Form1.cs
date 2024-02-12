
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Collections.Specialized;
using System.Net.Security;
using System.Numerics;

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
        int modifyrate = 1;
        //Create array to store pixels for each section
        int[] SplitArray = { 0, 0, 0, 0, 0, 0 };



        int Sections = 5;

        int hMin = 0;
        int hMax = 255;

        //sat Variables
        int sMin = 0;
        int sMax = 255;

        //val Variables
        int vMin = 0;
        int vMax = 255;



        private void DisplayWebcam(CancellationToken token)
        {
            while (!token.IsCancellationRequested)//White no requested cancellation
            {

                Sections = SplitArray.Length - 1;
                Mat frame = mCapture.QueryFrame(); //grab a new frame
                //resize to picturebox aspect ratio
                int newHeight = (frame.Size.Height * VideoPictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(VideoPictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                //Hue Variables

                Invoke(new Action(() =>
                {

                    hMin = hMinBar.Value;
                    hMax = hMaxBar.Value;
                    sMin = sMinBar.Value;
                    sMax = sMaxBar.Value;
                    vMin = vMinBar.Value;
                    vMax = vMaxBar.Value;




                }));



                //~60fps -> 1000ms/60 = 16.6

                Task.Delay(16);
                CvInvoke.Flip(frame, frame, FlipType.Horizontal);
                VideoPictureBox.Image = frame.ToBitmap(); //Display current frame

                Mat HsvFrame = frame.Clone();

                //Conversion to Grey
                // CvInvoke.CvtColor(frame, frame, ColorConversion.Bgr2Gray);

                //CvInvoke.Threshold(frame, frame, min, max, Emgu.CV.CvEnum.ThresholdType.Binary);

                //Conversion to HSV
                CvInvoke.CvtColor(frame, HsvFrame, ColorConversion.Bgr2Gray);
                //Split HSV into array of mats
                Mat[] hsvChannels = HsvFrame.Split();

                Size hsvSize = new Size(hPictureBox.Width, hPictureBox.Height);


                //Filter for Hue
                Mat hueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(hMin), new ScalarArray(hMax), hueFilter);
                CvInvoke.Resize(hueFilter, hueFilter, hsvSize);
                Invoke(new Action(() => { hPictureBox.Image = hueFilter.ToBitmap(); }));

                //Filter for Saturation
                Mat satFilter = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(sMin), new ScalarArray(sMax), satFilter);
                CvInvoke.Resize(satFilter, satFilter, hsvSize);
                Invoke(new Action(() => { sPictureBox.Image = satFilter.ToBitmap(); }));

                //Filter for Value
                Mat valFilter = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(vMin), new ScalarArray(vMax), valFilter);
                CvInvoke.Resize(valFilter, valFilter, hsvSize);
                Invoke(new Action(() => { vPictureBox.Image = valFilter.ToBitmap(); }));


                //Merge filters
                Mat mergedImage = new Mat();
                CvInvoke.BitwiseAnd(hueFilter, satFilter, mergedImage);
                CvInvoke.BitwiseAnd(mergedImage, valFilter, mergedImage);
                CvInvoke.Resize(mergedImage, mergedImage, newSize);
                //CvInvoke.Threshold(mergedImage, mergedImage, min, max, Emgu.CV.CvEnum.ThresholdType.Binary);

                //VideoPictureBox2.Image = frame.ToBitmap();
                SplitArray[0] = 0;
                SplitArray[1] = 0;
                SplitArray[2] = 0;
                SplitArray[3] = 0;
                SplitArray[4] = 0;
                int totalwhitePixels = CvInvoke.CountNonZero(mergedImage);
                //int lmpixels = 0; //Left most pixels
                //int mlpixels = 0; //Middle left pixels
                //int mpixels = 0; //Middle pixels
                // int mrpixels = 0; //Middle right pixels
                //int rmpixels = 0; //Right most pixels




                if (checkBox1.Checked == true)
                {
                    if (totalwhitePixels < 20000)
                    {
                        min -= modifyrate;
                    }
                    else
                    {
                        if (totalwhitePixels > 25000)
                        {
                            min += modifyrate;

                        }


                    }

                }

                //Image<Gray, byte> GrayMatToImage = frame.ToImage<Gray, byte>(); //Turn the map into an image for viewing

                Image<Gray, byte> GrayMatToImage = mergedImage.ToImage<Gray, byte>(); //Turn the map into an image for viewing

                //Loop through image to find white pixels
                for (int i = 0; i < Sections; i++) //Loop 5 times because we divied the image into 5ths
                {

                    for (int x = i * mergedImage.Width / Sections; x < (i + 1) * mergedImage.Width / Sections; x++) //Loop through every x coordinate in the 5th
                                                                                                                    //Set x equal to the start of the fifth
                                                                                                                    //if i=0, x=0| if i=1 , x= 1/5 of the entire frame, so loop through 1/5th

                    {

                        for (int y = 0; y < mergedImage.Height; y++)//Loop through every y coordinate
                        {
                            if (GrayMatToImage.Data[y, x, 0] == 255) //If the pixel and x and y = our max, add it
                            {
                                SplitArray[i]++; //add to the correct section
                            }






                            // if (lmi.Data[y, x, 0] == max) lmpixels++;


                        }




                    }



                    CvInvoke.Line(mergedImage, new Point(i * mergedImage.Width / Sections, 0), new Point(i * mergedImage.Width / Sections, mergedImage.Size.Height), new MCvScalar(255, 50, 50), 2);
                    //Draw a line to divide the image, important to do it after and with the correct points in order to not give false data
                }



                VideoPictureBox2.Image = mergedImage.ToBitmap(); //Set image with added lines

                int largestsection = 0;
                for (int i = 0; i < Sections; i++)
                {
                    if (SplitArray[i] > SplitArray[largestsection])
                    {

                        largestsection = i;


                    }

                }

                string[] actions = { "Hard_Right", "Right", "Straight", "Left", "Hard_Left" };




                Invoke(new Action(() =>
                {
                    WhitePixelBox.Text = totalwhitePixels.ToString();

                }));


                Invoke(new Action(() => //Update all the stats
                {
                    Split1.Text = SplitArray[0].ToString();
                    Split2.Text = SplitArray[1].ToString();
                    Split3.Text = SplitArray[2].ToString();
                    Split4.Text = SplitArray[3].ToString();
                    Split5.Text = SplitArray[4].ToString();
                    ActionBox.Text = actions[largestsection].ToString();



                }));








            }
        }

        private void VideoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if (ThresholdBarMin.Value > ThresholdBarMax.Value)
            {
                ThresholdBarMax.Value = ThresholdBarMin.Value;

            }


            min = ThresholdBarMin.Value;
            max = ThresholdBarMax.Value;






        }

        private void VideoPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {


            if (ThresholdBarMax.Value < ThresholdBarMin.Value)
            {
                ThresholdBarMin.Value = ThresholdBarMax.Value;

            }

            min = ThresholdBarMin.Value;
            max = ThresholdBarMax.Value;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {






            }
            else
            {




            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }




}