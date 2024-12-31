using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.

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
            this.Close();
            Main main = new Main();
            main.ShowDialog();
        }

        private void LecCSS_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            HashSet<int> UniqueRnd = new HashSet<int>();//Ensure rnd Uniqueness
            List<string> Games = new List<string> {"ArtApp","Discrete","IM"};
            bool GenerateGame = true;

            do
            {
                int RandomGame = rnd.Next(0, 3);
                UniqueRnd.Add(RandomGame);

                if (GenerateGame == true) 
                {
                    foreach (int GameGenerated in UniqueRnd)
                    {
                        String Playing = Games[GameGenerated];
                        switch (Playing) {
                            case "ArtApp":
                                //process artapp put mo game mo ina mo dito mo i loload yun form ng game para mag start
                                break;
                            case "Discrete":
                                //process Discrete
                                break;
                            case "IM":
                                //process IM
                                break;
                        }
                        
                    }
                    
                }
            } while (UniqueRnd.Count < 3);

            
        }

        private void PE_Click(object sender, EventArgs e)
        {

        }

        private void Recess_Click(object sender, EventArgs e)
        {

        }

        private void LabCSS_Click(object sender, EventArgs e)
        {

        }
    }
}
