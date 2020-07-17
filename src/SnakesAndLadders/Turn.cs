namespace SnakesAndLadders
{
    public class Turn
    {
        private readonly int _die1;
        private readonly int _die2;

        public Turn(int die1, int die2)
        {
            _die1 = die1;
            _die2 = die2;
        }

        public bool IsDouble()
        {
            return _die1 == _die2;
        }
        
        public int TurnTotal()
        {
            return _die1 + _die2;
        }
    }
}