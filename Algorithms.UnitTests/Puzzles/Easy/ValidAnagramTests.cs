using Algorithms.Puzzles.Easy;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;

public class ValidAnagramTests
{
    [Theory]
    [InlineData("", "", true)]
    [InlineData("angel", "glean", true)]
    [InlineData("arc", "car", true)]
    [InlineData("brag", "grab", true)]
    [InlineData("bored", "robed", true)]
    [InlineData("cat", "act", true)]
    [InlineData("state", "taste", true)]
    [InlineData("csharp", "python", false)]
    [InlineData("microsoft", "apple", false)]
    public void IsAnagramBySortingString(string s, string t, bool expectedResult)
    {
        var result = ValidAnagram.IsAnagramBySortingString(s, t);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("", "", true)]
    [InlineData("angel", "glean", true)]
    [InlineData("arc", "car", true)]
    [InlineData("brag", "grab", true)]
    [InlineData("bored", "robed", true)]
    [InlineData("cat", "act", true)]
    [InlineData("state", "taste", true)]
    [InlineData("csharp", "python", false)]
    [InlineData("microsoft", "apple", false)]
    public void IsAnagramByHashTable(string s, string t, bool expectedResult)
    {
        var result = ValidAnagram.IsAnagramByHashTable(s, t);

        result.Should().Be(expectedResult);
    }
}