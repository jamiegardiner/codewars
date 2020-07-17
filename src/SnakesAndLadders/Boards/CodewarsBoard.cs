namespace SnakesAndLadders.Boards
{
    using System.Collections.Generic;
    using SnakesAndLadders.Squares;

    public class CodewarsBoard : EmptyBoard
    {
        public CodewarsBoard() : base(100)
        {
            new List<LadderSquare>
            {
                new LadderSquare(2, 38),
                new LadderSquare(7, 14),
                new LadderSquare(8, 31),
                new LadderSquare(15, 26),
                new LadderSquare(21, 42),
                new LadderSquare(28, 84),
                new LadderSquare(36, 44),
                new LadderSquare(51, 67),
                new LadderSquare(71, 91),
                new LadderSquare(78, 98),
                new LadderSquare(87, 94)
            }.ForEach(AddSquare);

            new List<SnakeSquare>
            {
                new SnakeSquare(16, 6),
                new SnakeSquare(46, 25),
                new SnakeSquare(49, 11),
                new SnakeSquare(62, 19),
                new SnakeSquare(64, 60),
                new SnakeSquare(74, 53),
                new SnakeSquare(89, 68),
                new SnakeSquare(92, 88),
                new SnakeSquare(95, 75),
                new SnakeSquare(99, 80),
            }.ForEach(AddSquare);
        }
    }
}