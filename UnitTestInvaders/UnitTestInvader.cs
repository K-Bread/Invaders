using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvadersLab;
using System.Drawing;

namespace UnitTestInvaders
{
    [TestClass]
    public class UnitTestInvader
    {
        private InvadersLab.Invader invader;
        [TestInitialize]
        public void Init()
        {
            ShipType type = ShipType.Star;
            Point location = new Point(5,5); int score = 5;
            invader = new InvadersLab.Invader( type, location, score);
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            Direction d = Direction.Down;
            var location1 = new Point(invader.Location.X, invader.Location.Y);
            invader.Move(d);
            Assert.AreNotEqual(location1, invader.Location);
        }
    }
}
