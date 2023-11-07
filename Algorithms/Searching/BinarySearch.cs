namespace Algorithms.Searching;

public static class BinarySearch
{
    public static int IterativeSearch(int[] items, int searchItem)
    {
        var low = 0;
        var high = items.Length - 1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2; // prevent integer overflow

            var item = items[mid];

            if (item == searchItem)
            {
                return mid;
            }

            if (item > searchItem)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }

    public static int RecursiveSearch(int[] items, int min, int max, int searchItem)
    {
        var mid = (min + max) / 2;
        if (items[mid] == searchItem)
        {
            return mid;
        }

        if (items[mid] > searchItem)
        {
            return RecursiveSearch(items, min, mid - 1, searchItem);
        }

        if (max < min)
        {
            return -1;
        }

        return RecursiveSearch(items, mid + 1, max, searchItem);
    }
}