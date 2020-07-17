namespace SnakesAndLadders.Tests
{
    using FluentAssertions;
    using SnakesAndLadders.Boards;
    using SnakesAndLadders.Squares;
    using Xunit;

    public class SnakesLadderTests
    {
        private readonly SnakesLadders _game;

        public SnakesLadderTests()
        {
            _game = new SnakesLadders(new TestBoard(), 2);
        }

        [Fact]
        public void Player1MovesFirst()
        {
            var result = _game.Play(1, 3);

            result.Should().Be("Player 1 is on square 4");
        }

        [Fact]
        public void Player2MovesSecond()
        {
            _game.Play(1, 3);
            var result = _game.Play(1, 5);

            result.Should().Be("Player 2 is on square 6");
        }

        [Fact]
        public void PlayerScoreIsAccumulated()
        {
            _game.Play(1, 2); // Player 1
            _game.Play(1, 3); // Player 2
            _game.Play(2, 1); // Player 1
            var result = _game.Play(5, 5); // Player 2

            result.Should().Be("Player 2 is on square 14");
        }

        [Fact]
        public void RollingDoubleGivesAnotherTurn()
        {
            _game.Play(2, 2); // Player 1
            var result = _game.Play(1, 4); // Player 1

            result.Should().Be("Player 1 is on square 9");
        }

        [Fact]
        public void PlayerLandingOnLadderGoesUp()
        {
            var result = _game.Play(1, 1); // Player 1

            result.Should().Be("Player 1 is on square 38");
        }

        [Fact]
        public void PlayerLandingOnSnakeGoesDown()
        {
            _game.Play(6, 6); // Player 1
            var result = _game.Play(2, 2); // Player 1

            result.Should().Be("Player 1 is on square 6");
        }

        [Fact]
        public void PlayerLandingOnLastSquareWins()
        {
            _game.Play(5, 5); // Player 1
            _game.Play(5, 5); // Player 1
            _game.Play(5, 5); // Player 1
            var result = _game.Play(5, 5); // Player 1

            result.Should().Be("Player 1 Wins!");
        }

        [Fact]
        public void PlayerMovingAfterAPlayerHasAlreadyWonResultsInGameOver()
        {
            _game.Play(5, 5); // Player 1
            _game.Play(5, 5); // Player 1
            _game.Play(5, 5); // Player 1
            _game.Play(5, 5); // Player 1
            var result = _game.Play(5, 5); // Player 2

            result.Should().Be("Game over!");
        }

        [Fact]
        public void PlayerBouncesOffLastSquareIfNotExactMatch()
        {
            _game.Play(5, 5); // Player 1 - Position 10
            _game.Play(5, 5); // Player 1 - Position 20
            _game.Play(5, 5); // Player 1 - Position 30
            var result = _game.Play(6, 6); // Player 1

            result.Should().Be("Player 1 is on square 38");
        }
    }

    public class TestBoard : EmptyBoard
    {
        public TestBoard() : base(40)
        {
            AddSquare(new LadderSquare(2, 38));
            AddSquare(new SnakeSquare(16, 6));
        }
    }
}