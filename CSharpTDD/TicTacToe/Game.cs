using CSharpTDD.TicTacToe;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD
{
    public class Game
    {

        public int MovesCounter { get; private set; }
        private readonly State[] _board = new State[9];

        public void MakeMove(int index)
        {
            if(index < 1 || index > 9)
                throw new ArgumentOutOfRangeException();
            if (GetState(index) != State.Unset)
                throw new InvalidOperationException();

            _board[index - 1] = MovesCounter % 2 == 0 ? State.Cross : State.Zero;

            MovesCounter++;
        }

        private State GetState(int index)
        {
            return _board[index - 1];
        }
    }
}
