using System.Windows.Forms;

namespace PongAccelerated
{
    /// <summary>
    /// This class is the representation of a player in this game system. Each player must have a paddel to control and some way to track the score.
    /// </summary>
    public class Player
    {
        Direction direction;
        private Paddel paddel;
        private int score;
        private Label scoreLabel;

        public Player(Paddel paddel, int score, Label scoreLabel)
        {
            this.paddel = paddel;
            this.score = score;
            this.direction = Direction.STOP;
            this.scoreLabel = scoreLabel;
        }

        public Paddel Paddel
        {
            get => paddel;
            set => paddel = value;
        }

        public Label ScoreLabel
        {
            get => scoreLabel;
            set => scoreLabel = value;
        }

        public Direction Direction
        {
            get => direction;
            set => direction = value;
        }

        public int Score
        {
            get => score;
            set => score = value;
        }
    }
}