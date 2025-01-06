using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace LSPU_ADVENTURE
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            SetupListView();
            LoadScores();
            LibrarylistView();
            LibraryLoadScores();
        }

        private void SetupListView()
        {
            listViewLeaderboard.View = View.Details;
            listViewLeaderboard.Columns.Add("Rank", 50, HorizontalAlignment.Center);
            listViewLeaderboard.Columns.Add("Score", 100, HorizontalAlignment.Center);
            listViewLeaderboard.FullRowSelect = true;
        }

        private void LibrarylistView()
        {
            librarylistView1.View = View.Details;
            librarylistView1.Columns.Add("Rank", 50, HorizontalAlignment.Center);
            librarylistView1.Columns.Add("Score", 100, HorizontalAlignment.Center);
            librarylistView1.FullRowSelect = true;
        }

        public void UpdateLeaderboard(List<int> scores)
        {
            // Clear existing items
            listViewLeaderboard.Items.Clear();

            // Sort scores in descending order
            var sortedScores = scores.OrderByDescending(s => s).ToList();

            // Add scores to the ListView
            for (int i = 0; i < sortedScores.Count; i++)
            {
                var item = new ListViewItem((i + 1).ToString()); // Rank
                item.SubItems.Add(sortedScores[i].ToString());  // Score
                listViewLeaderboard.Items.Add(item);
            }
        }

        public void UpdateLibraryLeaderboard(List<int> libscores)
        {
            // Clear existing items
            librarylistView1.Items.Clear();

            // Sort library scores in descending order
            var libsortedScores = libscores.OrderByDescending(s => s).ToList();

            // Add scores to the ListView
            for (int i = 0; i < libsortedScores.Count; i++)
            {
                var item = new ListViewItem((i + 1).ToString()); // Rank
                item.SubItems.Add(libsortedScores[i].ToString());  // Score
                librarylistView1.Items.Add(item);
            }
        }

        private void LoadScores()
        {
            // File path for the main leaderboard text file
            string filePath = "leaderboard.txt";

            if (File.Exists(filePath))
            {
                // Read all scores from the file
                var scores = File.ReadAllLines(filePath)
                                 .Select(line => int.TryParse(line, out int result) ? result : 0)
                                 .OrderByDescending(score => score)
                                 .ToList();

                // Update the ListView with the scores
                UpdateLeaderboard(scores);
            }
        }

        private void LibraryLoadScores()
        {
            // File path for the library leaderboard text file
            string filePath = "Libraryleaderboard.txt";

            if (File.Exists(filePath))
            {
                // Read all scores from the file
                var libscores = File.ReadAllLines(filePath)
                                     .Select(line => int.TryParse(line, out int result) ? result : 0)
                                     .OrderByDescending(libraryleaderboardScores => libraryleaderboardScores)
                                     .ToList();

                // Update the ListView with the scores
                UpdateLibraryLeaderboard(libscores);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the leaderboard form
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            // You can load scores if needed here as well
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void librarylistView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings game = new Settings();
            game.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
