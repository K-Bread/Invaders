using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvadersLab;
using System.Drawing;

namespace UnitTestInvaders
{
    [TestClass]
    public class UnitTestGame
    {
        private Game game;
        [TestInitialize]
        public void Init()
        {
            game = new Game(new Random(), new Rectangle(5, 5, 10, 10));
        }
        
        [TestMethod]
        public void TestGameTwinkle()
        {
            var starState1 = game.getStarState();
            game.Twinkle();
            var starState2 = game.getStarState();
            Assert.IsFalse(starState1.Equals(starState2));
        }
    }
}
