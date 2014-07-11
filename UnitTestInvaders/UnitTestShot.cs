using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvadersLab;
using System.Drawing;

namespace UnitTestInvaders
{
    [TestClass]
    public class UnitTestShot
    {
        private Shot downShot;
        private Shot upShot;
        [TestInitialize]
        public void Init()
        {
            var location1 = new Point(5, 5);
            Rectangle boundaries1 = new Rectangle(location1, new Size(location1));
            upShot = new Shot(location1, Direction.Up, boundaries1);
            downShot = new Shot(location1, Direction.Down, boundaries1);

        }

        [TestMethod]
        public void TestStartStateUp()
        {
            Assert.IsNotNull(upShot.Location);
            Assert.IsNotNull(downShot.Location);
        }

        [TestMethod]
        public void TestMove()
        {
            var location1 = downShot.Location;
            downShot.Move();
            var location2 = downShot.Location;
            Assert.AreNotEqual(location1, location2);
            Assert.IsTrue(location1.Y < location2.Y);

            location1 = upShot.Location;
            upShot.Move();
            location2 = upShot.Location;
            Assert.AreNotEqual(location1, location2);
            Assert.IsTrue(location1.Y > location2.Y);
        }
    }
}
