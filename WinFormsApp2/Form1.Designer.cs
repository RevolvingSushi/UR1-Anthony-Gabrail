namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartStopBtn = new Button();
            VideoPictureBox = new PictureBox();
            VideoPictureBox3 = new PictureBox();
            ThresholdBarMin = new TrackBar();
            WhitePixelBox = new TextBox();
            ThresholdBarMax = new TrackBar();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            Split1 = new TextBox();
            Split2 = new TextBox();
            Split3 = new TextBox();
            Split4 = new TextBox();
            Split5 = new TextBox();
            LMLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            hMaxBar = new TrackBar();
            hMinBar = new TrackBar();
            label9 = new Label();
            ActionBox = new Label();
            hPictureBox = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            sPictureBox = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            sMaxBar = new TrackBar();
            sMinBar = new TrackBar();
            label14 = new Label();
            vPictureBox = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            vMaxBar = new TrackBar();
            vMinBar = new TrackBar();
            VideoPictureBox2 = new PictureBox();
            HueMinBox = new TextBox();
            HueMaxBox = new TextBox();
            SatMaxBox = new TextBox();
            SatMinBox = new TextBox();
            ValMaxBox = new TextBox();
            ValMinBox = new TextBox();
            SerialBox = new TextBox();
            motoronbutton = new Button();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            vPictureBox2 = new PictureBox();
            label23 = new Label();
            sPictureBox2 = new PictureBox();
            label26 = new Label();
            hPictureBox2 = new PictureBox();
            VideoPictureBox4 = new PictureBox();
            textBox2 = new TextBox();
            RedPixelsTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdBarMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdBarMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hMaxBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hMinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sMaxBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sMinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vMaxBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vMinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // StartStopBtn
            // 
            StartStopBtn.Location = new Point(30, 1550);
            StartStopBtn.Name = "StartStopBtn";
            StartStopBtn.Size = new Size(188, 58);
            StartStopBtn.TabIndex = 0;
            StartStopBtn.Text = "Start";
            StartStopBtn.UseVisualStyleBackColor = true;
            StartStopBtn.Click += button1_Click;
            // 
            // VideoPictureBox
            // 
            VideoPictureBox.BackColor = SystemColors.ControlLight;
            VideoPictureBox.Location = new Point(98, 93);
            VideoPictureBox.Name = "VideoPictureBox";
            VideoPictureBox.Size = new Size(600, 400);
            VideoPictureBox.TabIndex = 1;
            VideoPictureBox.TabStop = false;
            VideoPictureBox.Click += VideoPictureBox_Click;
            // 
            // VideoPictureBox3
            // 
            VideoPictureBox3.BackColor = SystemColors.ControlDark;
            VideoPictureBox3.Location = new Point(1747, 93);
            VideoPictureBox3.Name = "VideoPictureBox3";
            VideoPictureBox3.Size = new Size(600, 400);
            VideoPictureBox3.TabIndex = 2;
            VideoPictureBox3.TabStop = false;
            VideoPictureBox3.Click += VideoPictureBox2_Click;
            // 
            // ThresholdBarMin
            // 
            ThresholdBarMin.Location = new Point(138, 678);
            ThresholdBarMin.Maximum = 255;
            ThresholdBarMin.Minimum = 100;
            ThresholdBarMin.Name = "ThresholdBarMin";
            ThresholdBarMin.Size = new Size(372, 114);
            ThresholdBarMin.TabIndex = 3;
            ThresholdBarMin.Value = 150;
            ThresholdBarMin.Scroll += trackBar1_Scroll;
            // 
            // WhitePixelBox
            // 
            WhitePixelBox.Location = new Point(30, 1112);
            WhitePixelBox.Name = "WhitePixelBox";
            WhitePixelBox.Size = new Size(286, 47);
            WhitePixelBox.TabIndex = 4;
            // 
            // ThresholdBarMax
            // 
            ThresholdBarMax.Location = new Point(138, 798);
            ThresholdBarMax.Maximum = 255;
            ThresholdBarMax.Minimum = 100;
            ThresholdBarMax.Name = "ThresholdBarMax";
            ThresholdBarMax.Size = new Size(372, 114);
            ThresholdBarMax.TabIndex = 5;
            ThresholdBarMax.Value = 100;
            ThresholdBarMax.Scroll += trackBar2_Scroll;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(56, 952);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(260, 45);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Auto Threshold";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 1050);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 47);
            textBox1.TabIndex = 8;
            textBox1.Text = "Total White Pixels";
            // 
            // Split1
            // 
            Split1.Location = new Point(1464, 579);
            Split1.Name = "Split1";
            Split1.Size = new Size(180, 47);
            Split1.TabIndex = 9;
            // 
            // Split2
            // 
            Split2.Location = new Point(1670, 579);
            Split2.Name = "Split2";
            Split2.Size = new Size(180, 47);
            Split2.TabIndex = 10;
            // 
            // Split3
            // 
            Split3.Location = new Point(1878, 579);
            Split3.Name = "Split3";
            Split3.Size = new Size(180, 47);
            Split3.TabIndex = 11;
            // 
            // Split4
            // 
            Split4.Location = new Point(2083, 579);
            Split4.Name = "Split4";
            Split4.Size = new Size(180, 47);
            Split4.TabIndex = 12;
            // 
            // Split5
            // 
            Split5.Location = new Point(2284, 579);
            Split5.Name = "Split5";
            Split5.Size = new Size(180, 47);
            Split5.TabIndex = 13;
            // 
            // LMLabel
            // 
            LMLabel.AutoSize = true;
            LMLabel.Location = new Point(1479, 533);
            LMLabel.Name = "LMLabel";
            LMLabel.Size = new Size(143, 41);
            LMLabel.TabIndex = 14;
            LMLabel.Text = "Left Most";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1670, 533);
            label1.Name = "label1";
            label1.Size = new Size(168, 41);
            label1.TabIndex = 15;
            label1.Text = "Middle Left";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1910, 533);
            label2.Name = "label2";
            label2.Size = new Size(111, 41);
            label2.TabIndex = 16;
            label2.Text = "Middle";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2074, 533);
            label3.Name = "label3";
            label3.Size = new Size(189, 41);
            label3.TabIndex = 17;
            label3.Text = "Middle Right";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2300, 533);
            label4.Name = "label4";
            label4.Size = new Size(164, 41);
            label4.TabIndex = 18;
            label4.Text = "Right Most";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 798);
            label5.Name = "label5";
            label5.Size = new Size(74, 41);
            label5.TabIndex = 19;
            label5.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 678);
            label6.Name = "label6";
            label6.Size = new Size(69, 41);
            label6.TabIndex = 20;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(627, 1019);
            label7.Name = "label7";
            label7.Size = new Size(69, 41);
            label7.TabIndex = 24;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(622, 1139);
            label8.Name = "label8";
            label8.Size = new Size(74, 41);
            label8.TabIndex = 23;
            label8.Text = "Max";
            // 
            // hMaxBar
            // 
            hMaxBar.Location = new Point(748, 1139);
            hMaxBar.Maximum = 179;
            hMaxBar.Name = "hMaxBar";
            hMaxBar.Size = new Size(130, 114);
            hMaxBar.TabIndex = 22;
            hMaxBar.Value = 179;
            hMaxBar.Scroll += hMaxBar_Scroll;
            // 
            // hMinBar
            // 
            hMinBar.Location = new Point(748, 1019);
            hMinBar.Maximum = 179;
            hMinBar.Name = "hMinBar";
            hMinBar.Size = new Size(130, 114);
            hMinBar.TabIndex = 21;
            hMinBar.Value = 139;
            hMinBar.Scroll += hMinBar_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 544);
            label9.Name = "label9";
            label9.Size = new Size(210, 41);
            label9.TabIndex = 25;
            label9.Text = "Current Action";
            label9.Click += label9_Click;
            // 
            // ActionBox
            // 
            ActionBox.AutoSize = true;
            ActionBox.BackColor = Color.CornflowerBlue;
            ActionBox.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            ActionBox.ForeColor = SystemColors.ButtonFace;
            ActionBox.Location = new Point(90, 585);
            ActionBox.Name = "ActionBox";
            ActionBox.Size = new Size(272, 72);
            ActionBox.TabIndex = 26;
            ActionBox.Text = "ActionBox";
            ActionBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hPictureBox
            // 
            hPictureBox.BackColor = SystemColors.ControlLight;
            hPictureBox.Location = new Point(623, 697);
            hPictureBox.Name = "hPictureBox";
            hPictureBox.Size = new Size(380, 238);
            hPictureBox.TabIndex = 27;
            hPictureBox.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(805, 637);
            label10.Name = "label10";
            label10.Size = new Size(72, 41);
            label10.TabIndex = 28;
            label10.Text = "Hue";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1206, 637);
            label11.Name = "label11";
            label11.Size = new Size(153, 41);
            label11.TabIndex = 34;
            label11.Text = "Saturation";
            label11.Click += label11_Click;
            // 
            // sPictureBox
            // 
            sPictureBox.BackColor = SystemColors.ControlLight;
            sPictureBox.Location = new Point(1105, 697);
            sPictureBox.Name = "sPictureBox";
            sPictureBox.Size = new Size(380, 238);
            sPictureBox.TabIndex = 33;
            sPictureBox.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1119, 1019);
            label12.Name = "label12";
            label12.Size = new Size(69, 41);
            label12.TabIndex = 32;
            label12.Text = "Min";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1114, 1139);
            label13.Name = "label13";
            label13.Size = new Size(74, 41);
            label13.TabIndex = 31;
            label13.Text = "Max";
            // 
            // sMaxBar
            // 
            sMaxBar.Location = new Point(1240, 1139);
            sMaxBar.Maximum = 255;
            sMaxBar.Name = "sMaxBar";
            sMaxBar.Size = new Size(130, 114);
            sMaxBar.TabIndex = 30;
            sMaxBar.Value = 255;
            sMaxBar.Scroll += sMaxBar_Scroll;
            // 
            // sMinBar
            // 
            sMinBar.Location = new Point(1240, 1019);
            sMinBar.Maximum = 255;
            sMinBar.Name = "sMinBar";
            sMinBar.Size = new Size(130, 114);
            sMinBar.TabIndex = 29;
            sMinBar.Value = 200;
            sMinBar.Scroll += sMinBar_Scroll;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1715, 637);
            label14.Name = "label14";
            label14.Size = new Size(90, 41);
            label14.TabIndex = 40;
            label14.Text = "Value";
            // 
            // vPictureBox
            // 
            vPictureBox.BackColor = SystemColors.ControlLight;
            vPictureBox.Location = new Point(1594, 697);
            vPictureBox.Name = "vPictureBox";
            vPictureBox.Size = new Size(380, 238);
            vPictureBox.TabIndex = 39;
            vPictureBox.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1594, 1019);
            label15.Name = "label15";
            label15.Size = new Size(69, 41);
            label15.TabIndex = 38;
            label15.Text = "Min";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1589, 1139);
            label16.Name = "label16";
            label16.Size = new Size(74, 41);
            label16.TabIndex = 37;
            label16.Text = "Max";
            // 
            // vMaxBar
            // 
            vMaxBar.Location = new Point(1715, 1139);
            vMaxBar.Maximum = 255;
            vMaxBar.Name = "vMaxBar";
            vMaxBar.Size = new Size(130, 114);
            vMaxBar.TabIndex = 36;
            vMaxBar.Value = 255;
            vMaxBar.Scroll += vMaxBar_Scroll;
            // 
            // vMinBar
            // 
            vMinBar.Location = new Point(1715, 1019);
            vMinBar.Maximum = 255;
            vMinBar.Name = "vMinBar";
            vMinBar.Size = new Size(130, 114);
            vMinBar.TabIndex = 35;
            vMinBar.Value = 128;
            vMinBar.Scroll += vMinBar_Scroll;
            // 
            // VideoPictureBox2
            // 
            VideoPictureBox2.BackColor = SystemColors.ControlDark;
            VideoPictureBox2.Location = new Point(933, 93);
            VideoPictureBox2.Name = "VideoPictureBox2";
            VideoPictureBox2.Size = new Size(600, 400);
            VideoPictureBox2.TabIndex = 41;
            VideoPictureBox2.TabStop = false;
            // 
            // HueMinBox
            // 
            HueMinBox.Location = new Point(901, 1019);
            HueMinBox.Name = "HueMinBox";
            HueMinBox.Size = new Size(161, 47);
            HueMinBox.TabIndex = 42;
            // 
            // HueMaxBox
            // 
            HueMaxBox.Location = new Point(901, 1136);
            HueMaxBox.Name = "HueMaxBox";
            HueMaxBox.Size = new Size(161, 47);
            HueMaxBox.TabIndex = 43;
            // 
            // SatMaxBox
            // 
            SatMaxBox.Location = new Point(1393, 1139);
            SatMaxBox.Name = "SatMaxBox";
            SatMaxBox.Size = new Size(161, 47);
            SatMaxBox.TabIndex = 45;
            // 
            // SatMinBox
            // 
            SatMinBox.Location = new Point(1393, 1022);
            SatMinBox.Name = "SatMinBox";
            SatMinBox.Size = new Size(161, 47);
            SatMinBox.TabIndex = 44;
            // 
            // ValMaxBox
            // 
            ValMaxBox.Location = new Point(1868, 1139);
            ValMaxBox.Name = "ValMaxBox";
            ValMaxBox.Size = new Size(161, 47);
            ValMaxBox.TabIndex = 47;
            // 
            // ValMinBox
            // 
            ValMinBox.Location = new Point(1868, 1022);
            ValMinBox.Name = "ValMinBox";
            ValMinBox.Size = new Size(161, 47);
            ValMinBox.TabIndex = 46;
            // 
            // SerialBox
            // 
            SerialBox.Location = new Point(30, 1204);
            SerialBox.Name = "SerialBox";
            SerialBox.Size = new Size(286, 47);
            SerialBox.TabIndex = 48;
            // 
            // motoronbutton
            // 
            motoronbutton.Location = new Point(30, 1459);
            motoronbutton.Name = "motoronbutton";
            motoronbutton.Size = new Size(188, 58);
            motoronbutton.TabIndex = 49;
            motoronbutton.Text = "False";
            motoronbutton.UseVisualStyleBackColor = true;
            motoronbutton.Click += motoronbutton_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(68, 1402);
            label17.Name = "label17";
            label17.Size = new Size(114, 41);
            label17.TabIndex = 50;
            label17.Text = "Motors";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(622, 616);
            label18.Name = "label18";
            label18.Size = new Size(102, 41);
            label18.TabIndex = 51;
            label18.Text = "Yellow";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(570, 1073);
            label19.Name = "label19";
            label19.Size = new Size(102, 41);
            label19.TabIndex = 76;
            label19.Text = "Yellow";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(1663, 1094);
            label20.Name = "label20";
            label20.Size = new Size(90, 41);
            label20.TabIndex = 69;
            label20.Text = "Value";
            // 
            // vPictureBox2
            // 
            vPictureBox2.BackColor = SystemColors.ControlLight;
            vPictureBox2.Location = new Point(1542, 1229);
            vPictureBox2.Name = "vPictureBox2";
            vPictureBox2.Size = new Size(303, 163);
            vPictureBox2.TabIndex = 68;
            vPictureBox2.TabStop = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1154, 1094);
            label23.Name = "label23";
            label23.Size = new Size(153, 41);
            label23.TabIndex = 63;
            label23.Text = "Saturation";
            // 
            // sPictureBox2
            // 
            sPictureBox2.BackColor = SystemColors.ControlLight;
            sPictureBox2.Location = new Point(1053, 1229);
            sPictureBox2.Name = "sPictureBox2";
            sPictureBox2.Size = new Size(303, 163);
            sPictureBox2.TabIndex = 62;
            sPictureBox2.TabStop = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(753, 1094);
            label26.Name = "label26";
            label26.Size = new Size(72, 41);
            label26.TabIndex = 57;
            label26.Text = "Hue";
            // 
            // hPictureBox2
            // 
            hPictureBox2.BackColor = SystemColors.ControlLight;
            hPictureBox2.Location = new Point(571, 1229);
            hPictureBox2.Name = "hPictureBox2";
            hPictureBox2.Size = new Size(303, 163);
            hPictureBox2.TabIndex = 56;
            hPictureBox2.TabStop = false;
            // 
            // VideoPictureBox4
            // 
            VideoPictureBox4.BackColor = SystemColors.ControlDark;
            VideoPictureBox4.Location = new Point(1969, 1229);
            VideoPictureBox4.Name = "VideoPictureBox4";
            VideoPictureBox4.Size = new Size(282, 163);
            VideoPictureBox4.TabIndex = 77;
            VideoPictureBox4.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1969, 1426);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 47);
            textBox2.TabIndex = 79;
            textBox2.Text = "Red Pixels";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // RedPixelsTextBox
            // 
            RedPixelsTextBox.Location = new Point(1969, 1488);
            RedPixelsTextBox.Name = "RedPixelsTextBox";
            RedPixelsTextBox.Size = new Size(286, 47);
            RedPixelsTextBox.TabIndex = 78;
            RedPixelsTextBox.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2500, 1717);
            Controls.Add(textBox2);
            Controls.Add(RedPixelsTextBox);
            Controls.Add(VideoPictureBox4);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(vPictureBox2);
            Controls.Add(label23);
            Controls.Add(sPictureBox2);
            Controls.Add(label26);
            Controls.Add(hPictureBox2);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(motoronbutton);
            Controls.Add(SerialBox);
            Controls.Add(ValMaxBox);
            Controls.Add(ValMinBox);
            Controls.Add(SatMaxBox);
            Controls.Add(SatMinBox);
            Controls.Add(HueMaxBox);
            Controls.Add(HueMinBox);
            Controls.Add(VideoPictureBox2);
            Controls.Add(label14);
            Controls.Add(vPictureBox);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(vMaxBar);
            Controls.Add(vMinBar);
            Controls.Add(label11);
            Controls.Add(sPictureBox);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(sMaxBar);
            Controls.Add(sMinBar);
            Controls.Add(label10);
            Controls.Add(hPictureBox);
            Controls.Add(ActionBox);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(hMaxBar);
            Controls.Add(hMinBar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LMLabel);
            Controls.Add(Split5);
            Controls.Add(Split4);
            Controls.Add(Split3);
            Controls.Add(Split2);
            Controls.Add(Split1);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(ThresholdBarMax);
            Controls.Add(WhitePixelBox);
            Controls.Add(ThresholdBarMin);
            Controls.Add(VideoPictureBox3);
            Controls.Add(VideoPictureBox);
            Controls.Add(StartStopBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdBarMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdBarMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)hMaxBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)hMinBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)hPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sMaxBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sMinBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)vPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)vMaxBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)vMinBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopBtn;
        private PictureBox VideoPictureBox;
        private PictureBox VideoPictureBox3;
        private TrackBar ThresholdBarMin;
        private TextBox WhitePixelBox;
        private TrackBar ThresholdBarMax;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox Split1;
        private TextBox Split2;
        private TextBox Split3;
        private TextBox Split4;
        private TextBox Split5;
        private Label LMLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TrackBar hMaxBar;
        private TrackBar hMinBar;
        private Label label9;
        private Label ActionBox;
        private PictureBox hPictureBox;
        private Label label10;
        private Label label11;
        private PictureBox sPictureBox;
        private Label label12;
        private Label label13;
        private TrackBar sMaxBar;
        private TrackBar sMinBar;
        private Label label14;
        private PictureBox vPictureBox;
        private Label label15;
        private Label label16;
        private TrackBar vMaxBar;
        private TrackBar vMinBar;
        private PictureBox VideoPictureBox2;
        private TextBox HueMinBox;
        private TextBox HueMaxBox;
        private TextBox SatMaxBox;
        private TextBox SatMinBox;
        private TextBox ValMaxBox;
        private TextBox ValMinBox;
        private TextBox SerialBox;
        private Button motoronbutton;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private PictureBox vPictureBox2;
        private Label label23;
        private PictureBox sPictureBox2;
        private Label label26;
        private PictureBox hPictureBox2;
        private PictureBox VideoPictureBox4;
        private TextBox textBox2;
        private TextBox RedPixelsTextBox;
    }
}