namespace LSPU_ADVENTURE
{
    partial class Settings
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
            button1 = new Button();
            aboutbutton2 = new Button();
            leaderboardbutton3 = new Button();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(386, 76);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(290, 77);
            button1.TabIndex = 0;
            button1.Text = "Music";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // aboutbutton2
            // 
            aboutbutton2.BackColor = Color.Navy;
            aboutbutton2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutbutton2.ForeColor = Color.White;
            aboutbutton2.Location = new Point(386, 157);
            aboutbutton2.Margin = new Padding(3, 2, 3, 2);
            aboutbutton2.Name = "aboutbutton2";
            aboutbutton2.Size = new Size(290, 77);
            aboutbutton2.TabIndex = 1;
            aboutbutton2.Text = "About Us";
            aboutbutton2.UseVisualStyleBackColor = false;
            aboutbutton2.Click += aboutbutton2_Click;
            // 
            // leaderboardbutton3
            // 
            leaderboardbutton3.BackColor = Color.Navy;
            leaderboardbutton3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leaderboardbutton3.ForeColor = Color.White;
            leaderboardbutton3.Location = new Point(386, 238);
            leaderboardbutton3.Margin = new Padding(3, 2, 3, 2);
            leaderboardbutton3.Name = "leaderboardbutton3";
            leaderboardbutton3.Size = new Size(290, 77);
            leaderboardbutton3.TabIndex = 2;
            leaderboardbutton3.Text = "Leaderboards";
            leaderboardbutton3.UseVisualStyleBackColor = false;
            leaderboardbutton3.Click += leaderboardbutton3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 427);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 3;
            label1.Text = "PREFERENCE";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(386, 320);
            button2.Name = "button2";
            button2.Size = new Size(290, 77);
            button2.TabIndex = 4;
            button2.Text = "Tutorials";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.photo2pixel_download__1_;
            pictureBox1.Location = new Point(12, 407);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSlateGray;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 6;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Light_Blue_Wallpaper_Designs;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 490);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(leaderboardbutton3);
            Controls.Add(aboutbutton2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button aboutbutton2;
        private Button leaderboardbutton3;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}