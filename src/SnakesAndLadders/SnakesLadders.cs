namespace SnakesAndLadders
{
    using System.Collections.Generic;
    using System.Linq;
    using SnakesAndLadders.Boards;

    public class SnakesLadders
    {
        private const string GameOverMessage = "Game over!";

        private readonly List<Player> _players;
        private readonly IBoard _board;
        private readonly IMoveCalculator _moveCalculator;
        private readonly ITurnTracker _turnTracker;

        public SnakesLadders(IBoard board, int numberOfPlayers)
        {
            _board = board;
            _players = new List<Player>(Enumerable.Range(1, numberOfPlayers).Select(p => new Player($"Player {p}")));
            _moveCalculator = new MoveCalculator();
            _turnTracker = new TurnTracker(_players);
        }

        public string Play(int die1, int die2)
        {
            var totalBoardSquares = _board.TotalSquares;
            if (_players.SingleOrDefault(p => p.Position == totalBoardSquares) != null)
                return GameOverMessage;

            var turn = new Turn(die1, die2);
            var currentPlayer = _turnTracker.GetCurrentPlayer(turn);
            var newPosition = _moveCalculator.MovePlayer(turn, currentPlayer.Position, totalBoardSquares);
            var currentSquare = _board.GetSquareAt(newPosition);
            currentPlayer.SetPosition(currentSquare.ShiftedPosition);

            return currentPlayer.Position == totalBoardSquares
                ? $"{currentPlayer.Name} Wins!"
                : $"{currentPlayer.Name} is on square {currentPlayer.Position}";
        }
    }
}