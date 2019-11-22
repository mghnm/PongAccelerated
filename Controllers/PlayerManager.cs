using System;
using System.Collections.Generic;

namespace PongAccelerated
{
    /// <summary>
    /// The Player Manager class is responsible for managing all aspects of the player in relation to the UI.
    /// The player manager can support several players but for now we will only use 2 players.
    /// </summary>
    public class PlayerManager
    {
        private List<Player> players;
        private const int MOVEMENTSPEED = 10;
        private const int SHRINKAMOUNT = 30;
        private const int PADDLESIZE = 200;

        public PlayerManager(Player p1, Player p2)
        {
            this.players = new List<Player>();
            AddPlayer(p1);
            AddPlayer(p2);
        }

        public List<Player> Players
        {
            get => players;
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }


        public void GiveDirectionPlayer(int index, Direction direction)
        {
            this.players[index].Direction = direction;

        }

        //Handle the movement of the player by index and direction
        //Direction up = -1
        //Direction down = 1
        //Direction stop = 0
        public void MovePlayer(int index)
        {
            //Use nested Math max and min to bound the movement to the playarea
            this.players[index].Paddel.YPos = Math.Max(PlayArea.Y_MIN, Math.Min((PlayArea.Y_MAX - this.players[index].Paddel.Length),
                (this.players[index].Paddel.YPos + ((int)this.players[index].Direction * MOVEMENTSPEED))));
        }

        //Add score to the specified player
        public void IncreaseScorePlayer(int index)
        {
            this.players[index].Score++;
            this.players[index].ScoreLabel.Text = "" + this.players[index].Score;
        }

        //Shrink paddel of player by preset amount
        public void ShrinkPaddelPlayer(int index)
        {
            if (this.players[index].Paddel.Length > 0)
            {
                this.players[index].Paddel.Length = this.players[index].Paddel.Length - SHRINKAMOUNT;
            }
        }

        public void resetPaddleSizePlayer(int index)
        {

            this.players[index].Paddel.Length = PADDLESIZE;
        }

    }

}