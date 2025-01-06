namespace LSPU_ADVENTURE
{
    partial class Artapp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SUBMIT = new Button();
            SCORE = new Label();
            STARTBTN = new Button();
            HIGHSCORE = new Label();
            SequenceAnswer = new Label();
            Correct1 = new Label();
            Correct2 = new Label();
            Correct4 = new Label();
            Correct3 = new Label();
            Correct5 = new Label();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            A4 = new Button();
            A5 = new Button();
            textBox1 = new TextBox();
            ATTEMPlbl = new Label();
            SuspendLayout();
            // 
            // SUBMIT
            // 
            SUBMIT.BackColor = Color.Cornsilk;
            SUBMIT.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SUBMIT.ForeColor = Color.DarkGoldenrod;
            SUBMIT.Location = new Point(650, 550);
            SUBMIT.Name = "SUBMIT";
            SUBMIT.Size = new Size(100, 100);
            SUBMIT.TabIndex = 26;
            SUBMIT.Text = "SUBMIT";
            SUBMIT.UseVisualStyleBackColor = false;
            SUBMIT.Visible = false;
            SUBMIT.Click += SUBMIT_Click;
            // 
            // SCORE
            // 
            SCORE.BackColor = Color.Transparent;
            SCORE.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCORE.ForeColor = Color.DarkBlue;
            SCORE.ImageAlign = ContentAlignment.MiddleLeft;
            SCORE.Location = new Point(12, 625);
            SCORE.Name = "SCORE";
            SCORE.Size = new Size(216, 56);
            SCORE.TabIndex = 27;
            SCORE.Text = "SCORE:";
            SCORE.TextAlign = ContentAlignment.MiddleCenter;
            SCORE.Visible = false;
            // 
            // STARTBTN
            // 
            STARTBTN.BackColor = Color.SteelBlue;
            STARTBTN.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            STARTBTN.ForeColor = Color.White;
            STARTBTN.Location = new Point(529, 398);
            STARTBTN.Name = "STARTBTN";
            STARTBTN.Size = new Size(339, 136);
            STARTBTN.TabIndex = 50;
            STARTBTN.Text = "START";
            STARTBTN.UseVisualStyleBackColor = false;
            STARTBTN.Click += STARTBTN_Click;
            // 
            // HIGHSCORE
            // 
            HIGHSCORE.BackColor = Color.Transparent;
            HIGHSCORE.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HIGHSCORE.ForeColor = Color.DarkBlue;
            HIGHSCORE.ImageAlign = ContentAlignment.MiddleLeft;
            HIGHSCORE.Location = new Point(1075, 625);
            HIGHSCORE.Name = "HIGHSCORE";
            HIGHSCORE.Size = new Size(216, 56);
            HIGHSCORE.TabIndex = 29;
            HIGHSCORE.Text = "HIGHSCORE:";
            HIGHSCORE.TextAlign = ContentAlignment.MiddleCenter;
            HIGHSCORE.Visible = false;
            // 
            // SequenceAnswer
            // 
            SequenceAnswer.AutoSize = true;
            SequenceAnswer.BackColor = SystemColors.Info;
            SequenceAnswer.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SequenceAnswer.Location = new Point(250, 460);
            SequenceAnswer.Name = "SequenceAnswer";
            SequenceAnswer.Size = new Size(106, 21);
            SequenceAnswer.TabIndex = 30;
            SequenceAnswer.Text = "Sequence:";
            SequenceAnswer.Visible = false;
            // 
            // Correct1
            // 
            Correct1.BackColor = SystemColors.ActiveBorder;
            Correct1.Location = new Point(275, 201);
            Correct1.Name = "Correct1";
            Correct1.Size = new Size(50, 50);
            Correct1.TabIndex = 31;
            Correct1.Tag = "CorrectLabels";
            Correct1.Text = "\"\"";
            Correct1.TextAlign = ContentAlignment.MiddleCenter;
            Correct1.Visible = false;
            // 
            // Correct2
            // 
            Correct2.BackColor = SystemColors.ActiveBorder;
            Correct2.Location = new Point(475, 201);
            Correct2.Name = "Correct2";
            Correct2.Size = new Size(50, 50);
            Correct2.TabIndex = 32;
            Correct2.Tag = "CorrectLabels";
            Correct2.Text = "\"\"";
            Correct2.TextAlign = ContentAlignment.MiddleCenter;
            Correct2.Visible = false;
            // 
            // Correct4
            // 
            Correct4.BackColor = SystemColors.ActiveBorder;
            Correct4.Location = new Point(875, 201);
            Correct4.Name = "Correct4";
            Correct4.Size = new Size(50, 50);
            Correct4.TabIndex = 34;
            Correct4.Tag = "CorrectLabels";
            Correct4.Text = "\"\"";
            Correct4.TextAlign = ContentAlignment.MiddleCenter;
            Correct4.Visible = false;
            // 
            // Correct3
            // 
            Correct3.BackColor = SystemColors.ActiveBorder;
            Correct3.Location = new Point(675, 201);
            Correct3.Name = "Correct3";
            Correct3.Size = new Size(50, 50);
            Correct3.TabIndex = 33;
            Correct3.Tag = "CorrectLabels";
            Correct3.Text = "\"\"";
            Correct3.TextAlign = ContentAlignment.MiddleCenter;
            Correct3.Visible = false;
            // 
            // Correct5
            // 
            Correct5.BackColor = SystemColors.ActiveBorder;
            Correct5.Location = new Point(1075, 201);
            Correct5.Name = "Correct5";
            Correct5.Size = new Size(50, 50);
            Correct5.TabIndex = 35;
            Correct5.Tag = "CorrectLabels";
            Correct5.Text = "\"\"";
            Correct5.TextAlign = ContentAlignment.MiddleCenter;
            Correct5.Visible = false;
            // 
            // A1
            // 
            A1.BackColor = SystemColors.AppWorkspace;
            A1.Location = new Point(250, 273);
            A1.Name = "A1";
            A1.Size = new Size(100, 100);
            A1.TabIndex = 51;
            A1.UseVisualStyleBackColor = false;
            A1.Visible = false;
            A1.Click += A1_Click;
            // 
            // A2
            // 
            A2.BackColor = SystemColors.AppWorkspace;
            A2.Location = new Point(450, 273);
            A2.Name = "A2";
            A2.Size = new Size(100, 100);
            A2.TabIndex = 52;
            A2.UseVisualStyleBackColor = false;
            A2.Visible = false;
            A2.Click += A2_Click;
            // 
            // A3
            // 
            A3.BackColor = SystemColors.AppWorkspace;
            A3.Location = new Point(650, 273);
            A3.Name = "A3";
            A3.Size = new Size(100, 100);
            A3.TabIndex = 53;
            A3.UseVisualStyleBackColor = false;
            A3.Visible = false;
            A3.Click += A3_Click;
            // 
            // A4
            // 
            A4.BackColor = SystemColors.AppWorkspace;
            A4.Location = new Point(851, 273);
            A4.Name = "A4";
            A4.Size = new Size(100, 100);
            A4.TabIndex = 54;
            A4.UseVisualStyleBackColor = false;
            A4.Visible = false;
            A4.Click += A4_Click;
            // 
            // A5
            // 
            A5.BackColor = SystemColors.AppWorkspace;
            A5.Location = new Point(1050, 282);
            A5.Name = "A5";
            A5.Size = new Size(100, 100);
            A5.TabIndex = 55;
            A5.UseVisualStyleBackColor = false;
            A5.Visible = false;
            A5.Click += A5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1157, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 56;
            // 
            // ATTEMPlbl
            // 
            ATTEMPlbl.BackColor = Color.Transparent;
            ATTEMPlbl.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ATTEMPlbl.ForeColor = Color.DarkBlue;
            ATTEMPlbl.ImageAlign = ContentAlignment.MiddleLeft;
            ATTEMPlbl.Location = new Point(589, 12);
            ATTEMPlbl.Name = "ATTEMPlbl";
            ATTEMPlbl.Size = new Size(216, 56);
            ATTEMPlbl.TabIndex = 57;
            ATTEMPlbl.Text = "ATTEMP:";
            ATTEMPlbl.TextAlign = ContentAlignment.MiddleCenter;
            ATTEMPlbl.Visible = false;
            // 
            // Artapp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArtFinalBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 700);
            Controls.Add(ATTEMPlbl);
            Controls.Add(textBox1);
            Controls.Add(A5);
            Controls.Add(A4);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(Correct5);
            Controls.Add(Correct4);
            Controls.Add(Correct3);
            Controls.Add(Correct2);
            Controls.Add(Correct1);
            Controls.Add(SequenceAnswer);
            Controls.Add(HIGHSCORE);
            Controls.Add(STARTBTN);
            Controls.Add(SCORE);
            Controls.Add(SUBMIT);
            DoubleBuffered = true;
            ForeColor = Color.SaddleBrown;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Artapp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Artapp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SUBMIT;
        private Label SCORE;
        private Button STARTBTN;
        private Label HIGHSCORE;
        private Label SequenceAnswer;
        private Label Correct1;
        private Label Correct2;
        private Label Correct4;
        private Label Correct3;
        private Label Correct5;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button A4;
        private Button A5;
        private TextBox textBox1;
        private Label ATTEMPlbl;
    }
}