namespace SnakesAndLadders.Boards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SnakesAndLadders.Squares;

    public class EmptyBoard : IBoard
    {
        private readonly List<ISquare> _squares;

        public EmptyBoard(int numberOfSquares)
        {
            _squares = new List<ISquare>(Enumerable.Range(1, numberOfSquares).Select(s => new BlankSquare(s)));
        }

        public void AddSquare(ISquare square)
        {
            if (square.Position > _squares.Count)
                throw new ArgumentException($"Square Position ({square.Position}) cannot be higher than number of squares allows on board ({_squares.Count})");

            if (square.ShiftedPosition > _squares.Count)
                throw new ArgumentException($"Square ShiftedPosition ({square.ShiftedPosition}) cannot be higher than number of squares allows on board ({_squares.Count})");

            var indexToReplace = _squares.IndexOf(_squares.Single(x => x.Position.Equals(square.Position)));
            _squares[indexToReplace] = square;
        }

        public int TotalSquares => _squares.Count;

        public ISquare GetSquareAt(int position)
        {
            return _squares.Single(square => square.Position == position);
        }
    }
}