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
    public partial class Artapp : Form
    {
        Random Colorrnd = new Random();
        private int Sequence;
        private string[] Box_Color = { "RED", "BLUE", "GREEN", "YELLOW", "WHITE" };
        private List<Color> Colors;
        private string answer;
        private int Attempts = 0;  // Track attempts
        private int CycleA1 = 0;
        private int CycleA2 = 0;
        private int CycleA3 = 0;
        private int CycleA4 = 0;
        private int CycleA5 = 0;
        private int Guest_Correct;

        private List<Color> generatedColors; // To store the generated color sequence
        private TreeNode root;

        public Artapp()
        {
            InitializeComponent();
            Colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.White }; // List of colors
            generatedColors = new List<Color>();
            root = BuildCheckerTree();

        }

        private void generateColorSquence()
        {
            SequenceAnswer.Text = "Sequence: ";
            generatedColors.Clear();
            for (int i = 0; i < Box_Color.Length; i++)
            {
                Sequence = Colorrnd.Next(Box_Color.Length);
                answer = Box_Color[Sequence];
                generatedColors.Add(Colors[Sequence]); // Store the generated color
                SequenceAnswer.Text += answer + ", "; // Display sequence as text (not visible to the player)
            }
        }

        private void ColorCycle(ref int cycle, Button button)
        { 
            button.BackColor = Colors[cycle];
            cycle = (cycle + 1) % Colors.Count; // Increment cycle and loop back to 0
        }

        private TreeNode BuildCheckerTree()
        {
            List<Button> buttons = new List<Button> { A1, A2, A3, A4, A5 };
            List<Label> labels = new List<Label> { Correct1, Correct2, Correct3, Correct4, Correct5 };

            TreeNode root = new TreeNode("Checker", () => true, () => Guest_Correct = 0);

            for (int i = 0; i < buttons.Count; i++)
            {
                int index = i; // Capture the index for the lambda expressions
                root.Children.Add(new TreeNode(
                    $"A{index + 1} Check",
                    () => buttons[index].BackColor == generatedColors[index], // Check if the color is correct
                    () => {
                        labels[index].BackColor = buttons[index].BackColor; // Update the label color
                        Guest_Correct++; // Increment the correct guess counter
                    }
                ));
            }

            return root;
        }
        private void STARTBTN_Click(object sender, EventArgs e)
        {
            SCORE.Visible = true;
            HIGHSCORE.Visible = true;
            SUBMIT.Visible = true;
            ATTEMPlbl.Visible = true;
            //Show the controls

            A1.Visible = true;
            A2.Visible = true;
            A3.Visible = true;
            A4.Visible = true;
            A5.Visible = true;
            
            // Show labels
            Correct1.Visible = true;
            Correct2.Visible = true;
            Correct3.Visible = true;
            Correct4.Visible = true;
            Correct5.Visible = true;

            STARTBTN.Visible = false;

            generateColorSquence(); // Generate the sequence
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            if (Attempts <= 5 && Guest_Correct != 5)
            {
                // Execute the tree logic to check if the colors match
                root.Execute();
                Attempts++;
                // Update attempts label
                ATTEMPlbl.Text = "Attempts: " + Attempts;
            }
            else if (Guest_Correct == 5)
            {
                // Optionally display the correct sequence once the user guesses all correctly
                this.Hide();
                ArtAppOverScreen over = new ArtAppOverScreen();
                over.ShowDialog();
                this.Close();
            }
            else 
            {
                Attempts = 5;
                this.Hide();
                ArtAppOverScreen over = new ArtAppOverScreen();
                over.ShowDialog();
                this.Close();
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            ColorCycle(ref CycleA1, A1); // Cycle color for A1
        }

        private void A2_Click(object sender, EventArgs e)
        {
            ColorCycle(ref CycleA2, A2); 
        }

        private void A3_Click(object sender, EventArgs e)
        {
            ColorCycle(ref CycleA3, A3); 
        }

        private void A4_Click(object sender, EventArgs e)
        {
            ColorCycle(ref CycleA4, A4); 
        }

        private void A5_Click(object sender, EventArgs e)
        {
            ColorCycle(ref CycleA5, A5);
        }
    }
    public class TreeNode
    {
        public string Name { get; }
        public Func<bool> Condition { get; }
        public Action Action { get; }
        public List<TreeNode> Children { get; }

        public TreeNode(string name, Func<bool> condition, Action action)
        {
            Name = name;
            Condition = condition;
            Action = action;
            Children = new List<TreeNode>();
        }

        public void Execute()
        {
            if (Condition.Invoke())
            {
                Action.Invoke(); // Perform the action if the condition is true
            }

            foreach (var child in Children)
            {
                child.Execute(); // Recursively process child nodes
            }
        }
    }

}