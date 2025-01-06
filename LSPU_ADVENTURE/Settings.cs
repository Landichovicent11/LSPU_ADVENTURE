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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void aboutbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs abt = new AboutUs();
            abt.ShowDialog();
            this.Close();
        }

        private void leaderboardbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard abt = new Leaderboard();
            abt.ShowDialog();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main abt = new Main();
            abt.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutorials tut = new Tutorials();
            tut.ShowDialog();
            this.Close();
        }
    }
}
