namespace LSPU_ADVENTURE
{
    partial class GamesLecture
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
            ArtApp = new Button();
            Discrete = new Button();
            IM = new Button();
            Random = new Button();
            OOPbutton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ArtApp
            // 
            ArtApp.Location = new Point(318, 64);
            ArtApp.Name = "ArtApp";
            ArtApp.Size = new Size(94, 29);
            ArtApp.TabIndex = 0;
            ArtApp.Text = "ArtApp";
            ArtApp.UseVisualStyleBackColor = true;
            ArtApp.Click += artapp;
            // 
            // Discrete
            // 
            Discrete.Location = new Point(318, 108);
            Discrete.Name = "Discrete";
            Discrete.Size = new Size(94, 29);
            Discrete.TabIndex = 1;
            Discrete.Text = "Discrete";
            Discrete.UseVisualStyleBackColor = true;
            Discrete.Click += discrete;
            // 
            // IM
            // 
            IM.Location = new Point(318, 156);
            IM.Name = "IM";
            IM.Size = new Size(94, 29);
            IM.TabIndex = 2;
            IM.Text = "IM";
            IM.UseVisualStyleBackColor = true;
            IM.Click += InfoManagement;
            // 
            // Random
            // 
            Random.Location = new Point(318, 203);
            Random.Name = "Random";
            Random.Size = new Size(94, 29);
            Random.TabIndex = 3;
            Random.Text = "Random";
            Random.UseVisualStyleBackColor = true;
            Random.Click += RandomGame;
            // 
            // OOPbutton
            // 
            OOPbutton.Location = new Point(318, 247);
            OOPbutton.Name = "OOPbutton";
            OOPbutton.Size = new Size(94, 29);
            OOPbutton.TabIndex = 4;
            OOPbutton.Text = "OOP";
            OOPbutton.UseVisualStyleBackColor = true;
            OOPbutton.Click += OOPbutton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GamesLecture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(OOPbutton);
            Controls.Add(Random);
            Controls.Add(IM);
            Controls.Add(Discrete);
            Controls.Add(ArtApp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GamesLecture";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Picking";
            ResumeLayout(false);
        }

        #endregion

        private Button ArtApp;
        private Button IM;
        private Button Random;
        private Button Discrete;
        private Button OOPbutton;
        private Button button1;
    }
}