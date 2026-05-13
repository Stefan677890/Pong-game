namespace Snake
{
    public partial class Board : Form
    {
        int PlayerScore = 0;

        int playerX = 400;
        int playerY = 400;

        int PlayerSpeedX = 4;

        int AppleX;
        int AppleY;


        public Board()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The game is starting");
            Timer.Start();
        }

        private void Difficulty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose the difficulty");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program is being close...");
            Close();
        }

        private void Tick(object sender, EventArgs e)
        {

        }
    }
}
