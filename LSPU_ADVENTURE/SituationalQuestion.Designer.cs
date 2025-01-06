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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SituationalQuestion));
            questionLabel = new Label();
            choiceButton1 = new Button();
            choiceButton2 = new Button();
            choiceButton3 = new Button();
            backButton = new Button();
            PB_1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PB_1).BeginInit();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.BackColor = Color.Transparent;
            questionLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            questionLabel.Location = new Point(434, 138);
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
            choiceButton1.Location = new Point(478, 389);
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
            choiceButton2.Location = new Point(478, 471);
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
            choiceButton3.Location = new Point(478, 552);
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
            PB_1.Image = (Image)resources.GetObject("PB_1.Image");
            PB_1.Location = new Point(329, -3);
            PB_1.Name = "PB_1";
            PB_1.Size = new Size(628, 347);
            PB_1.SizeMode = PictureBoxSizeMode.Zoom;
            PB_1.TabIndex = 6;
            PB_1.TabStop = false;
            PB_1.Click += this.PB_1_Click;
            // 
            // SituationalQuestion
            // 
            BackColor = Color.Turquoise;
            ClientSize = new Size(1300, 700);
            Controls.Add(questionLabel);
            Controls.Add(backButton);
            Controls.Add(PB_1);
            Controls.Add(choiceButton3);
            Controls.Add(choiceButton2);
            Controls.Add(choiceButton1);
            Name = "SituationalQuestion";
            Text = "Situational Quiz Game";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)PB_1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button choiceButton1;
        private System.Windows.Forms.Button choiceButton2;
        private System.Windows.Forms.Button choiceButton3;
        private System.Windows.Forms.Button backButton;
        private PictureBox PB_1;
    }
}
