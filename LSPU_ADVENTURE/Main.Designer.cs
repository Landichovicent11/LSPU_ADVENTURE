namespace LSPU_ADVENTURE
{
    partial class Main
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            Start = new Button();
            Settings = new Button();
            Exit = new Button();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.photo2pixel_download__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(101, 100);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.light_soft_color_blue_low_poly_crystal_background_polygon_design_pattern_low_poly_illustration_low_polygon_background_free_vector;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(690, 66);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 450);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(727, 87);
            label1.Name = "label1";
            label1.Size = new Size(280, 47);
            label1.TabIndex = 2;
            label1.Text = "LSPU-Simulator";
            label1.Click += label1_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.DarkSlateGray;
            Start.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start.ForeColor = SystemColors.ButtonHighlight;
            Start.Location = new Point(777, 162);
            Start.Margin = new Padding(3, 2, 3, 2);
            Start.Name = "Start";
            Start.Size = new Size(184, 38);
            Start.TabIndex = 3;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Settings
            // 
            Settings.BackColor = Color.DarkSlateGray;
            Settings.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settings.ForeColor = SystemColors.ButtonHighlight;
            Settings.Location = new Point(777, 236);
            Settings.Margin = new Padding(3, 2, 3, 2);
            Settings.Name = "Settings";
            Settings.Size = new Size(184, 38);
            Settings.TabIndex = 4;
            Settings.Text = "Preference";
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += Settings_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.DarkSlateGray;
            Exit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.ButtonHighlight;
            Exit.Location = new Point(777, 312);
            Exit.Margin = new Padding(3, 2, 3, 2);
            Exit.Name = "Exit";
            Exit.Size = new Size(184, 38);
            Exit.TabIndex = 5;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = SystemColors.ButtonHighlight;
            checkBox2.Location = new Point(10, 522);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(177, 36);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "LeaderBoard";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += Leader_CheckedChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cool_Blue_Gradient_Lights_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 525);
            Controls.Add(checkBox2);
            Controls.Add(Exit);
            Controls.Add(Settings);
            Controls.Add(Start);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button Start;
        private Button Settings;
        private Button Exit;
        private CheckBox checkBox2;
    }
}