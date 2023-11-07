using Algorithms.Puzzles.Easy;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("", true)]
    [InlineData("([{}])", true)]
    [InlineData("()[]{}", true)]
    [InlineData("([{]})", false)]
    public void IsValid(string input, bool expectedResult)
    {
        var result = ValidParentheses.IsValid(input);

        result.Should().Be(expectedResult);
    }
}