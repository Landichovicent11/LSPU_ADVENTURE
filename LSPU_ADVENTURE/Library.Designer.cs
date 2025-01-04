namespace LSPU_ADVENTURE
{
    partial class Library
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            lstBooks = new ListBox();
            lblAction = new Label();
            lstAction = new ListBox();
            lblComedy = new Label();
            lstComedy = new ListBox();
            lblEducational = new Label();
            lstEducational = new ListBox();
            lblMythology = new Label();
            lstMythology = new ListBox();
            btnCheckOrder = new Button();
            lblResult = new Label();
            returnlinkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstBooks
            // 
            lstBooks.BackColor = Color.LemonChiffon;
            lstBooks.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstBooks.ForeColor = Color.Black;
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 22;
            lstBooks.Location = new Point(29, 53);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(245, 488);
            lstBooks.TabIndex = 0;
            lstBooks.SelectedIndexChanged += lstBooks_SelectedIndexChanged;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.BackColor = Color.Teal;
            lblAction.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblAction.ForeColor = Color.White;
            lblAction.Location = new Point(369, 24);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(53, 17);
            lblAction.TabIndex = 1;
            lblAction.Text = "Action";
            // 
            // lstAction
            // 
            lstAction.BackColor = Color.Teal;
            lstAction.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstAction.ForeColor = Color.White;
            lstAction.FormattingEnabled = true;
            lstAction.ItemHeight = 22;
            lstAction.Location = new Point(369, 53);
            lstAction.Name = "lstAction";
            lstAction.Size = new Size(342, 202);
            lstAction.TabIndex = 2;
            lstAction.SelectedIndexChanged += lstAction_SelectedIndexChanged;
            // 
            // lblComedy
            // 
            lblComedy.AutoSize = true;
            lblComedy.BackColor = Color.Teal;
            lblComedy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblComedy.ForeColor = Color.White;
            lblComedy.Location = new Point(862, 24);
            lblComedy.Name = "lblComedy";
            lblComedy.Size = new Size(65, 17);
            lblComedy.TabIndex = 3;
            lblComedy.Text = "Comedy";
            // 
            // lstComedy
            // 
            lstComedy.BackColor = Color.Teal;
            lstComedy.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstComedy.ForeColor = Color.White;
            lstComedy.FormattingEnabled = true;
            lstComedy.ItemHeight = 22;
            lstComedy.Location = new Point(862, 53);
            lstComedy.Name = "lstComedy";
            lstComedy.Size = new Size(342, 202);
            lstComedy.TabIndex = 4;
            lstComedy.SelectedIndexChanged += lstComedy_SelectedIndexChanged;
            // 
            // lblEducational
            // 
            lblEducational.AutoSize = true;
            lblEducational.BackColor = Color.Teal;
            lblEducational.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblEducational.ForeColor = Color.White;
            lblEducational.Location = new Point(369, 279);
            lblEducational.Name = "lblEducational";
            lblEducational.Size = new Size(93, 17);
            lblEducational.TabIndex = 5;
            lblEducational.Text = "Educational";
            lblEducational.Click += this.lblEducational_Click;
            // 
            // lstEducational
            // 
            lstEducational.BackColor = Color.Teal;
            lstEducational.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstEducational.ForeColor = Color.White;
            lstEducational.FormattingEnabled = true;
            lstEducational.ItemHeight = 22;
            lstEducational.Location = new Point(369, 308);
            lstEducational.Name = "lstEducational";
            lstEducational.Size = new Size(342, 202);
            lstEducational.TabIndex = 6;
            lstEducational.SelectedIndexChanged += lstEducational_SelectedIndexChanged;
            // 
            // lblMythology
            // 
            lblMythology.AutoSize = true;
            lblMythology.BackColor = Color.Teal;
            lblMythology.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblMythology.ForeColor = Color.White;
            lblMythology.Location = new Point(862, 279);
            lblMythology.Name = "lblMythology";
            lblMythology.Size = new Size(81, 17);
            lblMythology.TabIndex = 7;
            lblMythology.Text = "Mythology";
            // 
            // lstMythology
            // 
            lstMythology.BackColor = Color.Teal;
            lstMythology.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstMythology.ForeColor = Color.White;
            lstMythology.FormattingEnabled = true;
            lstMythology.ItemHeight = 22;
            lstMythology.Location = new Point(862, 308);
            lstMythology.Name = "lstMythology";
            lstMythology.Size = new Size(342, 202);
            lstMythology.TabIndex = 8;
            // 
            // btnCheckOrder
            // 
            btnCheckOrder.BackColor = Color.Teal;
            btnCheckOrder.FlatAppearance.BorderColor = Color.DarkCyan;
            btnCheckOrder.FlatAppearance.BorderSize = 5;
            btnCheckOrder.FlatStyle = FlatStyle.Flat;
            btnCheckOrder.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOrder.ForeColor = Color.White;
            btnCheckOrder.Location = new Point(71, 611);
            btnCheckOrder.Name = "btnCheckOrder";
            btnCheckOrder.Size = new Size(150, 38);
            btnCheckOrder.TabIndex = 9;
            btnCheckOrder.Text = "Check Order";
            btnCheckOrder.UseVisualStyleBackColor = false;
            btnCheckOrder.Click += btnCheckOrder_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Teal;
            lblResult.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(82, 575);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 17);
            lblResult.TabIndex = 10;
            
            // 
            // returnlinkLabel1
            // 
            returnlinkLabel1.ActiveLinkColor = Color.Teal;
            returnlinkLabel1.AutoSize = true;
            returnlinkLabel1.BackColor = Color.Teal;
            returnlinkLabel1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnlinkLabel1.LinkColor = Color.White;
            returnlinkLabel1.Location = new Point(29, 9);
            returnlinkLabel1.Name = "returnlinkLabel1";
            returnlinkLabel1.Size = new Size(67, 22);
            returnlinkLabel1.TabIndex = 11;
            returnlinkLabel1.TabStop = true;
            returnlinkLabel1.Text = "Return";
            returnlinkLabel1.LinkClicked += returnlinkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1284, 661);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Library
            // 
            ClientSize = new Size(1284, 661);
            Controls.Add(returnlinkLabel1);
            Controls.Add(lblResult);
            Controls.Add(btnCheckOrder);
            Controls.Add(lstMythology);
            Controls.Add(lblMythology);
            Controls.Add(lstEducational);
            Controls.Add(lblEducational);
            Controls.Add(lstComedy);
            Controls.Add(lblComedy);
            Controls.Add(lstAction);
            Controls.Add(lblAction);
            Controls.Add(lstBooks);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Library";
            Text = "Book Sorting Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ListBox lstAction;
        private System.Windows.Forms.Label lblComedy;
        private System.Windows.Forms.ListBox lstComedy;
        private System.Windows.Forms.Label lblEducational;
        private System.Windows.Forms.ListBox lstEducational;
        private System.Windows.Forms.Label lblMythology;
        private System.Windows.Forms.ListBox lstMythology;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Label lblResult;
        private LinkLabel returnlinkLabel1;
        private PictureBox pictureBox1;
    }


    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    

        #endregion
}
