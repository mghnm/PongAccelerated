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
        private bool intersectingP1 = false;
        private bool intersectingP2 = false;

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

        //This will use the logic to move will also apply logic when relevant provided by other methods. 
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

            //update to see if any intersections are present
            UpdateIntersectionState();
            //Handle the case where the paddels interact with the ball 
            if (this.intersectingP1 || this.intersectingP2)
            {
                this.speedX *= -1;
                this.rally++;
                Shrinkage();
                IncreaseBallSpeedX(speedX);
                HandleBallSpeedY();
            }
        }

        //Adding a bit more sophistication to our ball physics we want to transfer momentum from the paddles to the ball in the Y axis depending on direction
        private void HandleBallSpeedY()
        {
            //If the paddle that striked the ball was moving in the same Y direction as the ball it should speed up if they were in the opposite dirction it should slow down
            if (this.intersectingP1)
            {
                //Check P1 paddle and increase / decrease the speed
                speedY = speedY + (1 * (int) this.playerManager.Players[0].Direction);
            }
            else if (this.intersectingP2)
            {
                //Check P2 paddle and increase / decrease the speed
                speedY = speedY + (1 * (int)this.playerManager.Players[1].Direction);
            }
            else 
            {
                //Ball is not intersecting with a paddle
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
            //Give the ball a random initial state
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

        //Check if we should shrink the paddles i.e the rally is a multiple of 10 if so shrink
        private void Shrinkage()
        {
            //We have rallied for a multiple of 10 and a shrink is due
            if (((rally % 10) == 0) && rally > 0)
            {
                this.playerManager.ShrinkPaddelPlayer(0);
                this.playerManager.ShrinkPaddelPlayer(1);
            }
        }

        //Increases the ball speed regardless of the direciton
        private void IncreaseBallSpeedX(int speed)
        {
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

        //Gives us more than just the ball intersected with something. Now we can tell which paddle it was the the ball striked and allows us to determine the impact.
        private void UpdateIntersectionState() 
        {
            if (this.playerManager.Players[0].Paddel.PaddelImage.Bounds.IntersectsWith(this.ball.BallImage.Bounds))
            {
                this.intersectingP1 = true;
            }
            else
            {
                this.intersectingP1 = false;
            }

            if (this.playerManager.Players[1].Paddel.PaddelImage.Bounds.IntersectsWith(this.ball.BallImage.Bounds))
            {
                this.intersectingP2 = true;
            }
            else 
            {
                this.intersectingP2 = false;
            }
        
        }

    }
}