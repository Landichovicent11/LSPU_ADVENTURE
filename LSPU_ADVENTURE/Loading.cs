namespace LSPU_ADVENTURE
{
    public partial class LoadingScreen : Form
    {
        private int progress = 0;
        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            // Initialize progressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Start the Timer
            timer1.Start();

        }
        private void timer1_Tick(Object sender, EventArgs e) 
        {
            if (progress < 100)
            {
                progress += 1;
                progressBar1.Value += 1;
                LoadingPercentage.Text = progressBar1.Value + "%";
            }
            else
            {
                // Stop Timer
                timer1.Stop();

                // Hide LoadingScreen and Show MainForm
                this.Hide();
                Main mainForm = new Main();
                mainForm.ShowDialog();
                this.Close();
            }
        }
    }
}
