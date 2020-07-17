namespace SnakesAndLadders
{
    using System.Linq;

    public class MoveCalculator : IMoveCalculator
    {
        public int MovePlayer(Turn turn, int currentPosition, int totalSquares)
        {
            var moves = new int[turn.TurnTotal()].ToList();
            var moveDirection = MoveDirection.Forward;
            var newPosition = currentPosition;

            moves.ForEach(t =>
            {
                if (newPosition == totalSquares) moveDirection = MoveDirection.Backwards;
                if (moveDirection == MoveDirection.Forward) newPosition++;
                else newPosition--;
            });

            return newPosition;
        }
    }
}