namespace LSPU_ADVENTURE
{
    partial class TypingGameRecess
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ListBox lstGuessedFoods;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            lblTimeLeft = new Label();
            lblScore = new Label();
            txtGuess = new TextBox();
            btnSubmit = new Button();
            btnStartGame = new Button();
            lstGuessedFoods = new ListBox();
            button1 = new Button();
            button2 = new Button();
            btnShowLeaderboard = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = Properties.Resources.chicken;
            pictureBox.Location = new Point(432, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(445, 278);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.BackColor = Color.Transparent;
            lblTimeLeft.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTimeLeft.Location = new Point(501, 309);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(81, 17);
            lblTimeLeft.TabIndex = 1;
            lblTimeLeft.Text = "Time left: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblScore.Location = new Point(711, 309);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(69, 17);
            lblScore.TabIndex = 6;
            lblScore.Text = "Score: 0";
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGuess.Location = new Point(432, 346);
            txtGuess.Multiline = true;
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(445, 33);
            txtGuess.TabIndex = 2;
            txtGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkCyan;
            btnSubmit.FlatAppearance.BorderColor = Color.Teal;
            btnSubmit.FlatAppearance.BorderSize = 5;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(590, 400);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(122, 42);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit Guess";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.DarkCyan;
            btnStartGame.FlatAppearance.BorderColor = Color.Teal;
            btnStartGame.FlatAppearance.BorderSize = 5;
            btnStartGame.FlatStyle = FlatStyle.Flat;
            btnStartGame.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.ForeColor = Color.White;
            btnStartGame.Location = new Point(590, 400);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(122, 42);
            btnStartGame.TabIndex = 4;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lstGuessedFoods
            // 
            lstGuessedFoods.BackColor = Color.LemonChiffon;
            lstGuessedFoods.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstGuessedFoods.FormattingEnabled = true;
            lstGuessedFoods.ItemHeight = 22;
            lstGuessedFoods.Location = new Point(482, 466);
            lstGuessedFoods.Name = "lstGuessedFoods";
            lstGuessedFoods.Size = new Size(322, 114);
            lstGuessedFoods.TabIndex = 5;
            lstGuessedFoods.SelectedIndexChanged += lstGuessedFoods_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(44, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1161, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 8;
            button2.Text = "Pause";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnShowLeaderboard
            // 
            btnShowLeaderboard.BackColor = Color.Teal;
            btnShowLeaderboard.FlatAppearance.BorderColor = Color.White;
            btnShowLeaderboard.FlatStyle = FlatStyle.Flat;
            btnShowLeaderboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnShowLeaderboard.ForeColor = Color.White;
            btnShowLeaderboard.Location = new Point(1149, 619);
            btnShowLeaderboard.Name = "btnShowLeaderboard";
            btnShowLeaderboard.Size = new Size(123, 30);
            btnShowLeaderboard.TabIndex = 9;
            btnShowLeaderboard.Text = "Leaderboard";
            btnShowLeaderboard.UseVisualStyleBackColor = false;
            btnShowLeaderboard.Click += btnShowLeaderboard_Click_1;
            // 
            // TypingGameRecess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cafeteria;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 661);
            Controls.Add(btnShowLeaderboard);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstGuessedFoods);
            Controls.Add(lblScore);
            Controls.Add(btnStartGame);
            Controls.Add(btnSubmit);
            Controls.Add(txtGuess);
            Controls.Add(lblTimeLeft);
            Controls.Add(pictureBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TypingGameRecess";
            Text = "Guess the Food Game";
            Load += FoodGuessGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Timer gameTimer;
        private Button button1;
        private Button button2;
        private Button btnShowLeaderboard;
    }
}
