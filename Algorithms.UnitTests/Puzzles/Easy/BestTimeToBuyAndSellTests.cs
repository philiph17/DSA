using Algorithms.Puzzles.Easy;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;
public class BestTimeToBuyAndSellTests
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    public void MaxProfit(int[] prices, int expectedResult)
    {
        var result = BestTimeToBuyAndSell.MaxProfit(prices);

        result.Should().Be(expectedResult);
    }
}
