using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LSPU_ADVENTURE
{
    public partial class GeneratingGame : Form
    {

        private string dots = "";
        private int dotCount = 0;
        private int progress = 0;
        public GeneratingGame()
        {
            InitializeComponent();

            timerGenerator.Interval = 600; // Adjust interval to your preference
            timerGenerator.Tick += timerGame;
        }

        public void GeneratingGame_Load(Object sender, EventArgs e)
        {
            timerGenerator.Start();
        }
        private void timerGame(object sender, EventArgs e)
        {
            if (progress < 50)
            {
                progress += 1;
                // Update the dots cyclically
                dotCount = (dotCount + 1) % 3; // Cycles between 0, 1, 2,
                dots = new string('.', dotCount); // Generate the appropriate number of dots
                DotGenerator.Text = "Generating." + dots;
            }
            else
            {
                // Stop Timer
                timerGenerator.Stop();

                this.Close();
                GamesLecture lecture = new GamesLecture();
                lecture.ShowDialog();
                this.Hide();
            }
        }
    }
}
