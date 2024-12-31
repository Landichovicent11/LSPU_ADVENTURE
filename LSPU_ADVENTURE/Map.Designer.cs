namespace LSPU_ADVENTURE
{
    partial class Map
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
            LecCSS = new Button();
            PE = new Button();
            Recess = new Button();
            LabCSS = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LecCSS
            // 
            LecCSS.Location = new Point(447, 468);
            LecCSS.Name = "LecCSS";
            LecCSS.Size = new Size(150, 29);
            LecCSS.TabIndex = 1;
            LecCSS.Text = "LectureBuildingCSS";
            LecCSS.UseVisualStyleBackColor = true;
            LecCSS.Click += LecCSS_Click;
            // 
            // PE
            // 
            PE.Location = new Point(620, 468);
            PE.Name = "PE";
            PE.Size = new Size(94, 29);
            PE.TabIndex = 2;
            PE.Text = "GYM";
            PE.UseVisualStyleBackColor = true;
            PE.Click += PE_Click;
            // 
            // Recess
            // 
            Recess.Location = new Point(736, 468);
            Recess.Name = "Recess";
            Recess.Size = new Size(94, 29);
            Recess.TabIndex = 3;
            Recess.Text = "Cafeteria";
            Recess.UseVisualStyleBackColor = true;
            Recess.Click += Recess_Click;
            // 
            // LabCSS
            // 
            LabCSS.Location = new Point(848, 468);
            LabCSS.Name = "LabCSS";
            LabCSS.Size = new Size(94, 29);
            LabCSS.TabIndex = 4;
            LabCSS.Text = "LabCSS";
            LabCSS.UseVisualStyleBackColor = true;
            LabCSS.Click += LabCSS_Click;
            // 
            // Map
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._466871878_423296197417442_7650429848136589711_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 700);
            Controls.Add(LabCSS);
            Controls.Add(Recess);
            Controls.Add(PE);
            Controls.Add(LecCSS);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Map";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Map";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button LecCSS;
        private Button PE;
        private Button Recess;
        private Button LabCSS;
    }
}