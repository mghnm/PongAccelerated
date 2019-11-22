using System;

namespace PongAccelerated
{
    /// <summary>
    /// The ball manager can manage the state of the ball for us through the GameManager. In effect the GameManager requires a ballManager.
    /// The ball manager simply contains a ball object and a set of instructions for how to handle the balls movement on the board.
    /// All ball related operations should be defined in the ballManager. 
    ///
    /// </summary>
    public class BallManager
    {
        private Ball ball;
        private PlayerManager playerManager;
        Random random = new Random();
        private int speedX;
        private int speedY;
        private int rally = 0;
        private int initialSpeed = 5;
        private int maxSpeed = 20;

        public int Rally
        {
            get => rally;
        }

        //Ball manager needs to know the state of the initial ball on creation then will update the state internally
        public BallManager(Ball ball, PlayerManager pMan)
        {
            this.ball = ball;
            this.playerManager = pMan;
            do
            {
                this.speedX = random.Next(-initialSpeed, initialSpeed);
                this.speedY = random.Next(-initialSpeed, initialSpeed);
            } while (Math.Abs(speedX) + Math.Abs(speedY) <= initialSpeed || Math.Abs(speedX) <= initialSpeed / 3);

        }

        //This will use the logic to move
        public void Move()
        {
            ApplyStep();

            //Handle edge case when ball hits the top or bottom of the map
            if (this.ball.YPos >= (PlayArea.Y_MAX - this.ball.Length) || this.ball.YPos <= PlayArea.Y_MIN)
            {
                //Flip the direction in the Y axis
                this.speedY *= -1;

            }

            //Handle the case where the ball touches the right boundary aka left player scored
            if (this.ball.XPos >= PlayArea.X_MAX - this.ball.Width)
            {
                this.playerManager.IncreaseScorePlayer(0);
                ResetBall();
                ResetPaddleSizes();
                return;

            }
            else if (this.ball.XPos <= PlayArea.X_MIN)
            {
                this.playerManager.IncreaseScorePlayer(1);
                ResetBall();
                ResetPaddleSizes();
                return;
            }


            //Handle the case where the paddels interact with the ball
            if (this.playerManager.Players[0].Paddel.PaddelImage.Bounds.IntersectsWith(this.ball.BallImage.Bounds) || this.playerManager.Players[1].Paddel.PaddelImage.Bounds.IntersectsWith(this.ball.BallImage.Bounds))
            {

                this.speedX *= -1;
                this.rally++;
                //We have rallied for a multiple of 10 and a shrink is due
                if (((rally % 10) == 0) && rally > 0)
                {
                    this.playerManager.ShrinkPaddelPlayer(0);
                    this.playerManager.ShrinkPaddelPlayer(1);
                }
                //Increase the speed with each touch up to a limit
                if (this.speedX < 0 && this.speedX > -maxSpeed)
                {
                    this.speedX--;
                }
                else if (this.speedX > 0 && this.speedX < maxSpeed)
                {
                    this.speedX++;
                }
            }
        }

        public void ApplyStep()
        {
            this.ball.XPos = this.ball.XPos + speedX;
            this.ball.YPos = Math.Max(PlayArea.Y_MIN, Math.Min(PlayArea.Y_MAX - this.ball.Length, this.ball.YPos + speedY));

        }


        private void ResetBall()
        {
            this.ball.BallImage.Location = new System.Drawing.Point(PlayArea.X_MID - (this.ball.Width / 2),
                            PlayArea.Y_MID - (this.ball.Width / 2));
            this.rally = 0;
            do
            {
                this.speedX = random.Next(-initialSpeed, initialSpeed);
                this.speedY = random.Next(-initialSpeed, initialSpeed);
            } while (Math.Abs(speedX) + Math.Abs(speedY) <= initialSpeed || Math.Abs(speedX) <= initialSpeed / 3);
        }

        private void ResetPaddleSizes()
        {
            this.playerManager.resetPaddleSizePlayer(0);
            this.playerManager.resetPaddleSizePlayer(1);
        }

    }
}