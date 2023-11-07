using Algorithms.Puzzles.Easy;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;

public class MaxSubArrayTests
{
    [Theory]
    [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    public void MaxSubArrayQuadratic(int[] numbers, int expectedMaxSum)
    {
        var result = MaxSubArray.MaxSubArrayQuadratic(numbers);

        result.Should().Be(expectedMaxSum);
    }

    [Theory]
    [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    public void MaxSubArraySlidingWindow(int[] numbers, int expectedMaxSum)
    {
        var result = MaxSubArray.MaxSubArraySlidingWindow(numbers);

        result.Should().Be(expectedMaxSum);
    }
}