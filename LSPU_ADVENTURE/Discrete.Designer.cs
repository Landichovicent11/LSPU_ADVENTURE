namespace LSPU_ADVENTURE
{
    partial class Discrete
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
            components = new System.ComponentModel.Container();
            SubmitButt = new Button();
            AnswerBox = new TextBox();
            Slot1 = new Label();
            Slot2 = new Label();
            Slot3 = new Label();
            Slot5 = new Label();
            Slot6 = new Label();
            Slot4 = new Label();
            label1 = new Label();
            PlaintextToCryticText = new PictureBox();
            EncryptionButton = new Button();
            StartButton = new Button();
            Scorelbl = new Label();
            TimerDiscrete = new System.Windows.Forms.Timer(components);
            Timerlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)PlaintextToCryticText).BeginInit();
            SuspendLayout();
            // 
            // SubmitButt
            // 
            SubmitButt.BackColor = Color.MidnightBlue;
            SubmitButt.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SubmitButt.ForeColor = SystemColors.ButtonHighlight;
            SubmitButt.Location = new Point(550, 550);
            SubmitButt.Name = "SubmitButt";
            SubmitButt.Size = new Size(94, 29);
            SubmitButt.TabIndex = 3;
            SubmitButt.Text = "Submit";
            SubmitButt.UseVisualStyleBackColor = false;
            SubmitButt.Visible = false;
            SubmitButt.Click += SubmitButt_Click;
            // 
            // AnswerBox
            // 
            AnswerBox.BackColor = Color.MediumAquamarine;
            AnswerBox.Cursor = Cursors.Hand;
            AnswerBox.ForeColor = Color.MidnightBlue;
            AnswerBox.Location = new Point(500, 500);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(200, 27);
            AnswerBox.TabIndex = 7;
            AnswerBox.Visible = false;
            // 
            // Slot1
            // 
            Slot1.BackColor = Color.Ivory;
            Slot1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Slot1.ForeColor = Color.MidnightBlue;
            Slot1.Location = new Point(50, 150);
            Slot1.Name = "Slot1";
            Slot1.Size = new Size(100, 100);
            Slot1.TabIndex = 8;
            Slot1.Text = "\" \"";
            Slot1.TextAlign = ContentAlignment.MiddleCenter;
            Slot1.Visible = false;
            // 
            // Slot2
            // 
            Slot2.BackColor = Color.Ivory;
            Slot2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Slot2.ForeColor = Color.MidnightBlue;
            Slot2.Location = new Point(250, 150);
            Slot2.Name = "Slot2";
            Slot2.Size = new Size(100, 100);
            Slot2.TabIndex = 9;
            Slot2.Text = "\" \"";
            Slot2.TextAlign = ContentAlignment.MiddleCenter;
            Slot2.Visible = false;
            // 
            // Slot3
            // 
            Slot3.BackColor = Color.Ivory;
            Slot3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Slot3.ForeColor = Color.MidnightBlue;
            Slot3.Location = new Point(450, 150);
            Slot3.Name = "Slot3";
            Slot3.Size = new Size(100, 100);
            Slot3.TabIndex = 10;
            Slot3.Text = "\" \"";
            Slot3.TextAlign = ContentAlignment.MiddleCenter;
            Slot3.Visible = false;
            // 
            // Slot5
            // 
            Slot5.BackColor = Color.Ivory;
            Slot5.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Slot5.ForeColor = Color.MidnightBlue;
            Slot5.Location = new Point(850, 150);
            Slot5.Name = "Slot5";
            Slot5.Size = new Size(100, 100);
            Slot5.TabIndex = 11;
            Slot5.Text = "\" \"";
            Slot5.TextAlign = ContentAlignment.MiddleCenter;
            Slot5.Visible = false;
            // 
            // Slot6
            // 
            Slot6.BackColor = Color.Ivory;
            Slot6.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Slot6.ForeColor = Color.MidnightBlue;
            Slot6.Location = new Point(1050, 150);
            Slot6.Name = "Slot6";
            Slot6.Size = new Size(100, 100);
            Slot6.TabIndex = 12;
            Slot6.Text = "\" \"";
            Slot6.TextAlign = ContentAlignment.MiddleCenter;
            Slot6.Visible = false;
            // 
            // Slot4
            // 
            Slot4.BackColor = Color.Ivory;
            Slot4.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Slot4.ForeColor = Color.MidnightBlue;
            Slot4.Location = new Point(650, 150);
            Slot4.Name = "Slot4";
            Slot4.Size = new Size(100, 100);
            Slot4.TabIndex = 13;
            Slot4.Text = "\" \"";
            Slot4.TextAlign = ContentAlignment.MiddleCenter;
            Slot4.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(780, 583);
            label1.Name = "label1";
            label1.Size = new Size(408, 37);
            label1.TabIndex = 14;
            label1.Text = "Discrete CryptoGraph";
            // 
            // PlaintextToCryticText
            // 
            PlaintextToCryticText.BackColor = SystemColors.Info;
            PlaintextToCryticText.BackgroundImage = Properties.Resources.PlaintextList;
            PlaintextToCryticText.Image = Properties.Resources.PlaintextList;
            PlaintextToCryticText.Location = new Point(20, 300);
            PlaintextToCryticText.Name = "PlaintextToCryticText";
            PlaintextToCryticText.Size = new Size(350, 320);
            PlaintextToCryticText.TabIndex = 15;
            PlaintextToCryticText.TabStop = false;
            PlaintextToCryticText.Visible = false;
            // 
            // EncryptionButton
            // 
            EncryptionButton.BackColor = Color.MidnightBlue;
            EncryptionButton.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EncryptionButton.ForeColor = SystemColors.ButtonHighlight;
            EncryptionButton.Location = new Point(20, 626);
            EncryptionButton.Name = "EncryptionButton";
            EncryptionButton.Size = new Size(350, 52);
            EncryptionButton.TabIndex = 16;
            EncryptionButton.Text = "Encryption";
            EncryptionButton.UseVisualStyleBackColor = false;
            EncryptionButton.Visible = false;
            EncryptionButton.Click += EncryptionButton_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.MidnightBlue;
            StartButton.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.ForeColor = SystemColors.ButtonHighlight;
            StartButton.Location = new Point(470, 382);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(263, 112);
            StartButton.TabIndex = 17;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += SartButton_Click;
            // 
            // Scorelbl
            // 
            Scorelbl.BackColor = Color.Transparent;
            Scorelbl.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Scorelbl.ForeColor = SystemColors.ButtonHighlight;
            Scorelbl.Location = new Point(12, 9);
            Scorelbl.Name = "Scorelbl";
            Scorelbl.Size = new Size(214, 47);
            Scorelbl.TabIndex = 18;
            Scorelbl.Text = "Score:";
            Scorelbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TimerDiscrete
            // 
            TimerDiscrete.Tick += TimerDiscrete_Tick;
            // 
            // Timerlbl
            // 
            Timerlbl.BackColor = Color.Transparent;
            Timerlbl.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Timerlbl.ForeColor = SystemColors.ButtonHighlight;
            Timerlbl.Location = new Point(1006, 9);
            Timerlbl.Name = "Timerlbl";
            Timerlbl.Size = new Size(182, 46);
            Timerlbl.TabIndex = 19;
            Timerlbl.Text = "Timer:";
            Timerlbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Discrete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            BackgroundImage = Properties.Resources.Kwek_Kwek_Recipe;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 700);
            Controls.Add(Timerlbl);
            Controls.Add(Scorelbl);
            Controls.Add(StartButton);
            Controls.Add(EncryptionButton);
            Controls.Add(PlaintextToCryticText);
            Controls.Add(label1);
            Controls.Add(Slot4);
            Controls.Add(Slot6);
            Controls.Add(Slot5);
            Controls.Add(Slot3);
            Controls.Add(Slot2);
            Controls.Add(Slot1);
            Controls.Add(AnswerBox);
            Controls.Add(SubmitButt);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Discrete";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PlaintextToCryticText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SubmitButt;
        private TextBox AnswerBox;
        private Label Slot1;
        private Label Slot2;
        private Label Slot3;
        private Label Slot5;
        private Label Slot6;
        private Label Slot4;
        private Label label1;
        private PictureBox PlaintextToCryticText;
        private Button EncryptionButton;
        private Button StartButton;
        private Label Scorelbl;
        private System.Windows.Forms.Timer TimerDiscrete;
        private Label Timerlbl;
    }
}