namespace flappy_bird_game_in_windows_form
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeDown.Left -= pipeSpeed;
            PipeUp.Left -= pipeSpeed;
            scoreBoard.Text = score.ToString();

            if (PipeDown.Left < -100) 
            {
                PipeDown.Left = 700;
                score++;
            }

            if (PipeUp.Left < -100)
            {
                PipeUp.Left = 800;
                score++;
            }

        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
    }
}
