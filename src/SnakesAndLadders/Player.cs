namespace SnakesAndLadders
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int Position { get; private set; }

        public void SetPosition(int position)
        {
            Position = position;
        }
    }
}