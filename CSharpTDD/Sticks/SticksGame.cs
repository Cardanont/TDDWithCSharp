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
            if (numberOfSticks < 10)
            {
                throw new ArgumentException($"Number of sticks has to be >= 10. You passed:{numberOfSticks}");
            }

            NumberOfSticks = numberOfSticks;
            Turn = turn;
        }

        /// <summary>
        /// copy of ctor
        /// </summary>
        private SticksGame(Player turn, int numberOfSticks)
        {
            NumberOfSticks = numberOfSticks;
            Turn = turn;

        }

        public SticksGame HumaMakesMove(int sticksTaken)
        {
            if(Turn == Player.Machine)
            {
                throw new InvalidOperationException("It's turn of machine tomake a move!");
            }

            if(sticksTaken < MinToTake || sticksTaken > MaxToTake)
            {
                throw new ArgumentException($"You should take from one to three sticks. you took: {sticksTaken}");
            }

            return new SticksGame(Revert(Turn), NumberOfSticks-sticksTaken);
        }

        private Player Revert(Player p)
        {
            return p == Player.Machine ? Player.Human : Player.Machine;
        }

        public const int MaxToTake = 3;
        public const int MinToTake = 1;
    }
}
