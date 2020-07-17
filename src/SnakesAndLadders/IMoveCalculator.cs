namespace SnakesAndLadders
{
    public interface IMoveCalculator
    {
        int MovePlayer(Turn turn, int currentPosition, int totalSquares);
    }
}