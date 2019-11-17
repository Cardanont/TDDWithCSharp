using CSharpTDD;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_CSharp_Lib.Test
{
    [TestFixture]
    class TicTacToeTests
    {
        [Test]
        public void CreateGame_With_ZeroMoves()
        {
            Game game = new Game();
            Assert.AreEqual(0, game.MovesCounter);
        }

        [Test]
        public void MakeMove_CounterShift()
        {
            Game game = new Game();
            game.MakeMove(1);

            Assert.AreEqual(1, game.MovesCounter);
        }

        [Test]
        public void MakeInvalidMove_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var game = new Game();
                game.MakeMove(0);
            });
        }

        [Test]
        public void MoveOnTheSameSquare_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var game = new Game();
                game.MakeMove(1);
                game.MakeMove(1);
            });
        }
    }
}
