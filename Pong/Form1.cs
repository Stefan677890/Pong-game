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
            timer1.Interval = 20;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveUp && playerY > 0) playerY -= 6;
            if (moveDown && playerY < this.ClientSize.Height - 80)
                    playerY += 6;

            if (aiY + 40 < ballY) aiY += 2;
            if (aiY + 40 > ballY) aiY -= 2;

            if (aiY < 0) aiY = 0;
            if (aiY > this.ClientSize.Height - 80)
                aiY = this.ClientSize.Height - 80;

            ballX += ballSpeedX;
            ballY += ballSpeedY;

            if (ballY <= 0 || ballY >= this.ClientSize.Height - 10)
                ballSpeedY *= -1;

            Rectangle playerRect = new Rectangle(10, playerY, 10, 80);
            Rectangle ballRect = new Rectangle(ballX, ballY, 10, 10); ;

            if(playerRect.IntersectsWith(ballRect))
                ballSpeedX = Math.Abs(ballSpeedX);

            Rectangle aiRect = new Rectangle(this.ClientSize.Width -20, aiY, 10, 80);

            if (aiRect.IntersectsWith(ballRect))
                ballSpeedX = -Math.Abs(ballSpeedX);

            if (ballX < 0)
            {
                aiScore++;
                Resetball(); 
            }

            if (ballX > this.ClientSize.Width)
            {
                playerScore++;
                Resetball();
            }

            Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.White, 10 ,playerY, 10, 80);
            g.FillRectangle(Brushes.White, this.ClientSize.Width - 20, aiY, 10, 80);

            g.FillEllipse(Brushes.White, ballX, ballY, 10, 10);

            g.DrawString($"Gracz: {playerScore}", new Font("Arial", 12), Brushes.White, 50, 10);
            g.DrawString($"Ai: {aiScore}", new Font("Arial", 12), Brushes.White, 400, 10);

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
        private void Resetball()
        {
            ballX = this.ClientSize.Width / 2;
            ballY = this.ClientSize.Height / 2;

            ballSpeedX *= -1;
        }
    }
}
