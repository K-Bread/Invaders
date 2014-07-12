using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvadersLab;
using System.Drawing;

namespace UnitTestInvaders
{
    [TestClass]
    public class UnitTestPlayerShip
    {
        private InvadersLab.PlayerShip player;
        [TestInitialize]
        public void Init()
        {
            player = new InvadersLab.PlayerShip();
        }
        [TestMethod]
        public void TestStartState()
        {
            Point location = player.Location;
            Assert.IsNotNull(location);
            // Check rectangle
            /// check is alive
            bool isAlive = player.Alive;
            Assert.IsTrue(isAlive);
        }

        [TestMethod]
        public void TestMove()
        {
            var location1 = player.Location;
            player.Move(Direction.Left);
            var location2 = player.Location;
            Assert.AreNotEqual(location1, location2);
            Assert.IsTrue(location1.X > location2.X);

            player.Move(Direction.Right);
            var location3 = player.Location;
            Assert.AreNotEqual(location2, location3);
            Assert.AreEqual(location1, location3);
        }

        [TestMethod]
        public void TestPlayerDraw()
        {
            //Graphics.FromImage()
        }
    }
}
