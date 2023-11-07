using Algorithms.Puzzles.Easy;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;

public class ValidPalindromeTests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    public void IsPalindromeLinq(string x, bool expected)
    {
        var result = ValidPalindrome.IsPalindromeLinq(x);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    public void IsPalindromeLoop(string x, bool expected)
    {
        var result = ValidPalindrome.IsPalindromeLoop(x);

        result.Should().Be(expected);
    }
}