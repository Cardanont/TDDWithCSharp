using CSharpTDD;
using CSharpTDD.TicTacToe;
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
        public void CreateGame_GameIsInCorrectState()
        {
            Game game = new Game();

            Assert.AreEqual(0, game.MovesCounter);
            Assert.AreEqual(State.Unset, game.GetState(1));
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

        [Test]
        public void MakingMoves_SetStateCorretly()
        {
            Game game = new Game();

            MakeMoves(game, 1, 2, 3, 4);

            Assert.AreEqual(State.Cross, game.GetState(1));
            Assert.AreEqual(State.Zero, game.GetState(2));
            Assert.AreEqual(State.Cross, game.GetState(3));
            Assert.AreEqual(State.Zero, game.GetState(4));
        }

        [Test]
        public void GetWinner_ZeroesWinVertically_ReturnsZeroes()
        {
            Game game = new Game();

            // 2,4,8 - corsses win
            MakeMoves(game, 1, 4, 5, 2, 9);

            Assert.AreEqual(Winner.Crosses, game.GetWinner());
        }

        [Test]
        public void GetWinner_ZeroesWinDiagonal_ReturnsZeroes()
        {
            Game game = new Game();

            // 2,4,8 - zeroes win
            MakeMoves(game, 1, 2, 3, 5, 7, 8);

            Assert.AreEqual(Winner.Zeroes, game.GetWinner());
        }

        [Test]
        public void GetWinner_GameIsUnfinished_ReturnsGameIsUnfinished()
        {
            Game game = new Game();

            MakeMoves(game, 1, 2, 4);

            Assert.AreEqual(Winner.GameIsUnfinished, game.GetWinner());
        }

        private void MakeMoves(Game game, params int[] indexes)
        {
            foreach (var index in indexes)
            {
                game.MakeMove(index);
            }
        }

    }
}
