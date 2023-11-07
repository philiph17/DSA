namespace Algorithms.Puzzles.Easy;

public static class ValidPalindrome
{
    public static bool IsPalindromeLinq(string s)
    {
        var arr = s.Where(char.IsLetterOrDigit).ToArray();

        return new string(arr).Equals(new string(arr.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);
    }

    public static bool IsPalindromeLoop(string s)
    {
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            while (l < r && !char.IsLetterOrDigit(s[l]))
            {
                l++;
            }

            while (r > l && !char.IsLetterOrDigit(s[r]))
            {
                r--;
            }

            if (char.ToLower(s[l]) != char.ToLower(s[r]))
            {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}