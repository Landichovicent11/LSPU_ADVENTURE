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
            SuspendLayout();
            // 
            // listViewLeaderboard
            // 
            listViewLeaderboard.Location = new Point(150, 12);
            listViewLeaderboard.Name = "listViewLeaderboard";
            listViewLeaderboard.Size = new Size(511, 426);
            listViewLeaderboard.TabIndex = 0;
            listViewLeaderboard.UseCompatibleStateImageBehavior = false;
            listViewLeaderboard.View = View.Details;
            listViewLeaderboard.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewLeaderboard);
            Name = "Leaderboard";
            Text = "Leaderboard";
            Load += Leaderboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewLeaderboard;
    }
}