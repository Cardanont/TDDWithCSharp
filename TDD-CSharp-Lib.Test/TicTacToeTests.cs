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
            TicTacToe game = new TicTacToe();
            Assert.AreEqual(0, game.MovesCounter);
        }

        [Test]
        public void MakeMove_CounterShift()
        {
            TicTacToe game = new TicTacToe();
            game.MakeMove(1);

            Assert.AreEqual(1, game.MovesCounter);
        }
    }
}
