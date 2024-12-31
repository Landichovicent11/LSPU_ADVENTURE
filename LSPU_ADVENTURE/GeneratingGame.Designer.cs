namespace LSPU_ADVENTURE
{
    partial class GeneratingGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Logo = new PictureBox();
            DotGenerate = new Label();
            DotGenerator = new Label();
            timerGenerator = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = Properties.Resources.photo2pixel_download__1_;
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.Location = new Point(260, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(280, 280);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // DotGenerate
            // 
            DotGenerate.AutoSize = true;
            DotGenerate.BackColor = Color.Transparent;
            DotGenerate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DotGenerate.ForeColor = Color.WhiteSmoke;
            DotGenerate.Location = new Point(401, 371);
            DotGenerate.Name = "DotGenerate";
            DotGenerate.Size = new Size(0, 38);
            DotGenerate.TabIndex = 3;
            // 
            // DotGenerator
            // 
            DotGenerator.AutoSize = true;
            DotGenerator.BackColor = Color.Transparent;
            DotGenerator.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DotGenerator.ForeColor = SystemColors.ButtonHighlight;
            DotGenerator.Location = new Point(284, 354);
            DotGenerator.Name = "DotGenerator";
            DotGenerator.Size = new Size(183, 41);
            DotGenerator.TabIndex = 4;
            DotGenerator.Text = "Generating.";
            // 
            // timerGenerator
            // 
            timerGenerator.Tick += timerGame;
            // 
            // GeneratingGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Loading_screen_blur1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(DotGenerator);
            Controls.Add(DotGenerate);
            Controls.Add(Logo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneratingGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += GeneratingGame_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Logo;
        private Label DotGenerate;
        private Label DotGenerator;
        private System.Windows.Forms.Timer timerGenerator;
    }
}