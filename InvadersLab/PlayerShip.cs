﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using InvadersLab.Properties;

namespace InvadersLab
{
    public class PlayerShip
    {
        private const int moveInterval = 10;
        private int cellNum = 1;
        public Point Location { get; set; }
        public bool Alive { get; set; }

        public Rectangle Area 
        { 
            get 
            {
                return new Rectangle(Location, new Size(20, 20));
            } 
        }

        public PlayerShip()
        {
            Location = new Point(300, 200);
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





        public void Draw(Graphics g)
        {
            g.DrawImage(getImage(), Area);
            
            //g.DrawEllipse(new Pen(Color.Red), Area);
            cellNum = (cellNum + 1) % 4;
        }

        private Bitmap getImage()
        {
            switch (cellNum)
            {
                case 0:
                    return Resources.spaceship1;
                case 1:
                    return Resources.spaceship2;
                case 2:
                    return Resources.spaceship3;
                case 3:
                    return Resources.spaceship4;
                default:
                    throw new NotImplementedException("The number: " + cellNum + " is not in the implemented range.");
            }
            
        }
    }
}
