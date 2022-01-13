namespace DSA.Searching;

public static class FindFirstAndLast
{
    public static int[] Find(int[] arr, int target)
    {
        int first = -1, last = -1;

        for (int i = 0, j = arr.Length - 1; i < arr.Length && j >= 0; i++, j--)
        {
            //moving from start
            if (arr[i] == target && first == -1) first = i;
            //moving from end
            if (arr[i] == target && last == -1) last = i;
            //if both have been set end early
            if (first != -1 && last != -1) break;
        }

        return new[] { first, last };
    }
}
