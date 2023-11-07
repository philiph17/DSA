namespace Algorithms.Puzzles.Easy;

public static class MaxSubArray
{
    public static int MaxSubArrayQuadratic(int[] numbers)
    {
        // triple nested loop O(n^3)
        var maxSum = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i; j < numbers.Length; j++)
            {
                var total = 0;
                for (var k = i; k < j; k++)
                {
                    total += numbers[k];
                }

                if (total > maxSum)
                {
                    maxSum = total;
                }
            }
        }

        return maxSum;
    }

    public static int MaxSubArraySlidingWindow(int[] numbers)
    {
        var maxSub = numbers[0];
        var currentSum = 0;

        foreach (var n in numbers)
        {
            if (currentSum < 0)
            {
                currentSum = 0;
            }

            currentSum += n;
            maxSub = Math.Max(maxSub, currentSum);
        }

        return maxSub;
    }
}