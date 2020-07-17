namespace SnakesAndLadders.Squares
{
    using System;

    public class SnakeSquare : ISquare
    {
        public SnakeSquare(int position, int shiftedPosition)
        {
            if(shiftedPosition > position)
                throw new ArgumentException($"Shifted Position ({shiftedPosition}) cannot be higher than position ({Position}) for a SnakeSquare");
            
            Position = position;
            ShiftedPosition = shiftedPosition;
        }

        public int Position { get; }
        public int ShiftedPosition { get; }
    }
}