namespace SnakesAndLadders
{
    using System.Collections.Generic;
    using System.Linq;

    public class TurnTracker : ITurnTracker
    {
        private readonly IList<Player> _players;
        private Player _currentPlayer;

        public TurnTracker(IList<Player> players)
        {
            _players = players;
            _currentPlayer = _players[0];
        }
        
        public Player GetCurrentPlayer(Turn turn)
        {
            if (turn.IsDouble())
                return _currentPlayer;
            
            var currentTurnPlayer = _currentPlayer;
            var nextPlayer = _currentPlayer == _players.Last() ? _players[0] : _players[_players.IndexOf(_currentPlayer) + 1];
            _currentPlayer = nextPlayer;
            return currentTurnPlayer;
        }
    }
}