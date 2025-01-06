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
            Color1 = new PictureBox();
            PlusSign = new PictureBox();
            Color2 = new PictureBox();
            EqualSign = new PictureBox();
            ResultColor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Color1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlusSign).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Color2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EqualSign).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResultColor).BeginInit();
            SuspendLayout();
            // 
            // Color1
            // 
            Color1.Location = new Point(200, 250);
            Color1.Name = "Color1";
            Color1.Size = new Size(100, 100);
            Color1.TabIndex = 0;
            Color1.TabStop = false;
            // 
            // PlusSign
            // 
            PlusSign.BackColor = Color.Transparent;
            PlusSign.BackgroundImage = Properties.Resources.PlusSign;
            PlusSign.BackgroundImageLayout = ImageLayout.Stretch;
            PlusSign.Location = new Point(350, 250);
            PlusSign.Name = "PlusSign";
            PlusSign.Size = new Size(100, 100);
            PlusSign.TabIndex = 1;
            PlusSign.TabStop = false;
            // 
            // Color2
            // 
            Color2.Location = new Point(500, 250);
            Color2.Name = "Color2";
            Color2.Size = new Size(100, 100);
            Color2.TabIndex = 2;
            Color2.TabStop = false;
            // 
            // EqualSign
            // 
            EqualSign.BackColor = Color.Transparent;
            EqualSign.BackgroundImage = Properties.Resources.Equal;
            EqualSign.BackgroundImageLayout = ImageLayout.Stretch;
            EqualSign.Location = new Point(650, 250);
            EqualSign.Name = "EqualSign";
            EqualSign.Size = new Size(100, 100);
            EqualSign.TabIndex = 3;
            EqualSign.TabStop = false;
            // 
            // ResultColor
            // 
            ResultColor.Location = new Point(800, 250);
            ResultColor.Name = "ResultColor";
            ResultColor.Size = new Size(100, 100);
            ResultColor.TabIndex = 4;
            ResultColor.TabStop = false;
            // 
            // Artapp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Artapp_TempDesign;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1300, 700);
            Controls.Add(ResultColor);
            Controls.Add(EqualSign);
            Controls.Add(Color2);
            Controls.Add(PlusSign);
            Controls.Add(Color1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Artapp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Artapp";
            ((System.ComponentModel.ISupportInitialize)Color1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlusSign).EndInit();
            ((System.ComponentModel.ISupportInitialize)Color2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EqualSign).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResultColor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Color1;
        private PictureBox PlusSign;
        private PictureBox Color2;
        private PictureBox EqualSign;
        private PictureBox ResultColor;
    }
}