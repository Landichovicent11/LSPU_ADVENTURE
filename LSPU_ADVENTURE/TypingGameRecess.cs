using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LSPU_ADVENTURE
{
    public partial class TypingGameRecess : Form
    {
        private List<string> foodList = new List<string> { "burger", "fries", "hotdog" };
        private List<int> usedIndices = new List<int>();
        private List<string> imagePaths = new List<string>();
        private HashSet<string> guessedFoods = new HashSet<string>();
        private int timeLeft = 30;
        private int totalGameTime = 30 * 60;
        private int score = 0;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer gameDurationTimer;
        private Random random = new Random();
        private bool isPaused = false;

        public TypingGameRecess()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

            gameDurationTimer = new System.Windows.Forms.Timer();
            gameDurationTimer.Interval = 1000;
            gameDurationTimer.Tick += GameDurationTimer_Tick;

            string imageDirectory = @"C:\Users\akola\source\repos\LSPU_ADVENTURE\LSPU_ADVENTURE\Food";
            if (Directory.Exists(imageDirectory))
            {
                imagePaths = Directory.GetFiles(imageDirectory, "*.jpg").ToList();
            }

            lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
            lblScore.Text = $"Score: {score}";

            pictureBox.Visible = false;
            txtGuess.Enabled = false;
            btnSubmit.Visible = false;
            exitlinkLabel1.Visible = false;
        }

        private void LoadRandomImage()
        {
            if (imagePaths.Count == 0)
            {
                MessageBox.Show("No images found in the specified directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index;
            do
            {
                index = random.Next(imagePaths.Count);
            } while (usedIndices.Contains(index));

            usedIndices.Add(index);

            pictureBox.Image = Image.FromFile(imagePaths[index]);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Update the food list for the new image
            foodList = index switch
            {
                0 => new List<string> { "bacon", "bread", "egg", "cheese", "berries" },
                1 => new List<string> { "burger", "fries", "hotdog" },
                2 => new List<string> { "egg", "bread", "chicken" },
                3 => new List<string> { "kwek kwek" },
                4 => new List<string> { "taco" },
                5 => new List<string> { "bacon", "egg", "bread", "tomato" },
                _ => new List<string>()
            };
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
            }
            else
            {
                EndRound("Time's up! Game over.");
            }
        }

        private void GameDurationTimer_Tick(object sender, EventArgs e)
        {
            if (totalGameTime > 0)
            {
                totalGameTime--;
            }
            else
            {
                EndGame();
            }
        }

        private void EndRound(string message)
        {
            gameTimer.Stop();
            txtGuess.Clear();
            MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetGameControls();
        }

        private void EndGame()
        {
            gameDurationTimer.Stop();
            gameTimer.Stop();
            MessageBox.Show($"Game Over! Your total score is: {score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetGameControls();
        }

        private void ResetGameControls()
        {
            btnSubmit.Visible = false;
            txtGuess.Enabled = false;
            btnStartGame.Enabled = true;
            btnStartGame.Visible = true;
            lstGuessedFoods.Items.Clear();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            totalGameTime = 30 * 60;
            score = 0;

            lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
            lblScore.Text = $"Score: {score}";

            guessedFoods.Clear();
            lstGuessedFoods.Items.Clear();
            usedIndices.Clear();

            pictureBox.Visible = true;

            gameTimer.Start();
            gameDurationTimer.Start();

            btnSubmit.Visible = true;
            txtGuess.Enabled = true;
            btnStartGame.Visible = false;

            LoadRandomImage();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim().ToLower();
            List<string> normalizedFoodList = foodList.Select(food => food.Trim().ToLower()).ToList();

            if (normalizedFoodList.Contains(userGuess) && !guessedFoods.Contains(userGuess))
            {
                guessedFoods.Add(userGuess);
                lstGuessedFoods.Items.Add(userGuess);
                txtGuess.Clear();
                score += 10;
                lblScore.Text = $"Score: {score}";

                if (guessedFoods.Count == foodList.Count)
                {
                    LoadRandomImage();
                    guessedFoods.Clear();
                    lstGuessedFoods.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Incorrect guess or already guessed.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuess.Clear();
            }
        }

        private void TypingGameRecess_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }

        private void lstGuessedFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection changes if needed
        }

        private void FoodGuessGameForm_Load(object sender, EventArgs e)
        {

        }
        private void SettingspictureBox1_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                // Resume the game
                isPaused = false;
                gameTimer.Start();
                gameDurationTimer.Start();
                lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
                lblScore.Text = $"Score: {score}";
                exitlinkLabel1.Visible = false;
               
            }
            else
            {
                // Pause the game
                isPaused = true;
                gameTimer.Stop();
                gameDurationTimer.Stop();
                exitlinkLabel1.Visible = true;

            }
        }

        private void exitlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Map game = new Map();
            game.ShowDialog();
            this.Close();
        }
    }
}
