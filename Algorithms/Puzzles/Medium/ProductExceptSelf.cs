namespace Algorithms.Puzzles.Medium;

public static class ProductExceptSelf
{
    public static int[] ProductExceptSelfLinq(int[] nums)
    {
        return nums.Select((x, i) =>

            nums.Where((_, index) => index != i).Aggregate(1, (current, number) => current * number)
        ).ToArray();
    }

    public static int[] ProductExceptSelfLoop(int[] nums)
    {
        var returnList = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var indexProduct = 1;
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                indexProduct *= nums[j];
            }

            returnList[i] = indexProduct;
        }

        return returnList;
    }

    public static int[] ProductExceptSelfPrePost(int[] nums)
    {
        var res = new int[nums.Length];

        //calculate prefix for each index and update it in output array 
        //for first index prefix will be 1
        res[0] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            res[i] = res[i - 1] * nums[i - 1];
        }

        var post = 1;
        //now calculate postfix and update the output array
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= post;
            post *= nums[i];
        }

        return res;
    }
}