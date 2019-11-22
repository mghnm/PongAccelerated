using System.Drawing;

namespace PongAccelerated
{
    /// <summary>
    ///The paddel class represents the game paddel
    /// </summary>
    public class Paddel
    {

        private System.Windows.Forms.PictureBox paddelIm;

        public Paddel(System.Windows.Forms.PictureBox pictureBox)
        {
            this.paddelIm = pictureBox;

        }


        public int Length
        {
            get => this.paddelIm.Height;
            set => this.paddelIm.Height = value;
        }

        public int Width
        {
            get => this.paddelIm.Width;
            set => this.paddelIm.Width = value;
        }

        public int XPos
        {
            get => this.paddelIm.Location.X;
            set => this.paddelIm.Location = new Point(value, this.paddelIm.Location.Y);
        }

        public int YPos
        {
            get => this.paddelIm.Location.Y;
            set => this.paddelIm.Location = new Point(this.paddelIm.Location.X, value);
        }


        public System.Windows.Forms.PictureBox PaddelImage
        {
            get => this.paddelIm;
        }
    }
}