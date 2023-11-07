using Algorithms.Puzzles.Medium;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Medium;

public class ProductExceptSelfTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void ProductExceptSelfLoop(int[] nums, int[] expectedResult)
    {
        var result = ProductExceptSelf.ProductExceptSelfLoop(nums);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void ProductExceptSelfLinq(int[] nums, int[] expectedResult)
    {
        var result = ProductExceptSelf.ProductExceptSelfLinq(nums);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void ProductExceptSelfPrePost(int[] nums, int[] expectedResult)
    {
        var result = ProductExceptSelf.ProductExceptSelfPrePost(nums);

        result.Should().BeEquivalentTo(expectedResult);
    }

    //[Theory]
    //[InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    //[InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    //public void ProductExceptSelfUsingDivision(int[] nums, int[] expectedResult)
    //{
    //    var result = ProductExceptSelf.ProductExceptSelfPrePost(nums);

    //    result.Should().BeEquivalentTo(expectedResult);
    //}
}