using Algorithms.Puzzles.Easy;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;

public class TwoSumTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 4, 0, 2)]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, 0, 1)]
    [InlineData(new[] { 8, 3, 17, 27 }, 44, 2, 3)]
    public void TwoSumByBruteForce(int[] numbers, int target, int expectedFirstIndex, int expectedSecondIndex)
    {
        var result = TwoSum.TwoSumByBruteForce(numbers, target);

        result.Item1.Should().Be(expectedFirstIndex);
        result.Item2.Should().Be(expectedSecondIndex);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 4, 0, 2)]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, 0, 1)]
    [InlineData(new[] { 8, 3, 17, 27 }, 44, 2, 3)]
    public void TwoSumByHashTable(int[] numbers, int target, int expectedFirstIndex, int expectedSecondIndex)
    {
        var result = TwoSum.TwoSumByHashTable(numbers, target);

        result.Item1.Should().Be(expectedFirstIndex);
        result.Item2.Should().Be(expectedSecondIndex);
    }
}