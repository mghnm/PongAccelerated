using System;
using System.Windows.Forms;

namespace PongAccelerated
{
    public partial class GameManager : Form
    {

        private PlayArea playArea;
        private PlayerManager playerManager;
        private BallManager ballManager;

        //The offsets were measured manually but these can be reused for other form projects
        private const int XOFFSET = 16;
        private const int YOFFSET = 39;
        //Since the resolution I went with was 1280 x 720 this is the formula
        private const int PLAYAREA_WIDTH = 1280 - XOFFSET;
        private const int PLAYAREA_HEIGHT = 720 - YOFFSET;

        //ScoreTracker
        private const int SCOREMAX = 5;

        //Gamestate
        private bool running = false;

        public GameManager()
        {
            InitializeComponent();
            //Initialize the singleton with the standard parameters
            this.playArea = PlayArea.GetInstance(0, PLAYAREA_WIDTH, 0, PLAYAREA_HEIGHT);
            this.playerManager = new PlayerManager(new Player(new Paddel(this.paddlePicP1), 0, this.lblP1)
                , new Player(new Paddel(this.paddlePicP2), 0, lblP2));
            this.ballManager = new BallManager(new Ball(this.ballPic), this.playerManager);
            InitializeMenuUI();
        }

        //The timer will be updating the UI to reflect the current gamestate
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.playerManager.MovePlayer(0);
            this.playerManager.MovePlayer(1);
            this.ballManager.Move();
            UpdateRally();
            checkWinner();
        }

        private void UpdateRally()
        {
            this.relaylabel.Text = "Rally Counter: " + this.ballManager.Rally;
        }

        private void GameManager_KeyDown(object sender, KeyEventArgs e)
        {
            ChecKey(e, true);
        }

        private void GameManager_KeyUp(object sender, KeyEventArgs e)
        {
            ChecKey(e, false);
        }


        private void ChecKey(KeyEventArgs e, bool press)
        {
            if (press)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        this.playerManager.GiveDirectionPlayer(0, Direction.UP);
                        break;
                    case Keys.S:
                        this.playerManager.GiveDirectionPlayer(0, Direction.DOWN);
                        break;
                    case Keys.Up:
                        this.playerManager.GiveDirectionPlayer(1, Direction.UP);
                        break;
                    case Keys.Down:
                        this.playerManager.GiveDirectionPlayer(1, Direction.DOWN);
                        break;
                    case Keys.Space:
                        if (!running)
                        {
                            ResumeeGame();
                        }
                        else { }
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        this.playerManager.GiveDirectionPlayer(0, Direction.STOP);
                        break;
                    case Keys.S:
                        this.playerManager.GiveDirectionPlayer(0, Direction.STOP);
                        break;
                    case Keys.Up:
                        this.playerManager.GiveDirectionPlayer(1, Direction.STOP);
                        break;
                    case Keys.Down:
                        this.playerManager.GiveDirectionPlayer(1, Direction.STOP);
                        break;
                }



            }

        }

        //Triggered by a player reaching the max score
        public void EndGame()
        {
            InitializeGameOverUI();
            PauseGame();
            ResetGameLabels();

        }

        

        public void ResetGameLabels()
        {
            this.lblP1.Text = "0";
            this.lblP2.Text = "0";
            this.relaylabel.Text = "Rally Counter: 0";

        }

        //Stops the timer event from ticking
        public void PauseGame()
        {
            this.Timer.Stop();
            this.running = false;
        }

        //Resumes the game or starts it if it has not started
        public void ResumeeGame()
        {
            InitializeGameUI();
            this.Timer.Start();
            this.running = true;
        }

        //We are in the game state
        public void InitializeGameUI()
        {
            HideGameStartElements();
            HideGameOverElements();
            ShowGameElements();


        }

        //We are in the main menu state
        public void InitializeMenuUI()
        {
            HideGameElements();
            HideGameOverElements();
            ShowGameStartElements();

        }

        //We are in the game over state
        public void InitializeGameOverUI()
        {
            HideGameElements();
            HideGameStartElements();
            ShowGameOverElements();
        }

        public void checkWinner()
        {
            //Player 1 has won
            if (this.playerManager.Players[0].Score >= SCOREMAX)
            {
                //Set winner to player 1
                this.winnerLabel.Text = "Player 1 Wins";
                //Reset player score
                this.playerManager.Players[0].Score = 0;
                //End game
                EndGame();

            }
            //Player 2 has won
            else if (this.playerManager.Players[1].Score >= SCOREMAX)
            {
                //Set winnter player 2
                this.winnerLabel.Text = "Player 2 Wins";
                //Reset player score
                this.playerManager.Players[1].Score = 0;
                //End game
                EndGame();

            }
            //No player has won
            else
            {
            }

        }

        //This method will hide the UI elements related to the game itself so we can display for example a menu instead
        public void HideGameElements()
        {
            this.paddlePicP1.Hide();
            this.paddlePicP2.Hide();
            this.relaylabel.Hide();
            this.ballPic.Hide();
            this.lblP1.Hide();
            this.lblP2.Hide();

        }

        //Hides the game over menu elements for example if the game is to start again
        public void HideGameOverElements()
        {
            this.gameOverLabel.Hide();
            this.winnerLabel.Hide();
            this.startLabel.Hide();

        }

        //Hides the game start title screen that will only be shown once on launch
        public void HideGameStartElements()
        {
            this.startLabel.Hide();
            this.titleLabel.Hide();
        }

        //This method will show the UI elements related to the game itself so we can play the game
        public void ShowGameElements()
        {
            this.paddlePicP1.Show();
            this.paddlePicP2.Show();
            this.relaylabel.Show();
            this.ballPic.Show();
            this.lblP1.Show();
            this.lblP2.Show();

        }

        //Shows the game over menu elements for example if the game has ended
        public void ShowGameOverElements()
        {
            this.gameOverLabel.Show();
            this.winnerLabel.Show();
            this.startLabel.Show();

        }

        //Show the game start title screen that will only be shown once on launch
        public void ShowGameStartElements()
        {
            this.startLabel.Show();
            this.titleLabel.Show();
        }

    }
}

