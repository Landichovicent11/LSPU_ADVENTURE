using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPU_ADVENTURE
{
    public partial class GamesLecture : Form
    {
        public GamesLecture()
        {
            InitializeComponent();
        }

        private void RandomGame(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndGame = rnd.Next(0, 4);

            HashSet<int> UniqueRnd = new HashSet<int>();//Ensure rnd Number Uniqueness
            UniqueRnd.Add(rndGame);

            List<string> Games = new List<string> { "ArtApp", "Discrete", "IM" };//list of Subject(Games)
            foreach (int i in UniqueRnd)//Pick the rnd Game
            {
                if (Games[i] == "ArtApp")
                {
                    this.Hide();
                    Artapp artapp = new Artapp();
                    this.Close();
                }
                if (Games[i] == "Discrete")
                {
                    this.Hide();
                    Discrete discrete = new Discrete();
                    discrete.ShowDialog();
                    this.Close();
                }
                if (Games[i] == "IM")
                {
                    this.Hide();
                    SituationalQuestion game = new SituationalQuestion();
                    game.ShowDialog();
                    this.Close();
                }
            }
        }

        private void InfoManagement(object sender, EventArgs e)
        {
            this.Hide();
            SituationalQuestion game = new SituationalQuestion();
            game.ShowDialog();
            this.Close();
        }

        private void discrete(object sender, EventArgs e)
        {
            this.Hide();
            Discrete discrete = new Discrete();
            discrete.ShowDialog();
            this.Close();
        }

        private void artapp(object sender, EventArgs e)
        {
            this.Hide();
            Artapp artapp = new Artapp();
            artapp.ShowDialog();
            this.Close();
        }
    }
}
