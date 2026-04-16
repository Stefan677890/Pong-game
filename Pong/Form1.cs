namespace Pong
{
    public partial class Pong : Form
    {
        int playerY = 150;
        int aiY = 150;

        int ballX = 200;
        int ballY = 150;

        int ballSpeedX = 4;
        int ballSpeedY = 4;

        int playerScore = 0;
        int aiScore = 0;

        bool moveUp, moveDown;
        public Pong()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Pong_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) moveUp = true;
            if (e.KeyCode == Keys.Down) moveDown = true;
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) moveUp = false;
            if (e.KeyCode == Keys.Down) moveDown = false;
        }
    }
}
