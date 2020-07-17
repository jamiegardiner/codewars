using Xunit;

namespace FixStringCase
{
    using System.Text.RegularExpressions;
    using FluentAssertions;

    public class UnitTest1
    {
        [Theory]
        [InlineData("code", "code")]
        [InlineData("CODe", "CODE")]
        [InlineData("COde", "code")]
        [InlineData("Code", "code")]
        public void BasicTests(string s, string expected)
        {
            Kata.Solve(s).Should().Be(expected);
        }
    }

    public class Kata
    {
        public static string Solve(string s)
        {
            var uppers = new Regex("[A-Z]").Matches(s);
            var lowers = new Regex("[a-z]").Matches(s);
            return lowers.Count >= uppers.Count ? s.ToLower() : s.ToUpper();
        }
    }
}