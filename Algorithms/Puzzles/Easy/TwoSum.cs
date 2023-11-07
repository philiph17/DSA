namespace Algorithms.Puzzles.Easy;

public static class TwoSum
{
    public static (int, int) TwoSumByBruteForce(int[] numbers, int target)
    {
        // nested loop so Time: O(n^2), Space: O(1)
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] >= target)
            {
                continue;
            }

            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] == (target - numbers[i]))
                {
                    return (i, j);
                }
            }
        }

        return (-1, -1); // no matches found
    }

    public static (int, int) TwoSumByHashTable(int[] nums, int target)
    {
        // loop so Time: O(n), Space: O(n) for the map
        var map = new Dictionary<int, int>(); // value & index

        for (var i = 0; i < nums.Length; i++)
        {
            var remainder = target - nums[i];
            if (map.TryGetValue(remainder, out var index))
            {
                return (index, i);
            }

            map.Add(nums[i], i);
        }

        return (-1, -1); // no matches found
    }
}