using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD
{
    public class TicTacToe
    {

        public int MovesCounter { get; private set; }

        public void MakeMove(int index)
        {
            MovesCounter++;
        }
    }
}
