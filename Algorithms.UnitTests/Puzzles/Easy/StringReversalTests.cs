using Algorithms.Puzzles.Easy;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;

public class StringReversalTests
{
    [Theory]
    [InlineData("Hello", "olleH")]
    public void MaxSubArrayQuadratic(string input, string expectedOutput)
    {
        var result = StringReversal.ReverseWithRecursion(input);

        result.Should().Be(expectedOutput);
    }
}