using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InvadersLab
{
    public class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;
        private ShipType type;
        private int score;
        //add image

        public Invader(ShipType type, Point location, int score)
        {
            // TODO: Complete member initialization
            this.type = type;
            this.Location = location;
            this.score = score;
            // set image
        }
        public Point Location { get; private set; }
        

        public void Move(Direction d)
        {
            var location = Location;
            if (d.Equals(Direction.Down))
            {
                location.Offset(0, VerticalInterval); // not working.
            }
            else
            {
                location.Offset(HorizontalInterval, 0);
            }
            Location = location; // validate
        }
    }
}
