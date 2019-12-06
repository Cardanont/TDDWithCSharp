using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD.Sticks
{

    public enum Player
    {
        Machine
    }

    public class SticksGame
    {
        public int NumberOfSticks { get; }
        public Player Turn { get; }

        public SticksGame(int numberOfSticks, Player turn)
        {

            NumberOfSticks = numberOfSticks;
            Turn = turn;

            if (numberOfSticks < 10)
            {
                throw new ArgumentException($"Number of sticks has to be >= 10. You passed:{numberOfSticks}");
            }
        }
    }
}
