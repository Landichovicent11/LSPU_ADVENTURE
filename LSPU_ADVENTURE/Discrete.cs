using System;
using System.CodeDom.Compiler;
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
    public partial class Discrete : Form
    {
        //list of plaintext to generate
        private string[] plaintext = { "APPLES", "BANANA", "GRAPES", "MANGO" };
        private string CipherText = "";

        //open the Plaintext list Picturebox
        private bool SHOW = true;
        private static bool Open;

        //get the user Input
        string Input = "";

        //generate random integer
        Random pos = new Random();

        //score
        private static int Point = 0;

        //timer
        private int remainingTime = 100;

        public Discrete()
        {
            InitializeComponent();
            TimerDiscrete.Interval = 1000;
            TimerDiscrete.Tick -= TimerDiscrete_Tick;
            TimerDiscrete.Tick += TimerDiscrete_Tick;
        }

        private void SubmitButt_Click(object sender, EventArgs e)
        {
            Input = AnswerBox.Text;
            if (Checker())
            {
                MessageBox.Show("Input is correct!!");
                Point += 10;
                Scorelbl.Text = "Score:" + Point; //add score

                if (remainingTime >= 0 )
                {
                    GeneratePlaintext();
                }
            }
            else
            {
                MessageBox.Show("Input is wrong...");
            }


            AnswerBox.Text = "";

            //generateb plain text
            GeneratePlaintext();
        }

        //show List
        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            if (Open)
            {
                SHOW = false;
                PlaintextToCryticText.Visible = true;
            }
            else if (!Open)
            {
                SHOW = true;
                PlaintextToCryticText.Visible = false;
            }
            Open = SHOW;
        }

        private void SartButton_Click(object sender, EventArgs e)
        {
            //show Labels
            Slot1.Visible = true;
            Slot2.Visible = true;
            Slot3.Visible = true;
            Slot4.Visible = true;
            Slot5.Visible = true;
            Slot6.Visible = true;

            //Show buttons
            AnswerBox.Visible = true;
            SubmitButt.Visible = true;
            EncryptionButton.Visible = true;

            //hide start button
            StartButton.Visible = false;

            //generate the plaintext
            GeneratePlaintext();

            //setTimer
            TimerDiscrete.Start();
        }
        private void GeneratePlaintext()
        {
            int index = pos.Next(0, 4);
            //GENERATE THE RANDOM PLAINTEXT
            switch (plaintext[index])
            {
                case "APPLES":
                    Slot1.Text = "A";
                    Slot2.Text = "P";
                    Slot3.Text = "P";
                    Slot4.Text = "L";
                    Slot5.Text = "E";
                    Slot6.Text = "S";
                    CipherText = "01515114";
                    break;
                case "BANANA":
                    Slot1.Text = "B";
                    Slot2.Text = "A";
                    Slot3.Text = "N";
                    Slot4.Text = "A";
                    Slot5.Text = "N";
                    Slot6.Text = "A";
                    CipherText = "10130130";
                    break;
                case "GRAPES":
                    Slot1.Text = "G";
                    Slot2.Text = "R";
                    Slot3.Text = "A";
                    Slot4.Text = "P";
                    Slot5.Text = "E";
                    Slot6.Text = "S";
                    CipherText = "617015418";
                    break;
                case "MANGO":
                    Slot1.Text = "M";
                    Slot2.Text = "A";
                    Slot3.Text = "N";
                    Slot4.Text = "G";
                    Slot5.Text = "O";
                    CipherText = "12013614";
                    break;
            }
        }
        //check the User Input
        private bool Checker()
        {
            if (Input == CipherText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TimerDiscrete_Tick(object sender, EventArgs e)
        {
            --remainingTime;

            Timerlbl.Text = "Timer: " + remainingTime;
            if (remainingTime == 0) 
            {
                TimerDiscrete.Stop();
            }

        }
    }
}
