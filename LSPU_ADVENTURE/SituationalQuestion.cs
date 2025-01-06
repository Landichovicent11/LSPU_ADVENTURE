using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LSPU_ADVENTURE
{
    public partial class SituationalQuestion : Form
    {
        private Queue<Question> questionQueue = new Queue<Question>();
        private int currentQuestionIndex = 10;
        private int lives = 3;
        private int score = 0;

        public SituationalQuestion()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1300, 700);
            this.BackColor = System.Drawing.Color.LightBlue;
            LoadQuestions();
            DisplayQuestion();
        }

        private void LoadQuestions()
        {
            questionQueue.Enqueue(new Question(
                "You are the IT manager of a company, and a department requests a new feature in the MIS. What is your first step?",
                new string[] {
            "Implement the feature immediately",
            "Evaluate the request's alignment with company goals",
            "Decline the request to avoid extra workload" },
                "Evaluate the request's alignment with company goals"));

            questionQueue.Enqueue(new Question(
                "A new employee is struggling to understand how to use the MIS. What should you do?",
                new string[] {
            "Provide comprehensive training on the system",
            "Tell them to read the user manual on their own",
            "Suggest they avoid using the system for now" },
                "Provide comprehensive training on the system"));

            questionQueue.Enqueue(new Question(
                "The MIS has been reporting inaccurate data recently. What should be your immediate action?",
                new string[] {
            "Ignore it and continue operations",
            "Identify and fix the source of the inaccuracies",
            "Disable the MIS temporarily" },
                "Identify and fix the source of the inaccuracies"));

            questionQueue.Enqueue(new Question(
                "Your company's MIS is outdated and no longer meets the organization's needs. What should you propose?",
                new string[] {
            "Continue using it to save costs",
            "Upgrade to a modern system tailored to the organization",
            "Revert to manual processes" },
                "Upgrade to a modern system tailored to the organization"));

            questionQueue.Enqueue(new Question(
                "You notice a drop in productivity due to employees struggling with a complex MIS interface. How do you address this?",
                new string[] {
            "Provide additional training and support",
            "Replace the MIS with a simpler one",
            "Ignore it since productivity issues will resolve over time" },
                "Provide additional training and support"));

            questionQueue.Enqueue(new Question(
                "Your MIS is critical for daily operations, but the server crashes unexpectedly. What is your priority?",
                new string[] {
            "Wait for the server to restart automatically",
            "Implement the backup and recovery plan",
            "Switch to manual operations indefinitely" },
                "Implement the backup and recovery plan"));

            questionQueue.Enqueue(new Question(
                "The MIS implementation in your organization has gone over budget. How should you handle this situation?",
                new string[] {
            "Analyze and optimize project expenditures",
            "Stop the project entirely",
            "Request more funds without reviewing expenses" },
                "Analyze and optimize project expenditures"));

            questionQueue.Enqueue(new Question(
                "An employee bypasses the MIS to use their own tools for data management. What should you do?",
                new string[] {
            "Encourage them to keep using their tools",
            "Discuss the benefits of the MIS and ensure compliance",
            "Discipline them without explanation" },
                "Discuss the benefits of the MIS and ensure compliance"));

            questionQueue.Enqueue(new Question(
                "Your MIS shows a significant mismatch between planned and actual outcomes. What is the best course of action?",
                new string[] {
            "Investigate the reasons for the mismatch",
            "Ignore it and continue operations",
            "Adjust the planned outcomes to match actual data" },
                "Investigate the reasons for the mismatch"));

            questionQueue.Enqueue(new Question(
                "You need to select a new MIS for the organization. What should you prioritize?",
                new string[] {
            "The system's cost alone",
            "Its ability to align with business goals and scalability",
            "The popularity of the vendor" },
                "Its ability to align with business goals and scalability"));
        }


        private void DisplayQuestion()
        {

            choiceButton1.Enabled = true;
            choiceButton2.Enabled = true;
            choiceButton3.Enabled = true;

            if (questionQueue.Count > 0)
            {
                var currentQuestion = questionQueue.Peek();
                questionLabel.Text = currentQuestion.QuestionText;

                choiceButton1.Text = currentQuestion.Answers[0];
                choiceButton2.Text = currentQuestion.Answers[1];
                choiceButton3.Text = currentQuestion.Answers[2];
            }
            else
            {
                MessageBox.Show("You have completed all the questions!");
            }
        }

        private void AnswerChoice(string choice)
        {
            var currentQuestion = questionQueue.Dequeue();

            if (currentQuestion.CorrectAnswer == choice)
            {
                score++;
                MessageBox.Show("Correct! Your score is: " + score);
            }
            else
            {
                lives--;
                MessageBox.Show("Wrong answer! You have " + lives + " lives left.");
            }

            if (lives <= 0)
            {
                var result = MessageBox.Show("Game Over! You ran out of lives. Do you want to continue to the next round or exit?",
                    "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    lives = 3;
                    score = 0;
                    LoadQuestions();
                    DisplayQuestion();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {

                DisplayQuestion();
            }
        }

        private void choiceButton1_Click(object sender, EventArgs e)
        {
            AnswerChoice(choiceButton1.Text);
        }

        private void choiceButton2_Click(object sender, EventArgs e)
        {
            AnswerChoice(choiceButton2.Text);
        }

        private void choiceButton3_Click(object sender, EventArgs e)
        {
            AnswerChoice(choiceButton3.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
        private void PB_1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string questionText, string[] answers, string correctAnswer)
        {

            QuestionText = questionText;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
    }
}
