namespace SnakesAndLadders.Boards
{
    using SnakesAndLadders.Squares;

    public interface IBoard
    {
        int TotalSquares { get; }
        ISquare GetSquareAt(int position);
    }
}