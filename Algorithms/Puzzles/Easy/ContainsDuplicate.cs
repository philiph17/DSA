namespace Algorithms.Puzzles.Easy;

public static class ContainsDuplicate
{
    public static bool ContainsDuplicates(int[] nums)
    {
        return new HashSet<int>(nums).Count < nums.Length;
    }
}