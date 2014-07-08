using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvadersLab
{
    public class Stars
    {
        private Random random;
        private Rectangle boundaries;
        private List<Star> allStars;
        //_____________________________________________________________________
        public Stars(Random random, Rectangle boundaries)
        {
            // TODO: Complete member initialization
            this.random = random;
            this.boundaries = boundaries;
            allStars = new List<Star>();
            for (int i = 0; i < 300; i++)
            {
                allStars.Add(generateRandomStar());
            }
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Size Size { get { return boundaries.Size; } }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void Draw(Graphics g)
        {
            var size = new Size(2,2);
            foreach (var star in allStars)
            {
                g.DrawRectangle(star.pen, new Rectangle(star.point, size));
            }
            for (int i = 0; i < allStars.Count; i++) // make it look like it is moving.
            {
                Star star = allStars[i];
                star.point.Offset(0,1);
                allStars[i] = star;
            }
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        internal void Twinkle()
        {
            int twinkleNumber = 5;
            for (int i = 0; i < twinkleNumber; i++)
            {
                int starNum = random.Next(4);
                allStars.RemoveAt(starNum);
            }
            for (int i = 0; i < twinkleNumber; i++)
            {
                allStars.Add(generateRandomStar());
            }
        }

        private Star generateRandomStar()
        {
            return new Star(new Point(random.Next(boundaries.Width),
                                      random.Next(boundaries.Height)),
                             new Pen(Color.Tomato));
        }
        //_____________________________________________________________________
        private struct Star
        {
            public Point point;
            public Pen pen;

            public Star(Point point, Pen pen)
            {
                this.point = point;
                this.pen = pen;
            }
        }
        //?????????????????????????????????????????????????????????????????????
        [TestMethod]
        public void TestStar()
        {
            Point point = new Point(5, 5);
            var pen = new Pen(Color.Yellow);
            Star star = new Star(point, pen);
            Assert.AreEqual(point, star.point);
            Assert.AreEqual(pen, star.pen);
        }

        [TestMethod]
        public void TestStarsCollection()
        {
            Assert.IsNotNull(allStars);
            Assert.AreEqual(300, allStars.Count);
            foreach (Star star in allStars)
            {
                Assert.IsInstanceOfType(star, typeof(Star));
            }
            
        }

        
    }
}
