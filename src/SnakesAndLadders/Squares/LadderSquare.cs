namespace SnakesAndLadders.Squares
{
    using System;

    public class LadderSquare : ISquare
    {
        public LadderSquare(int position, int shiftedPosition)
        {
            if(shiftedPosition < position)
                throw new ArgumentException($"Shifted Position ({shiftedPosition}) cannot be lower than position ({Position}) for a LadderSquare");
            
            Position = position;
            ShiftedPosition = shiftedPosition;
        }

        public int Position { get; }
        public int ShiftedPosition { get; }
    }
}