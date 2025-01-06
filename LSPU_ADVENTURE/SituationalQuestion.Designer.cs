namespace LSPU_ADVENTURE
{
    partial class SituationalQuestion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            questionLabel = new Label();
            choiceButton1 = new Button();
            choiceButton2 = new Button();
            choiceButton3 = new Button();
            backButton = new Button();
            PB_1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_1).BeginInit();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.BackColor = Color.PaleGoldenrod;
            questionLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            questionLabel.Location = new Point(478, 141);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(435, 57);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Welcome to the Game!";
            questionLabel.TextAlign = ContentAlignment.TopCenter;
            questionLabel.Click += questionLabel_Click;
            // 
            // choiceButton1
            // 
            choiceButton1.BackColor = Color.Transparent;
            choiceButton1.Font = new Font("Arial", 12F, FontStyle.Bold);
            choiceButton1.Image = Properties.Resources.ImAnimatedBG;
            choiceButton1.ImageAlign = ContentAlignment.BottomCenter;
            choiceButton1.Location = new Point(535, 392);
            choiceButton1.Name = "choiceButton1";
            choiceButton1.Size = new Size(300, 50);
            choiceButton1.TabIndex = 1;
            choiceButton1.Text = "Choice 1";
            choiceButton1.UseVisualStyleBackColor = false;
            choiceButton1.Click += choiceButton1_Click;
            // 
            // choiceButton2
            // 
            choiceButton2.BackColor = Color.Transparent;
            choiceButton2.Font = new Font("Arial", 12F, FontStyle.Bold);
            choiceButton2.Image = Properties.Resources.ImAnimatedBG;
            choiceButton2.ImageAlign = ContentAlignment.BottomCenter;
            choiceButton2.Location = new Point(535, 474);
            choiceButton2.Name = "choiceButton2";
            choiceButton2.Size = new Size(300, 50);
            choiceButton2.TabIndex = 2;
            choiceButton2.Text = "Choice 2";
            choiceButton2.UseVisualStyleBackColor = false;
            choiceButton2.Click += choiceButton2_Click;
            // 
            // choiceButton3
            // 
            choiceButton3.BackColor = Color.Transparent;
            choiceButton3.Font = new Font("Arial", 12F, FontStyle.Bold);
            choiceButton3.Image = Properties.Resources.ImAnimatedBG;
            choiceButton3.ImageAlign = ContentAlignment.BottomCenter;
            choiceButton3.Location = new Point(535, 555);
            choiceButton3.Name = "choiceButton3";
            choiceButton3.Size = new Size(300, 50);
            choiceButton3.TabIndex = 3;
            choiceButton3.Text = "Choice 3";
            choiceButton3.UseVisualStyleBackColor = false;
            choiceButton3.Click += choiceButton3_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            backButton.Image = Properties.Resources.ImAnimatedBG;
            backButton.ImageAlign = ContentAlignment.BottomCenter;
            backButton.Location = new Point(40, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(101, 42);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // PB_1
            // 
            PB_1.BackColor = Color.Transparent;
            PB_1.Image = Properties.Resources.ImAnimatedBG;
            PB_1.Location = new Point(375, 12);
            PB_1.Name = "PB_1";
            PB_1.Size = new Size(628, 347);
            PB_1.SizeMode = PictureBoxSizeMode.Zoom;
            PB_1.TabIndex = 6;
            PB_1.TabStop = false;
            PB_1.Click += PB_1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources.ImAnimatedBG;
            label1.Location = new Point(12, 658);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 7;
            label1.Text = "SCORE:";
            // 
            // SituationalQuestion
            // 
            BackColor = Color.Turquoise;
            BackgroundImage = Properties.Resources.CSSUPDATED;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 700);
            Controls.Add(label1);
            Controls.Add(questionLabel);
            Controls.Add(backButton);
            Controls.Add(PB_1);
            Controls.Add(choiceButton3);
            Controls.Add(choiceButton2);
            Controls.Add(choiceButton1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SituationalQuestion";
            Text = "Situational Quiz Game";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)PB_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button choiceButton1;
        private System.Windows.Forms.Button choiceButton2;
        private System.Windows.Forms.Button choiceButton3;
        private System.Windows.Forms.Button backButton;
        private PictureBox PB_1;
        private Label label1;
    }
}
