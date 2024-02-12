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
            VideoPictureBox2 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox2).BeginInit();
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
            SuspendLayout();
            // 
            // StartStopBtn
            // 
            StartStopBtn.Location = new Point(39, 1622);
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
            VideoPictureBox.Location = new Point(211, 220);
            VideoPictureBox.Name = "VideoPictureBox";
            VideoPictureBox.Size = new Size(900, 600);
            VideoPictureBox.TabIndex = 1;
            VideoPictureBox.TabStop = false;
            VideoPictureBox.Click += VideoPictureBox_Click;
            // 
            // VideoPictureBox2
            // 
            VideoPictureBox2.BackColor = SystemColors.ControlDark;
            VideoPictureBox2.Location = new Point(1199, 220);
            VideoPictureBox2.Name = "VideoPictureBox2";
            VideoPictureBox2.Size = new Size(900, 600);
            VideoPictureBox2.TabIndex = 2;
            VideoPictureBox2.TabStop = false;
            VideoPictureBox2.Click += VideoPictureBox2_Click;
            // 
            // ThresholdBarMin
            // 
            ThresholdBarMin.Location = new Point(571, 842);
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
            ThresholdBarMax.Location = new Point(571, 962);
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
            Split1.Location = new Point(1147, 888);
            Split1.Name = "Split1";
            Split1.Size = new Size(180, 47);
            Split1.TabIndex = 9;
            // 
            // Split2
            // 
            Split2.Location = new Point(1353, 888);
            Split2.Name = "Split2";
            Split2.Size = new Size(180, 47);
            Split2.TabIndex = 10;
            // 
            // Split3
            // 
            Split3.Location = new Point(1561, 888);
            Split3.Name = "Split3";
            Split3.Size = new Size(180, 47);
            Split3.TabIndex = 11;
            // 
            // Split4
            // 
            Split4.Location = new Point(1766, 888);
            Split4.Name = "Split4";
            Split4.Size = new Size(180, 47);
            Split4.TabIndex = 12;
            // 
            // Split5
            // 
            Split5.Location = new Point(1967, 888);
            Split5.Name = "Split5";
            Split5.Size = new Size(180, 47);
            Split5.TabIndex = 13;
            // 
            // LMLabel
            // 
            LMLabel.AutoSize = true;
            LMLabel.Location = new Point(1162, 842);
            LMLabel.Name = "LMLabel";
            LMLabel.Size = new Size(143, 41);
            LMLabel.TabIndex = 14;
            LMLabel.Text = "Left Most";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1353, 842);
            label1.Name = "label1";
            label1.Size = new Size(168, 41);
            label1.TabIndex = 15;
            label1.Text = "Middle Left";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1593, 842);
            label2.Name = "label2";
            label2.Size = new Size(111, 41);
            label2.TabIndex = 16;
            label2.Text = "Middle";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1757, 842);
            label3.Name = "label3";
            label3.Size = new Size(189, 41);
            label3.TabIndex = 17;
            label3.Text = "Middle Right";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1983, 842);
            label4.Name = "label4";
            label4.Size = new Size(164, 41);
            label4.TabIndex = 18;
            label4.Text = "Right Most";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 962);
            label5.Name = "label5";
            label5.Size = new Size(74, 41);
            label5.TabIndex = 19;
            label5.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 842);
            label6.Name = "label6";
            label6.Size = new Size(69, 41);
            label6.TabIndex = 20;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(607, 1447);
            label7.Name = "label7";
            label7.Size = new Size(69, 41);
            label7.TabIndex = 24;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(602, 1567);
            label8.Name = "label8";
            label8.Size = new Size(74, 41);
            label8.TabIndex = 23;
            label8.Text = "Max";
            // 
            // hMaxBar
            // 
            hMaxBar.Location = new Point(728, 1567);
            hMaxBar.Maximum = 255;
            hMaxBar.Name = "hMaxBar";
            hMaxBar.Size = new Size(200, 114);
            hMaxBar.TabIndex = 22;
            hMaxBar.Value = 255;
            // 
            // hMinBar
            // 
            hMinBar.Location = new Point(728, 1447);
            hMinBar.Maximum = 255;
            hMinBar.Name = "hMinBar";
            hMinBar.Size = new Size(200, 114);
            hMinBar.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2137, 1207);
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
            ActionBox.Location = new Point(2107, 1248);
            ActionBox.Name = "ActionBox";
            ActionBox.Size = new Size(272, 72);
            ActionBox.TabIndex = 26;
            ActionBox.Text = "ActionBox";
            ActionBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hPictureBox
            // 
            hPictureBox.BackColor = SystemColors.ControlLight;
            hPictureBox.Location = new Point(546, 1125);
            hPictureBox.Name = "hPictureBox";
            hPictureBox.Size = new Size(450, 300);
            hPictureBox.TabIndex = 27;
            hPictureBox.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(728, 1065);
            label10.Name = "label10";
            label10.Size = new Size(72, 41);
            label10.TabIndex = 28;
            label10.Text = "Hue";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1210, 1065);
            label11.Name = "label11";
            label11.Size = new Size(153, 41);
            label11.TabIndex = 34;
            label11.Text = "Saturation";
            label11.Click += label11_Click;
            // 
            // sPictureBox
            // 
            sPictureBox.BackColor = SystemColors.ControlLight;
            sPictureBox.Location = new Point(1028, 1125);
            sPictureBox.Name = "sPictureBox";
            sPictureBox.Size = new Size(450, 300);
            sPictureBox.TabIndex = 33;
            sPictureBox.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1089, 1447);
            label12.Name = "label12";
            label12.Size = new Size(69, 41);
            label12.TabIndex = 32;
            label12.Text = "Min";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1084, 1567);
            label13.Name = "label13";
            label13.Size = new Size(74, 41);
            label13.TabIndex = 31;
            label13.Text = "Max";
            // 
            // sMaxBar
            // 
            sMaxBar.Location = new Point(1210, 1567);
            sMaxBar.Maximum = 255;
            sMaxBar.Name = "sMaxBar";
            sMaxBar.Size = new Size(200, 114);
            sMaxBar.TabIndex = 30;
            sMaxBar.Value = 255;
            // 
            // sMinBar
            // 
            sMinBar.Location = new Point(1210, 1447);
            sMinBar.Maximum = 255;
            sMinBar.Name = "sMinBar";
            sMinBar.Size = new Size(200, 114);
            sMinBar.TabIndex = 29;
            sMinBar.Value = 150;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1699, 1065);
            label14.Name = "label14";
            label14.Size = new Size(90, 41);
            label14.TabIndex = 40;
            label14.Text = "Value";
            // 
            // vPictureBox
            // 
            vPictureBox.BackColor = SystemColors.ControlLight;
            vPictureBox.Location = new Point(1517, 1125);
            vPictureBox.Name = "vPictureBox";
            vPictureBox.Size = new Size(450, 300);
            vPictureBox.TabIndex = 39;
            vPictureBox.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1578, 1447);
            label15.Name = "label15";
            label15.Size = new Size(69, 41);
            label15.TabIndex = 38;
            label15.Text = "Min";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1573, 1567);
            label16.Name = "label16";
            label16.Size = new Size(74, 41);
            label16.TabIndex = 37;
            label16.Text = "Max";
            // 
            // vMaxBar
            // 
            vMaxBar.Location = new Point(1699, 1567);
            vMaxBar.Maximum = 255;
            vMaxBar.Name = "vMaxBar";
            vMaxBar.Size = new Size(200, 114);
            vMaxBar.TabIndex = 36;
            vMaxBar.Value = 255;
            // 
            // vMinBar
            // 
            vMinBar.Location = new Point(1699, 1447);
            vMinBar.Maximum = 255;
            vMinBar.Name = "vMinBar";
            vMinBar.Size = new Size(200, 114);
            vMinBar.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2500, 1717);
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
            Controls.Add(VideoPictureBox2);
            Controls.Add(VideoPictureBox);
            Controls.Add(StartStopBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox2).EndInit();
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopBtn;
        private PictureBox VideoPictureBox;
        private PictureBox VideoPictureBox2;
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
    }
}