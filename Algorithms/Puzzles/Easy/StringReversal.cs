namespace Algorithms.Puzzles.Easy;

public static class StringReversal
{
    public static string ReverseWithRecursion(string str)
    {
        // base case
        if (str.Length == 0)
        {
            return string.Empty;
        }

        return str[^1] + ReverseWithRecursion(str[..^1]);
    }
}