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
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // StartStopBtn
            // 
            StartStopBtn.Location = new Point(874, 667);
            StartStopBtn.Name = "StartStopBtn";
            StartStopBtn.Size = new Size(188, 58);
            StartStopBtn.TabIndex = 0;
            StartStopBtn.Text = "Start";
            StartStopBtn.UseVisualStyleBackColor = true;
            StartStopBtn.Click += button1_Click;
            // 
            // VideoPictureBox
            // 
            VideoPictureBox.Location = new Point(192, 81);
            VideoPictureBox.Name = "VideoPictureBox";
            VideoPictureBox.Size = new Size(690, 464);
            VideoPictureBox.TabIndex = 1;
            VideoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 769);
            Controls.Add(VideoPictureBox);
            Controls.Add(StartStopBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)VideoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button StartStopBtn;
        private PictureBox VideoPictureBox;
    }
}