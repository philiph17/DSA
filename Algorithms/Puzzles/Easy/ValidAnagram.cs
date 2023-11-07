namespace Algorithms.Puzzles.Easy;

public static class ValidAnagram
{
    public static bool IsAnagramBySortingString(string s, string t)
    {
        return string.Equals(SortString(s), SortString(t), StringComparison.OrdinalIgnoreCase);
    }

    private static string SortString(string s)
    {
        var characters = s.ToLower().ToCharArray();
        Array.Sort(characters);

        return new string(characters);
    }

    public static bool IsAnagramByHashTable(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var charFrequency = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            charFrequency.TryAdd(s[i], 0);
            charFrequency.TryAdd(t[i], 0);

            charFrequency[s[i]]++;
            charFrequency[t[i]]--;
        }

        return !charFrequency.Values.Any(freq => freq == 0);
    }
}