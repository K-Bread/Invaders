using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvadersLab;
using System.Drawing;

namespace UnitTestInvaders
{
    [TestClass]
    public class UnitTest1
    {
        private Stars stars;
        [TestInitialize]
        public void Init()
        {
            var random = new Random();
            var boundaries = new Rectangle(5, 5, 10, 10);
            stars = new InvadersLab.Stars(random, boundaries);
        }
        
        [TestMethod]
        public void TestStarsMethods()
        {
            var random = new Random();
            var boundaries = new Rectangle(5, 5, 10, 10);
            var stars = new InvadersLab.Stars(random, boundaries);
            stars.TestStar();
            stars.TestStarsCollection();
        }

        [TestMethod]
        public void TestGameClass()
        {
            var random = new Random();
            var clientRectangle = new Rectangle(5,5,10,10);
            var game = new InvadersLab.Game(random, clientRectangle);
            Assert.IsNotNull(game);
            Assert.AreEqual(clientRectangle.Size, game.Size);
        }

        [TestMethod]
        public void TestStarsClass()
        {
            var random = new Random();
            var boundaries = new Rectangle(5,5,10,10);
            var stars = new InvadersLab.Stars(random, boundaries);
            Assert.IsNotNull(stars);
            Assert.AreEqual(boundaries.Size, stars.Size);
        }

        [TestMethod] // Memento pattern
        public void TestStarStateRecord()
        {
            StarsMemento memento = stars.CreateMemento();
        }
    }
}
