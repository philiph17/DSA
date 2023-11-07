using Algorithms.Searching;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Searching;

public class BinarySearchTests
{
    [Theory]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    //[InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 1, 0)]
    public void IterativeSearch(int[] items, int searchItem, int expectedIndex)
    {
        var index = BinarySearch.IterativeSearch(items, searchItem);

        index.Should().Be(expectedIndex);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 1, 0)]
    public void RecursiveSearch(int[] items, int searchItem, int expectedIndex)
    {
        var index = BinarySearch.RecursiveSearch(items, 0, items.Length, searchItem);

        index.Should().Be(expectedIndex);
    }
}