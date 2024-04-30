

using System.IO.Ports;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Collections.Specialized;
using System.Net.Security;
using System.Numerics;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Policy;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{  //LOCOMOCO




    //LOCOMOCO END
    public partial class Form1 : Form
    {

        SerialPort port;

        //Live Video
        VideoCapture mCapture;

        Thread mCaptureThread;

        CancellationTokenSource mCancellationToken = new();

        bool mIsCapturing = false;
        bool motorsonbool = true;
        //Serial Communication

        // string PORTNAME = "COM3";
        //SerialPort MegaSerial = new SerialPort();
        //Thread mSerialMonitoringThread;
        // CancellationTokenSource mSerialCancellationToken = new();
        // int mContoursCount = 0;
        // bool mFoundIsValid = false;
        // bool mReplyIsReady = false;


        public Form1()
        {
            InitializeComponent();

        }






        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                mCapture = new VideoCapture(0);
                //mFoundIsValid = true;
                if (mCapture.Height == 0)
                    throw new Exception("No Cameras Found)");

                if (port == null)
                {
                    port = new SerialPort("COM3", 9600);//Set your board COM
                    port.Open();
                }

                //Initialize Serial port
                //MegaSerial.PortName = PORTNAME;
                //MegaSerial.BaudRate = 8000000;
                //MegaSerial.Parity = Parity.None;
                //MegaSerial.StopBits = StopBits.Two;
                //MegaSerial.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void PortWrite(int data)
        {
            byte[] buffer = new byte[1] {
            Convert.ToByte(data),
            };
            port.Write(buffer, 0, buffer.Length);
            // port.Write(message);
        }

        /*
        private void MonitorSerialData(CancellationToken token)
        {

            while (!token.IsCancellationRequested && mReplyIsReady)
            {

                //block until \n character is received, extract command data
                string msg = MegaSerial.ReadLine();

                mReplyIsReady = false;

                //confirm the string has both < and > characters
                if (msg.IndexOf("<") == -1 || msg.IndexOf(">") == -1)
                {
                    continue;

                }

                //remove everything before and the <
                msg = msg.Substring(msg.IndexOf("<") + 1);

                //remove everything after and the >

                msg.Remove(msg.IndexOf(">"));

                //If string is empty after, disregard
                if (msg.Length == 0)
                {
                    continue;

                }

                //Is this really a 'R'eply?

                if (msg.Substring(0, 1) == "R")
                {

                    //Command is to display the point adata, output to the text field
                    Invoke(new Action(() => {

                        SerialBox.Text = $"Returned Data: {msg.Substring(1)}";




                    }));



                }




            }

        }

        */

        /*
        
        private void SendSerialComm(int data)
        {

            if (!mFoundIsValid) return;
            try
            {

                Debug.WriteLine("Sending Data");
                byte[] buffer = new byte[3] {
                Encoding.ASCII.GetBytes("<")[0],
                Convert.ToByte(data),
                Encoding.ASCII.GetBytes(">")[0]
                };

                MegaSerial.Write(buffer, 0, buffer.Length);
                mReplyIsReady = true;

                mSerialCancellationToken = new();
                mSerialMonitoringThread = new(() => MonitorSerialData(mSerialCancellationToken.Token));
                mSerialMonitoringThread.Start();

                string hexString = BitConverter.ToString(buffer).Replace("-", string.Empty).ToLower();
                Debug.WriteLine(hexString) ;

            }
            catch (Exception ex)
            {

                SerialBox.Text = "Something is Wrong!";

            }




        }

        */


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            //Dispose all processing threads to avoid orphaned processes
            if (mIsCapturing)
            {
                mCancellationToken.Cancel();

            }

            mCapture.Dispose();
            mCancellationToken.Dispose();

            if (port != null && port.IsOpen)
            {
                port.Close();
            }

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

                hMinBar.Value = 10;
                hMaxBar.Value = 120;
                sMinBar.Value = 120;
                sMaxBar.Value = 255;
                vMinBar.Value = 140;
                vMaxBar.Value = 255;





            }



        }

        bool emergencystate = false;
        bool stopped = false;

        float min = 1;
        float max = 1;
        int modifyrate = 1;
        //Create array to store pixels for each section
        int[] SplitArray = { 0, 0, 0, 0, 0, 0 };



        int Sections = 5;

        //YELLOW VARIABLES---
        //Hue variables
        double hMin = 0;
        double hMax = 179;

        //sat Variables
        double sMin = 0;
        double sMax = 150;

        //val Variables
        double vMin = 0;
        double vMax = 150;


        //RED VARIABLES---
        //Hue variables
        double hMinRED = 10;
        double hMaxRED = 123;

        //sat Variables
        double sMinRED = 33;
        double sMaxRED = 81;

        //val Variables
        double vMinRED = 59;
        double vMaxRED = 144;


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


                    HueMinBox.Text = hMin.ToString();
                    HueMaxBox.Text = hMax.ToString();
                    SatMinBox.Text = sMin.ToString();
                    SatMaxBox.Text = sMax.ToString();
                    ValMinBox.Text = vMin.ToString();
                    ValMaxBox.Text = vMax.ToString();

                }));



                //~60fps -> 1000ms/60 = 16.6

                Task.Delay(16);
                // CvInvoke.Flip(frame, frame, FlipType.Horizontal);
                VideoPictureBox.Image = frame.ToBitmap(); //Display current frame

                Mat HsvFrame = frame.Clone();

                //Conversion to Grey
                // CvInvoke.CvtColor(frame, frame, ColorConversion.Bgr2Gray);

                //CvInvoke.Threshold(frame, frame, min, max, Emgu.CV.CvEnum.ThresholdType.Binary);

                //Conversion to HSV
                //CvInvoke.CvtColor(frame, HsvFrame, ColorConversion.Bgr2Gray);
                //Split HSV into array of mats

                //YELLOW HSV START -------------

                Mat[] hsvChannels = HsvFrame.Split();
                Mat GrayFrame = frame.Clone();

                Size hsvSize = new Size(hPictureBox.Width, hPictureBox.Height);




                //Filter for Hue
                Mat hueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(hMin), new ScalarArray(hMax), hueFilter);
                CvInvoke.Resize(hueFilter, hueFilter, hsvSize);
                Invoke(new Action(() => { hPictureBox.Image = hueFilter.ToBitmap(); }));

                //Filter for Saturation
                Mat satFilter = new Mat();
                CvInvoke.InRange(hsvChannels[1], new ScalarArray(sMin), new ScalarArray(sMax), satFilter);
                CvInvoke.Resize(satFilter, satFilter, hsvSize);
                Invoke(new Action(() => { sPictureBox.Image = satFilter.ToBitmap(); }));

                //Filter for Value
                Mat valFilter = new Mat();
                CvInvoke.InRange(hsvChannels[2], new ScalarArray(vMin), new ScalarArray(vMax), valFilter);
                CvInvoke.Resize(valFilter, valFilter, hsvSize);
                Invoke(new Action(() => { vPictureBox.Image = valFilter.ToBitmap(); }));


                //Merge filters
                Mat mergedImage = new Mat();
                CvInvoke.BitwiseAnd(hueFilter, satFilter, mergedImage);
                CvInvoke.BitwiseAnd(mergedImage, valFilter, mergedImage);
                CvInvoke.Resize(mergedImage, mergedImage, newSize);

                CvInvoke.CvtColor(GrayFrame, GrayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(GrayFrame, GrayFrame, min, max, Emgu.CV.CvEnum.ThresholdType.Binary);



                VideoPictureBox2.Image = GrayFrame.ToBitmap();

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



                VideoPictureBox3.Image = mergedImage.ToBitmap(); //Set image with added lines

                int largestsection = 0;
                for (int i = 0; i < Sections; i++)
                {
                    if (SplitArray[i] > SplitArray[largestsection])
                    {

                        largestsection = i;


                    }

                }

                //YELLOW HSV END -------------










                //RED HSV START -------------

                Mat[] hsvChannelsRED = HsvFrame.Split();
                Mat GrayFrameRED = frame.Clone();

                Size hsvSizeRED = new Size(VideoPictureBox4.Width, VideoPictureBox4.Height);




                //Filter for Hue
                Mat hueFilterRED = new Mat();
                CvInvoke.InRange(hsvChannelsRED[0], new ScalarArray(hMinRED), new ScalarArray(hMaxRED), hueFilterRED);
                CvInvoke.Resize(hueFilterRED, hueFilterRED, hsvSizeRED);
                Invoke(new Action(() => { hPictureBox2.Image = hueFilterRED.ToBitmap(); }));

                //Filter for Saturation
                Mat satFilterRED = new Mat();
                CvInvoke.InRange(hsvChannelsRED[1], new ScalarArray(sMinRED), new ScalarArray(sMaxRED), satFilterRED);
                CvInvoke.Resize(satFilterRED, satFilterRED, hsvSizeRED);
                Invoke(new Action(() => { sPictureBox2.Image = satFilterRED.ToBitmap(); }));

                //Filter for Value
                Mat valFilterRED = new Mat();
                CvInvoke.InRange(hsvChannelsRED[2], new ScalarArray(vMinRED), new ScalarArray(vMaxRED), valFilterRED);
                CvInvoke.Resize(valFilterRED, valFilterRED, hsvSizeRED);
                Invoke(new Action(() => { vPictureBox2.Image = valFilterRED.ToBitmap(); }));


                //Merge filters
                Mat mergedImageRED = new Mat();
                CvInvoke.BitwiseAnd(hueFilterRED, satFilterRED, mergedImageRED);
                CvInvoke.BitwiseAnd(mergedImageRED, valFilterRED, mergedImageRED);
                CvInvoke.Resize(mergedImageRED, mergedImageRED, hsvSizeRED);

                CvInvoke.CvtColor(GrayFrameRED, GrayFrameRED, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(GrayFrameRED, GrayFrameRED, min, max, Emgu.CV.CvEnum.ThresholdType.Binary);



                VideoPictureBox4.Image = GrayFrame.ToBitmap();

                //SplitArray[0] = 0;
                //SplitArray[1] = 0;
                //SplitArray[2] = 0;
                // SplitArray[3] = 0;
                //SplitArray[4] = 0;
                int totalwhitePixelsRED = 0;// CvInvoke.CountNonZero(mergedImageRED);
                                            //int lmpixels = 0; //Left most pixels
                                            //int mlpixels = 0; //Middle left pixels
                                            //int mpixels = 0; //Middle pixels
                                            // int mrpixels = 0; //Middle right pixels
                                            //int rmpixels = 0; //Right most pixels






                //Image<Gray, byte> GrayMatToImage = frame.ToImage<Gray, byte>(); //Turn the map into an image for viewing

                Image<Gray, byte> GrayMatToImageRED = mergedImageRED.Clone().ToImage<Gray, byte>(); //Turn the map into an image for viewing

                //Loop through image to find white pixels


                for (int x = 0; x < mergedImageRED.Width; x++) //Loop through every x coordinate in the 5th
                                                               //Set x equal to the start of the fifth
                                                               //if i=0, x=0| if i=1 , x= 1/5 of the entire frame, so loop through 1/5th

                {

                    for (int y = mergedImageRED.Height * 4 / 5; y < mergedImageRED.Height; y++)//Loop through every y coordinate
                    {
                        if (GrayMatToImageRED.Data[y, x, 0] == 255) //If the pixel and x and y = our max, add it
                        {
                            totalwhitePixelsRED++; //add to the correct section
                        }






                        // if (lmi.Data[y, x, 0] == max) lmpixels++;


                    }




                }







                //VideoPictureBox4.Image = mergedImageRED.Clone().ToBitmap(); //Set image with added lines


                if (totalwhitePixelsRED > 5000)
                {

                    emergencystate = true;
                    largestsection = 6;

                }

                //RED HSV END -------------





                string[] actions = { "Hard_Right", "Right", "Straight", "Left", "Hard_Left", "Stop", "Emergency" };




                Invoke(new Action(() =>
                {
                // PortWrite(largestsection);
                ///*
                ///
                if(emergencystate == true)
                    {

                        largestsection = 6;

                    }

                else if (largestsection == 5)
                    {

                        motorsonbool = false;

                    }
                    if (motorsonbool == false)
                    {
                        largestsection = 5;
                    }

                    PortWrite(largestsection);


                    WhitePixelBox.Text = totalwhitePixels.ToString();

                }));


                Invoke(new Action(() => //Update all the stats
                {
                    Split1.Text = SplitArray[0].ToString();
                    Split2.Text = SplitArray[1].ToString();
                    Split3.Text = SplitArray[2].ToString();
                    Split4.Text = SplitArray[3].ToString();
                    Split5.Text = SplitArray[4].ToString();
                    RedPixelsTextBox.Text = totalwhitePixelsRED.ToString();
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

        private void hMinBar_Scroll(object sender, EventArgs e)
        {
            if (hMaxBar.Value < hMinBar.Value)
            {

                hMaxBar.Value = hMinBar.Value;
            }

            hMin = hMinBar.Value;
            hMax = hMaxBar.Value;
        }

        private void hMaxBar_Scroll(object sender, EventArgs e)
        {
            if (hMinBar.Value > hMaxBar.Value)
            {
                hMinBar.Value = hMaxBar.Value;

            }

            hMin = hMinBar.Value;
            hMax = hMaxBar.Value;
        }

        private void sMinBar_Scroll(object sender, EventArgs e)
        {
            if (sMaxBar.Value < sMinBar.Value)
            {

                sMaxBar.Value = sMinBar.Value;
            }

            sMin = sMinBar.Value;
            sMax = sMaxBar.Value;
        }

        private void sMaxBar_Scroll(object sender, EventArgs e)
        {
            if (sMinBar.Value > sMaxBar.Value)
            {

                sMinBar.Value = sMaxBar.Value;
            }

            sMin = sMinBar.Value;
            sMax = sMaxBar.Value;
        }

        private void vMinBar_Scroll(object sender, EventArgs e)
        {
            if (vMaxBar.Value < vMinBar.Value)
            {
                vMaxBar.Value = vMinBar.Value;

            }

            vMin = vMinBar.Value;
            vMax = vMaxBar.Value;
        }

        private void vMaxBar_Scroll(object sender, EventArgs e)
        {
            if (vMinBar.Value > vMaxBar.Value)
            {

                vMinBar.Value = vMaxBar.Value;
            }

            vMin = vMinBar.Value;
            vMax = vMaxBar.Value;
        }

        private void motoronbutton_Click(object sender, EventArgs e)
        {

            Invoke(new Action(() => //Update all the stats
            {
                if (motorsonbool == false)
                {
                    motorsonbool = true;
                    motoronbutton.Text = "True";
                }
                else
                {
                    motorsonbool = false;
                    motoronbutton.Text = "False";

                }
            }));


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }




}