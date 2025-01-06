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
            Librarybutton2 = new Button();
            btn_IM = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(111, 32);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LecCSS
            // 
            LecCSS.Location = new Point(391, 351);
            LecCSS.Margin = new Padding(3, 2, 3, 2);
            LecCSS.Name = "LecCSS";
            LecCSS.Size = new Size(131, 22);
            LecCSS.TabIndex = 1;
            LecCSS.Text = "LectureBuildingCSS";
            LecCSS.UseVisualStyleBackColor = true;
            LecCSS.Click += LecCSS_Click;
            // 
            // PE
            // 
            PE.Location = new Point(542, 351);
            PE.Margin = new Padding(3, 2, 3, 2);
            PE.Name = "PE";
            PE.Size = new Size(82, 22);
            PE.TabIndex = 2;
            PE.Text = "GYM";
            PE.UseVisualStyleBackColor = true;
            PE.Click += PE_Click;
            // 
            // Recess
            // 
            Recess.Location = new Point(644, 351);
            Recess.Margin = new Padding(3, 2, 3, 2);
            Recess.Name = "Recess";
            Recess.Size = new Size(82, 22);
            Recess.TabIndex = 3;
            Recess.Text = "Cafeteria";
            Recess.UseVisualStyleBackColor = true;
            Recess.Click += Recess_Click;
            // 
            // LabCSS
            // 
            LabCSS.Location = new Point(742, 351);
            LabCSS.Margin = new Padding(3, 2, 3, 2);
            LabCSS.Name = "LabCSS";
            LabCSS.Size = new Size(82, 22);
            LabCSS.TabIndex = 4;
            LabCSS.Text = "LabCSS";
            LabCSS.UseVisualStyleBackColor = true;
            LabCSS.Click += LabCSS_Click;
            // 
            // Librarybutton2
            // 
            Librarybutton2.Location = new Point(830, 350);
            Librarybutton2.Name = "Librarybutton2";
            Librarybutton2.Size = new Size(75, 23);
            Librarybutton2.TabIndex = 5;
            Librarybutton2.Text = "Library";
            Librarybutton2.UseVisualStyleBackColor = true;
            Librarybutton2.Click += Librarybutton2_Click;
            // 
            // btn_IM
            // 
            btn_IM.Location = new Point(412, 386);
            btn_IM.Margin = new Padding(3, 2, 3, 2);
            btn_IM.Name = "btn_IM";
            btn_IM.Size = new Size(82, 22);
            btn_IM.TabIndex = 6;
            btn_IM.Text = "IM";
            btn_IM.UseVisualStyleBackColor = true;
            btn_IM.Click += btn_IM_Click;
            // 
            // Map
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._466871878_423296197417442_7650429848136589711_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 525);
            Controls.Add(btn_IM);
            Controls.Add(Librarybutton2);
            Controls.Add(LabCSS);
            Controls.Add(Recess);
            Controls.Add(PE);
            Controls.Add(LecCSS);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button Librarybutton2;
        private Button btn_IM;
    }
}