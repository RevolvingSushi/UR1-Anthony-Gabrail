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
            trackBar1 = new TrackBar();
            WhitePixelBox = new TextBox();
            trackBar2 = new TrackBar();
            VideoPictureBox3 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // StartStopBtn
            // 
            StartStopBtn.Location = new Point(1129, 1239);
            StartStopBtn.Name = "StartStopBtn";
            StartStopBtn.Size = new Size(188, 58);
            StartStopBtn.TabIndex = 0;
            StartStopBtn.Text = "Start";
            StartStopBtn.UseVisualStyleBackColor = true;
            StartStopBtn.Click += button1_Click;
            // 
            // VideoPictureBox
            // 
            VideoPictureBox.Location = new Point(197, 384);
            VideoPictureBox.Name = "VideoPictureBox";
            VideoPictureBox.Size = new Size(502, 502);
            VideoPictureBox.TabIndex = 1;
            VideoPictureBox.TabStop = false;
            VideoPictureBox.Click += VideoPictureBox_Click;
            // 
            // VideoPictureBox2
            // 
            VideoPictureBox2.Location = new Point(795, 384);
            VideoPictureBox2.Name = "VideoPictureBox2";
            VideoPictureBox2.Size = new Size(522, 502);
            VideoPictureBox2.TabIndex = 2;
            VideoPictureBox2.TabStop = false;
            VideoPictureBox2.Click += VideoPictureBox2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(1448, 1206);
            trackBar1.Maximum = 255;
            trackBar1.Minimum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(576, 114);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // WhitePixelBox
            // 
            WhitePixelBox.Location = new Point(369, 1239);
            WhitePixelBox.Name = "WhitePixelBox";
            WhitePixelBox.Size = new Size(286, 47);
            WhitePixelBox.TabIndex = 4;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(1448, 1326);
            trackBar2.Maximum = 255;
            trackBar2.Minimum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(576, 114);
            trackBar2.TabIndex = 5;
            trackBar2.Value = 100;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // VideoPictureBox3
            // 
            VideoPictureBox3.Location = new Point(1429, 384);
            VideoPictureBox3.Name = "VideoPictureBox3";
            VideoPictureBox3.Size = new Size(522, 502);
            VideoPictureBox3.TabIndex = 6;
            VideoPictureBox3.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(818, 1148);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(197, 45);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2500, 1717);
            Controls.Add(checkBox1);
            Controls.Add(VideoPictureBox3);
            Controls.Add(trackBar2);
            Controls.Add(WhitePixelBox);
            Controls.Add(trackBar1);
            Controls.Add(VideoPictureBox2);
            Controls.Add(VideoPictureBox);
            Controls.Add(StartStopBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopBtn;
        private PictureBox VideoPictureBox;
        private PictureBox VideoPictureBox2;
        private TrackBar trackBar1;
        private TextBox WhitePixelBox;
        private TrackBar trackBar2;
        private PictureBox VideoPictureBox3;
        private CheckBox checkBox1;
    }
}