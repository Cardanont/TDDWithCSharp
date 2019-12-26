using System;

namespace CSharpTDD.Sticks
{

    public enum Player
    {
        Machine,
        Human
    }

    public interface ICanGenerateNumbers
    {
        int Next(int min, int max);
    }
    public class NumbersGenerator : ICanGenerateNumbers
    {
        private readonly Random _generator = new Random();
        public int Next(int min, int max)
        {
            return _generator.Next(min, max);
        }
    }

    public class SticksGame
    {
        private readonly ICanGenerateNumbers _generator;
        public int NumberOfSticks { get; }
        public Player Turn { get; }

        public SticksGame(int numberOfSticks, Player turn):this(numberOfSticks, turn, new NumbersGenerator())
        {

        }

        public SticksGame(int numberOfSticks, Player turn, ICanGenerateNumbers generator)
        {
            if (numberOfSticks < 10)
            {
                throw new ArgumentException($"Number of sticks has to be >= 10. You passed:{numberOfSticks}");
            }

            _generator = generator;
            NumberOfSticks = numberOfSticks;
            Turn = turn;
        }

        /// <summary>
        /// copy of ctor
        /// </summary>
        private SticksGame(Player turn, int numberOfSticks, ICanGenerateNumbers generator, EventHandler<Move> onMachineMoved)
        {
            NumberOfSticks = numberOfSticks;
            Turn = turn;
            _generator = generator;
            MachineMoved = onMachineMoved;

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

            return new SticksGame(Revert(Turn), NumberOfSticks-sticksTaken, _generator, MachineMoved);
        }

        private Player Revert(Player p)
        {
            return p == Player.Machine ? Player.Human : Player.Machine;
        }

        public const int MaxToTake = 3;
        public const int MinToTake = 1;
        public event EventHandler<Move> MachineMoved;

        public SticksGame MachineMakesMove()
        {
            int sticksTaken = _generator.Next(MinToTake, MaxToTake);
            int remains = NumberOfSticks - sticksTaken;
            MachineMoved?.Invoke(this, new Move(sticksTaken, remains));

            return new SticksGame(Revert(Turn), remains, _generator, MachineMoved);
        }
    }

    public class PredictableGenerator : ICanGenerateNumbers
    {
        private int _number;
        public int Next(int min, int max)
        {
            return _number;
        }

        public void SetNumber(int number)
        {
            _number = number;
        }
    }

    public struct Move
    {
        public int Taken { get; }
        public int Remains { get; }

        public Move(int taken, int remains)
        {
            Taken = taken;
            Remains = remains;
        }
    }
}
