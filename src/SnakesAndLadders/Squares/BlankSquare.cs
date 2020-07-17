namespace SnakesAndLadders.Squares
{
    public class BlankSquare : ISquare
    {
        public BlankSquare(int position)
        {
            Position = position;
            ShiftedPosition = position;
        }

        public int Position { get; }
        public int ShiftedPosition { get; }
    }
}