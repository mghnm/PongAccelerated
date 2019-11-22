namespace PongAccelerated
{
    /// <summary>
    /// The ball class represents the ball from its image
    /// </summary>
    public class Ball
    {
        private System.Windows.Forms.PictureBox ballIm;

        public Ball(System.Windows.Forms.PictureBox pictureBox)
        {
            this.ballIm = pictureBox;

        }


        public int Length
        {
            get => this.ballIm.Height;
            set => this.ballIm.Height = value;
        }

        public int Width
        {
            get => this.ballIm.Width;
            set => this.ballIm.Width = value;
        }

        public int XPos
        {
            get => this.ballIm.Location.X;
            set => this.ballIm.Location = new System.Drawing.Point(value, this.ballIm.Location.Y);
        }

        public int YPos
        {
            get => this.ballIm.Location.Y;
            set => this.ballIm.Location = new System.Drawing.Point(this.ballIm.Location.X, value);
        }

        public System.Windows.Forms.PictureBox BallImage
        {
            get => this.ballIm;
        }

    }
}