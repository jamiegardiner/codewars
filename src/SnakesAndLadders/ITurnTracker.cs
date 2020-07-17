namespace SnakesAndLadders
{
    public interface ITurnTracker
    {
        Player GetCurrentPlayer(Turn turn);
    }
}