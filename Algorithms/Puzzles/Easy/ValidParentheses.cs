namespace Algorithms.Puzzles.Easy;

public static class ValidParentheses
{
    private static Dictionary<char, char> ParenthesesCloseToOpenMap = new()
    {
        {')', '('},
        {'}', '{'},
        {']', '['}
    };

    public static bool IsValid(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true; // empty string, not wrong?
        }

        if (s.Length % 2 != 0)
        {
            return false; // odd number, cant be true
        }

        var stack = new Stack<char>(s.Length - 1);

        foreach (var c in s)
        {
            if (ParenthesesCloseToOpenMap.TryGetValue(c, out var value))
            {
                if (stack.Any() && stack.Peek() == value)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return !stack.Any();
    }
}