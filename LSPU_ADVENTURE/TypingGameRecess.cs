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
        private System.Windows.Forms.Timer gameDurationTimer;
        private Random random = new Random();
        private bool isPaused = false;
        private List<int> leaderboardScores;

        public TypingGameRecess()
        {
            InitializeComponent();
            InitializeGame();
            leaderboardScores = new List<int>();
        }

        private void InitializeGame()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

            isPaused = false;

            gameDurationTimer = new System.Windows.Forms.Timer();
            gameDurationTimer.Interval = 1000;
            gameDurationTimer.Tick += GameDurationTimer_Tick;



            lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
            lblScore.Text = $"Score: {score}";

            pictureBox.Visible = false;
            txtGuess.Enabled = false;
            btnSubmit.Visible = false;

        }

        private void LoadRandomImage()
        {
            guessedFoods.Clear();
            lstGuessedFoods.Items.Clear();

            // Map resources to their respective food lists
            var imageResourceMap = new Dictionary<Bitmap, List<string>>
    {
        { Properties.Resources.berries, new List<string> { "bacon", "bread", "egg", "cheese", "berries" } },
        { Properties.Resources.burger, new List<string> { "burger", "fries", "hotdog" } },
        { Properties.Resources.chicken, new List<string> { "egg", "bread", "chicken" } },
        { Properties.Resources.Kwek_Kwek_Recipe, new List<string> { "kwek kwek" } },
        { Properties.Resources.tacobell, new List<string> { "taco" } },
        { Properties.Resources.tomato, new List<string> { "bacon", "egg", "bread", "tomato" } }
    };

            // Select a random image that hasn't been used yet
            Bitmap selectedImage = null;
            List<string> selectedFoods = null;

            var unusedImages = imageResourceMap.Keys.Except(usedIndices.Select(i => imageResourceMap.Keys.ElementAt(i))).ToList();
            if (unusedImages.Count > 0)
            {
                int randomIndex = random.Next(unusedImages.Count);
                selectedImage = unusedImages[randomIndex];
                selectedFoods = imageResourceMap[selectedImage];
                usedIndices.Add(imageResourceMap.Keys.ToList().IndexOf(selectedImage));
            }

            if (selectedImage != null && selectedFoods != null)
            {
                pictureBox.Image = selectedImage;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                foodList = selectedFoods;
            }
            else
            {
                MessageBox.Show("All images have been used!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGameControls();
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

            leaderboardScores.Add(score);
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
            string userGuess = txtGuess.Text.Trim().ToLower(); // Normalize input
            List<string> normalizedFoodList = foodList.Select(food => food.Trim().ToLower()).ToList(); // Normalize answers

            // Debugging output for verification
            Console.WriteLine($"User Guess: {userGuess}");
            Console.WriteLine($"Food List: {string.Join(", ", normalizedFoodList)}");

            if (string.IsNullOrWhiteSpace(userGuess))
            {
                MessageBox.Show("Please enter a guess.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuess.Clear();
                return;
            }

            if (normalizedFoodList.Contains(userGuess))
            {
                if (!guessedFoods.Contains(userGuess))
                {
                    guessedFoods.Add(userGuess);
                    lstGuessedFoods.Items.Add(userGuess);
                    txtGuess.Clear();
                    score += 10;
                    lblScore.Text = $"Score: {score}";

                    // Check if all foods have been guessed
                    if (guessedFoods.Count == foodList.Count)
                    {
                        gameTimer.Stop();

                        MessageBox.Show("All foods guessed! Loading the next image.", "Round Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRandomImage(); // Load a new image

                        gameTimer.Start();
                        

                    }
                }
                else
                {
                    MessageBox.Show("You already guessed this food!", "Duplicate Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGuess.Clear();
                }
            }
            else
            {
                MessageBox.Show($"'{txtGuess.Text}' is incorrect. Try again!", "Incorrect Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            }
            else
            {
                // Pause the game
                isPaused = true;
                gameTimer.Stop();
                gameDurationTimer.Stop();


            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimeLeft.Text = $"Time left: {timeLeft} seconds";
            }
            else
            {
                EndRound("Time's up Game over...");
            }
        }

       




        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "leaderboard.txt";

            // Append the current score to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(score); // Save the current score
            }

            this.Hide();
            Map game = new Map();
            game.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                // Resume the game
                isPaused = false;
                gameTimer.Start();
                gameDurationTimer.Start();
                button2.Text = "Pause"; // Update button text to "Pause"
            }
            else
            {
                // Pause the game
                isPaused = true;
                gameTimer.Stop();
                gameDurationTimer.Stop();
                button2.Text = "Resume"; // Update button text to "Resume"
            }
        }

        private void btnShowLeaderboard_Click_1(object sender, EventArgs e)
        {
            // Show the leaderboard form
            var leaderboardForm = new Leaderboard();
            leaderboardForm.UpdateLeaderboard(leaderboardScores);
            leaderboardForm.ShowDialog();
        }
    }
}
