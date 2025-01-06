using LSPU_ADVENTURE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LSPU_ADVENTURE
{
    public partial class Library : Form
    {
        private Dictionary<string, string> booksWithGenres;
        private Stack<string> actionStack;
        private Stack<string> comedyStack;
        private Stack<string> educationalStack;
        private Stack<string> mythologyStack;

        private List<string> actionAnswers;
        private List<string> comedyAnswers;
        private List<string> educationalAnswers;
        private List<string> mythologyAnswers;

        private Random random;

        public Library()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            random = new Random();

            // Initialize books and their genres
            booksWithGenres = new Dictionary<string, string>
            {
                { "The Great Adventure", "Action" },
                { "Laugh Out Loud", "Comedy" },
                { "Physics for Beginners", "Educational" },
                { "Greek Myths", "Mythology" },
                { "Spy Mission", "Action" },
                { "Comedy Nights", "Comedy" },
                { "Mathematics Simplified", "Educational" },
                { "Norse Legends", "Mythology" }
            };

            // Initialize Stacks for each genre
            actionStack = new Stack<string>();
            comedyStack = new Stack<string>();
            educationalStack = new Stack<string>();
            mythologyStack = new Stack<string>();

            // Correct order for each genre
            actionAnswers = new List<string> { "The Great Adventure", "Spy Mission" };
            comedyAnswers = new List<string> { "Laugh Out Loud", "Comedy Nights" };
            educationalAnswers = new List<string> { "Physics for Beginners", "Mathematics Simplified" };
            mythologyAnswers = new List<string> { "Greek Myths", "Norse Legends" };

            // Shuffle and display books in the main list
            var shuffledBooks = booksWithGenres.Keys.OrderBy(x => random.Next()).ToList();
            lstBooks.Items.AddRange(shuffledBooks.ToArray());

            // Enable drag-and-drop for all ListBox controls
            EnableDragAndDrop(lstBooks);
            EnableDragAndDrop(lstAction);
            EnableDragAndDrop(lstComedy);
            EnableDragAndDrop(lstEducational);
            EnableDragAndDrop(lstMythology);

            lblResult.Visible = Enabled;
        }

        private void EnableDragAndDrop(ListBox listBox)
        {
            listBox.AllowDrop = true;
            listBox.MouseDown += ListBox_MouseDown;
            listBox.DragEnter += ListBox_DragEnter;
            listBox.DragDrop += ListBox_DragDrop;
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Move);
            }
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            ListBox targetListBox = sender as ListBox;
            string droppedItem = e.Data.GetData(typeof(string)) as string;

            // Remove the item from the original ListBox
            foreach (var listBox in new ListBox[] { lstBooks, lstAction, lstComedy, lstEducational, lstMythology })
            {
                if (listBox.Items.Contains(droppedItem))
                {
                    listBox.Items.Remove(droppedItem);
                    break;
                }
            }

            // Add the item to the target ListBox
            targetListBox.Items.Add(droppedItem);

            // Clear and repopulate the corresponding stack to maintain correct order
            if (targetListBox == lstAction)
            {
                actionStack.Clear();
                foreach (var item in targetListBox.Items)
                    actionStack.Push(item.ToString());
            }
            else if (targetListBox == lstComedy)
            {
                comedyStack.Clear();
                foreach (var item in targetListBox.Items)
                    comedyStack.Push(item.ToString());
            }
            else if (targetListBox == lstEducational)
            {
                educationalStack.Clear();
                foreach (var item in targetListBox.Items)
                    educationalStack.Push(item.ToString());
            }
            else if (targetListBox == lstMythology)
            {
                mythologyStack.Clear();
                foreach (var item in targetListBox.Items)
                    mythologyStack.Push(item.ToString());
            }
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            int score = 0;

            Console.WriteLine("Checking Action Stack...");
            score += CheckCategory(actionStack, actionAnswers, "Action");

            Console.WriteLine("Checking Comedy Stack...");
            score += CheckCategory(comedyStack, comedyAnswers, "Comedy");

            Console.WriteLine("Checking Educational Stack...");
            score += CheckCategory(educationalStack, educationalAnswers, "Educational");

            Console.WriteLine("Checking Mythology Stack...");
            score += CheckCategory(mythologyStack, mythologyAnswers, "Mythology");


            lblResult.Text = $"Your score: {score}/{booksWithGenres.Count * 10}";
            Console.WriteLine($"Total Score: {score}");


        }



        private int CheckCategory(Stack<string> stack, List<string> answerList, string genre)
        {
            int points = 0;

            // Convert stack to list in the correct order
            var booksInOrder = stack.Reverse().ToList();

            // Compare each book in order with the answer list
            for (int i = 0; i < booksInOrder.Count && i < answerList.Count; i++)
            {
                if (booksInOrder[i] == answerList[i])
                {
                    points += 10; // Add 10 points for each correctly placed book
                }
            }

            return points;
        }


        // Helper method to check if the stack is sorted correctly
        private bool IsSortedCorrectly(Stack<string> stack, string genre)
        {
            var booksInOrder = stack.Reverse().ToList(); // Reverse to check from bottom to top
            var correctOrder = genre switch
            {
                "Action" => actionAnswers,
                "Comedy" => comedyAnswers,
                "Educational" => educationalAnswers,
                "Mythology" => mythologyAnswers,
                _ => new List<string>()
            };

            return booksInOrder.SequenceEqual(correctOrder);
        }

        private void lstAction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstComedy_SelectedIndexChanged(Object sender, EventArgs e)
        {

        }

        private void lstEducational_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEducational_Click(object sender, EventArgs e)
        {

        }



      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map game = new Map();
            game.ShowDialog();
            this.Close();
        }
    }
}

