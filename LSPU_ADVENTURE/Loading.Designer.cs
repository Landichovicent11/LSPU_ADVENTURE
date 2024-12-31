namespace LSPU_ADVENTURE
{
    partial class LoadingScreen
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            Logo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            LoadingText = new Label();
            LoadingPercentage = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Location = new Point(-5, 449);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(509, 30);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = Properties.Resources.photo2pixel_download__1_;
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.Location = new Point(43, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(400, 365);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoadingText
            // 
            LoadingText.AutoSize = true;
            LoadingText.BackColor = Color.Transparent;
            LoadingText.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadingText.ForeColor = Color.MediumTurquoise;
            LoadingText.Location = new Point(194, 422);
            LoadingText.Name = "LoadingText";
            LoadingText.Size = new Size(80, 23);
            LoadingText.TabIndex = 3;
            LoadingText.Text = "Loading:";
            // 
            // LoadingPercentage
            // 
            LoadingPercentage.AutoSize = true;
            LoadingPercentage.BackColor = Color.Transparent;
            LoadingPercentage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadingPercentage.ForeColor = Color.Aqua;
            LoadingPercentage.Location = new Point(280, 425);
            LoadingPercentage.Name = "LoadingPercentage";
            LoadingPercentage.Size = new Size(22, 20);
            LoadingPercentage.TabIndex = 4;
            LoadingPercentage.Text = "%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(130, 384);
            label1.Name = "label1";
            label1.Size = new Size(241, 41);
            label1.TabIndex = 5;
            label1.Text = "LSPU-Simulator";
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cool_Blue_Gradient_Lights_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 500);
            Controls.Add(label1);
            Controls.Add(LoadingPercentage);
            Controls.Add(LoadingText);
            Controls.Add(Logo);
            Controls.Add(progressBar1);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LSPU_SIMULATOR";
            Load += LoadingScreen_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private PictureBox Logo;
        private System.Windows.Forms.Timer timer1;
        private Label LoadingText;
        private Label LoadingPercentage;
        private Label label1;
    }
}
