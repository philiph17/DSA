using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Searching
{
    public static class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            var minNum = 0;
            var maxNum = nums.Length - 1;

            while (minNum <= maxNum)
            {
                var mid = (minNum + maxNum) / 2;

                if (target == nums[mid]) return mid;
                else if (target < nums[mid]) maxNum = mid - 1;
                else minNum = mid + 1;
            }

            return -1;
        }
    }
}
