using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD.Sticks
{

    public enum Player
    {
        Machine,
        Human
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

        public void HumaMakesMove(int sticksTaken)
        {
            if(sticksTaken < MinToTake || sticksTaken > MaxToTake)
            {
                throw new ArgumentException($"You should take from one to three sticks. you took: {sticksTaken}");
            }
        }

        public const int MaxToTake = 3;
        public const int MinToTake = 1;
    }
}
