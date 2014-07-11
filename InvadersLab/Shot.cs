using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InvadersLab
{
    public class Shot
    {
        private const int moveInterval = 10;
        public Point Location { get; set; }
        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            // TODO: Complete member initialization
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }

        public void Move()
        {
            var location = Location;
            int moveCount;
            if (direction == Direction.Down)
            {
                moveCount = moveInterval;
            }
            else // assume -- if (direction == Direction.Up)
            {
                moveCount = -moveInterval;
            }
            location.Offset(0, moveCount);
            Location = location;
        }
    }
}
