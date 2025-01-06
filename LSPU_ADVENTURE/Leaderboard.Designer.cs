namespace LSPU_ADVENTURE
{
    partial class Leaderboard
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
            listViewLeaderboard = new ListView();
            librarylistView1 = new ListView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listViewLeaderboard
            // 
            listViewLeaderboard.BackColor = Color.LemonChiffon;
            listViewLeaderboard.Location = new Point(12, 73);
            listViewLeaderboard.Name = "listViewLeaderboard";
            listViewLeaderboard.Size = new Size(166, 365);
            listViewLeaderboard.TabIndex = 0;
            listViewLeaderboard.UseCompatibleStateImageBehavior = false;
            listViewLeaderboard.View = View.Details;
            listViewLeaderboard.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // librarylistView1
            // 
            librarylistView1.BackColor = Color.LemonChiffon;
            librarylistView1.Location = new Point(184, 73);
            librarylistView1.Name = "librarylistView1";
            librarylistView1.Size = new Size(166, 365);
            librarylistView1.TabIndex = 1;
            librarylistView1.UseCompatibleStateImageBehavior = false;
            librarylistView1.SelectedIndexChanged += librarylistView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 53);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 3;
            label1.Text = "TypingGameRecess";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(237, 53);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 4;
            label2.Text = "Library";
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Light_Blue_Wallpaper_Designs;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(librarylistView1);
            Controls.Add(listViewLeaderboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Leaderboard";
            Text = "Leaderboard";
            Load += Leaderboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewLeaderboard;
        private ListView librarylistView1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}