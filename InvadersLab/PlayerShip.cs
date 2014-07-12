using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InvadersLab
{
    public class PlayerShip
    {
        private const int moveInterval = 10;
        public Point Location { get; set; }
        public bool Alive { get; set; }

        public PlayerShip()
        {
            Location = new Point(10, 10);
            Alive = true;
        }

        public void Move(Direction direction)
        {
            var location = Location;
            if (direction.Equals(Direction.Left))
            {
                location.Offset(-moveInterval, 0);
            }
            else 
            {
                location.Offset(moveInterval, 0);
            }
            Location = location;
        }



        
    }
}
