namespace SnakesAndLadders
{
    using System;
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using SnakesAndLadders.Boards;

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            Console.WriteLine("Starting new game");
            var game = new SnakesLadders(new CodewarsBoard(), 4);
            
            string result;
            do
            {
                var die = new Random(DateTime.Now.ToUniversalTime().Ticks.GetHashCode());
                var die1 = die.Next(1, 6);
                var die2 = die.Next(1, 6);
                result = game.Play(die1, die2);
                Console.WriteLine($"Rolled {die1} and {die2}... ({die1 + die2})");
                Console.WriteLine($"RESULT: {result}");
            } while (!new Regex("(.+) Wins!").IsMatch(result) && !result.Equals("Game over!"));
            
            Console.WriteLine($"Game Time Elapsed: {stopWatch.Elapsed.TotalMilliseconds}ms");
        }
    }
}
