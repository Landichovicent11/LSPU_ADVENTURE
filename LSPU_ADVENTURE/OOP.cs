using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LSPU_ADVENTURE
{
    public partial class OOP : Form
    {
        private Stack<QuestionAnswer> answerHistory = new Stack<QuestionAnswer>();
        private List<int> skippedQuestions = new List<int>();
        private int score = 0;
        private List<int> answeredQuestions = new List<int>(); // This keeps track of answered questions.

        private List<(string Question, string[] Options, string CorrectAnswer)> questions = new List<(string, string[], string)>
        {
             ("What does OOP stand for?", new string[] { "Object-Oriented Programming", "Open Object Programming", "Operational Object Processing", "Optimal Output Processing" }, "Object-Oriented Programming"),
    ("Which of the following is not an OOP principle?", new string[] { "Inheritance", "Polymorphism", "Encapsulation", "Compilation" }, "Compilation"),
    ("Which of the following keywords is used to create an object in Java?", new string[] { "new", "create", "object", "init" }, "new"),
    ("Which of the following is an example of inheritance in OOP?", new string[] { "A class extending another class", "A class implementing an interface", "A class defining its constructor", "A class with multiple methods" }, "A class extending another class"),
    ("Which of the following describes encapsulation?", new string[] { "Hiding the internal state of an object", "Creating multiple instances of a class", "Creating a hierarchy of classes", "Accessing object properties directly" }, "Hiding the internal state of an object"),
    ("Which of the following is a feature of polymorphism?", new string[] { "Ability to create different classes", "Ability to change the state of an object", "Ability to call methods with the same name but different implementations", "Ability to create object constructors" }, "Ability to call methods with the same name but different implementations"),
    ("In OOP, what is the term for the concept of a class inheriting properties and behaviors from another class?", new string[] { "Encapsulation", "Inheritance", "Polymorphism", "Abstraction" }, "Inheritance"),
    ("What is an abstract class in OOP?", new string[] { "A class that cannot be instantiated", "A class that contains only methods", "A class that has no variables", "A class that implements interfaces" }, "A class that cannot be instantiated"),
    ("Which of the following is an example of method overloading?", new string[] { "Two methods with the same name but different parameters", "Two methods with the same name and parameters", "A method that returns a value", "A method that changes the object's state" }, "Two methods with the same name but different parameters"),
    ("Which OOP concept involves hiding the implementation details of an object and exposing only the necessary parts?", new string[] { "Encapsulation", "Abstraction", "Inheritance", "Polymorphism" }, "Abstraction"),
    ("Which of the following is true about a constructor in OOP?", new string[] { "It is used to initialize an object's state", "It is used to call other methods", "It can have a return type", "It is used to delete objects" }, "It is used to initialize an object's state"),
    ("What is the main purpose of a destructor in OOP?", new string[] { "To initialize an object", "To perform cleanup before an object is destroyed", "To call the class methods", "To create new instances of the class" }, "To perform cleanup before an object is destroyed"),
    ("What is the difference between '== ' and 'equals()' in Java?", new string[] { "'==' checks for reference equality, 'equals()' checks for content equality", "'==' checks for content equality, 'equals()' checks for reference equality", "'==' is for primitive types, 'equals()' is for objects", "There is no difference" }, "'==' checks for reference equality, 'equals()' checks for content equality"),
    ("In Java, what does the 'super' keyword refer to?", new string[] { "The current class", "The parent class", "A static method", "An object instance" }, "The parent class"),
    ("Which of the following is a characteristic of an interface in OOP?", new string[] { "It can have method implementations", "It cannot have any implementation", "It can have constructors", "It is used for inheritance" }, "It cannot have any implementation"),
    ("Which of the following statements is correct about OOP?", new string[] { "OOP is based on functions", "OOP is based on objects and classes", "OOP focuses on data and not behavior", "OOP does not allow code reuse" }, "OOP is based on objects and classes"),
    ("What is the term used to describe a situation where a subclass has a method with the same name and parameters as the superclass?", new string[] { "Overloading", "Overriding", "Abstraction", "Polymorphism" }, "Overriding"),
    ("Which of the following keywords is used to prevent a method from being overridden?", new string[] { "static", "final", "protected", "abstract" }, "final"),
    ("In OOP, what does the term 'class' represent?", new string[] { "A blueprint for creating objects", "A single object instance", "A specific method", "A collection of data" }, "A blueprint for creating objects"),
    ("Which OOP concept allows one object to take many forms?", new string[] { "Inheritance", "Polymorphism", "Encapsulation", "Abstraction" }, "Polymorphism")
        };

        private int currentQuestionIndex = 0;
        private bool isLoadingQuestion = false;

        public OOP()
        {
            InitializeComponent();

            lblQuestion.Text = "Welcome to the Quiz!";

            progressBar1.Maximum = questions.Count;
            progressBar1.Value = 0;

            btnValidate.Enabled = false;  // Initially, the validate button is disabled

            LoadQuestion();
        }

        private void LoadQuestion()
        {
            isLoadingQuestion = true;

            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.Question;
                radioButton1.Text = question.Options[0];
                radioButton2.Text = question.Options[1];
                radioButton3.Text = question.Options[2];
                radioButton4.Text = question.Options[3];

                ResetRadioButtons(); // Reset radio buttons to ensure no previous selections

                // Check if there is an answer history and restore the answer for the current question
                var answer = answerHistory.FirstOrDefault(a => a.Question == question.Question);
                if (answer != null)
                {
                    // Set the radio button based on the saved answer
                    if (answer.Answer == radioButton1.Text) radioButton1.Checked = true;
                    else if (answer.Answer == radioButton2.Text) radioButton2.Checked = true;
                    else if (answer.Answer == radioButton3.Text) radioButton3.Checked = true;
                    else if (answer.Answer == radioButton4.Text) radioButton4.Checked = true;
                }

                progressBar1.Value = currentQuestionIndex + 1; // Update progress bar value

                // Disable the Next button when the last question is reached
                btnSkip.Enabled = currentQuestionIndex < questions.Count - 1;

                // Enable the Validate button if all questions are answered or at the last question
                btnValidate.Enabled = answeredQuestions.Count == questions.Count || currentQuestionIndex == questions.Count - 1;
            }
            else
            {
                lblQuestion.Text = "Quiz Over!";
                btnSkip.Enabled = false; // Disable the Next button at the end of the quiz
            }

            isLoadingQuestion = false;
        }

        private void ResetRadioButtons()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Validate answers and calculate score when 'Done' button is clicked
            score = 0;
            foreach (var question in questions)
            {
                var selectedAnswer = GetSelectedAnswer(question);
                if (selectedAnswer == question.CorrectAnswer)
                {
                    score++;
                }
            }

            MessageBox.Show($"Your final score is {score}/{questions.Count}");
        }

        private string GetSelectedAnswer((string Question, string[] Options, string CorrectAnswer) question)
        {
            if (radioButton1.Checked && radioButton1.Text == question.Options[0]) return radioButton1.Text;
            if (radioButton2.Checked && radioButton2.Text == question.Options[1]) return radioButton2.Text;
            if (radioButton3.Checked && radioButton3.Text == question.Options[2]) return radioButton3.Text;
            if (radioButton4.Checked && radioButton4.Text == question.Options[3]) return radioButton4.Text;
            return "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                // Save selected answer
                string selectedAnswer = GetSelectedAnswer(questions[currentQuestionIndex]);
                answerHistory.Push(new QuestionAnswer
                {
                    Question = questions[currentQuestionIndex].Question,
                    Answer = selectedAnswer
                });

                // Track the question as answered
                if (!answeredQuestions.Contains(currentQuestionIndex))
                {
                    answeredQuestions.Add(currentQuestionIndex);
                }

                // Enable Validate button when all questions are answered or at the last question
                btnValidate.Enabled = answeredQuestions.Count == questions.Count || currentQuestionIndex == questions.Count - 1;

                currentQuestionIndex++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Please select an answer before proceeding.");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetQuiz();
        }

        private void ResetQuiz()
        {
            score = 0;
            currentQuestionIndex = 0;
            skippedQuestions.Clear();
            answeredQuestions.Clear();
            answerHistory.Clear();
            lblScore.Text = "";
            btnValidate.Enabled = false;  // Disable validate button on restart
            LoadQuestion();
        }

        // Logic for the Previous Button
        // Logic for the Previous Button with Pop
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                // Decrease the current question index to go to the previous question
                currentQuestionIndex--;

                // Attempt to pop the last answer from the stack if it exists
                if (answerHistory.Any())
                {
                    // Pop the last answer from the stack and reset the radio buttons
                    var lastAnswer = answerHistory.Pop();
                    ResetRadioButtons();

                    // Restore the last answer
                    if (lastAnswer.Answer == radioButton1.Text) radioButton1.Checked = true;
                    else if (lastAnswer.Answer == radioButton2.Text) radioButton2.Checked = true;
                    else if (lastAnswer.Answer == radioButton3.Text) radioButton3.Checked = true;
                    else if (lastAnswer.Answer == radioButton4.Text) radioButton4.Checked = true;
                }

                LoadQuestion();
                btnSkip.Enabled = true; // Enable the Next button when going back
            }
            else
            {
                MessageBox.Show("No previous question to go back to.");
            }
        }

        //this is next btn
        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                // Save selected answer
                string selectedAnswer = GetSelectedAnswer(questions[currentQuestionIndex]);
                answerHistory.Push(new QuestionAnswer
                {
                    Question = questions[currentQuestionIndex].Question,
                    Answer = selectedAnswer
                });

                // Check if the selected answer is correct and increment score
                if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
                {
                    score++;
                }

                // Track the question as answered
                if (!answeredQuestions.Contains(currentQuestionIndex))
                {
                    answeredQuestions.Add(currentQuestionIndex);
                }

                // Enable Validate button when all questions are answered or at the last question
                btnValidate.Enabled = answeredQuestions.Count == questions.Count || currentQuestionIndex == questions.Count - 1;

                currentQuestionIndex++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Please select an answer before proceeding.");
            }
        }

        // Logic for the Validate Button
        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblScore.Text = $"Your final score is {score}/{questions.Count}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesLecture main = new GamesLecture();
            main.ShowDialog();
            this.Close();
        }
    }

    public class QuestionAnswer
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}