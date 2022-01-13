namespace DSA.Searching;

public static class BinarySearch
{
    public static int Search(int[] arr, int target)
    {
        var minNum = 0;
        var maxNum = arr.Length - 1;

        while (minNum <= maxNum)
        {
            var mid = (minNum + maxNum) / 2;
            if (target == arr[mid])
                return mid;
            else if (target < arr[mid])
                maxNum = mid - 1;
            else
                minNum = mid + 1;
        }

        return -1;
    }
}
