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
        }

            private void SetupListView()
            {
                listViewLeaderboard.View = View.Details;
                listViewLeaderboard.Columns.Add("Rank", 50, HorizontalAlignment.Center);
                listViewLeaderboard.Columns.Add("Score", 100, HorizontalAlignment.Center);
                listViewLeaderboard.FullRowSelect = true;
            }

            public void UpdateLeaderboard(List<int> scores)
            {
            // Clear existing items
            string filePath = "leaderboard.txt";

            // Sort scores in descending order
            var sortedScores = scores.OrderByDescending(s => s).ToList();

            // Add scores to the ListView
            for (int i = 0; i < scores.Count; i++)
            {
                var item = new ListViewItem((i + 1).ToString()); // Rank
                item.SubItems.Add(scores[i].ToString());        // Score
                listViewLeaderboard.Items.Add(item);
            }
        }
        private void LoadScores()
        {
            // File path for the leaderboard text file
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

        private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close(); // Close the leaderboard form
            }

            private void Leaderboard_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
