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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }

        private void LecCSS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneratingGame game = new GeneratingGame();
            game.ShowDialog();
            this.Close();
        }

        private void PE_Click(object sender, EventArgs e)
        {

        }

        private void Recess_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypingGameRecess game = new TypingGameRecess();
            game.ShowDialog();
            this.Close();
        }

        private void LabCSS_Click(object sender, EventArgs e)
        {

        }
    }
}
