using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Find Minimum in rotated sorted array.
    /// </summary>
    class FindMinSortedArray
    {
        public int FindMin(int[] nums)
        {
            return FindMin(nums, 0, nums.Length - 1);
        }

        public int FindMin(int[] nums, int left, int right)
        {
            if(left == right)
            {
                return nums[left];
            }

            if(right - left == 1)
            {
                return Math.Min(nums[left], nums[right]);
            }

            int middle = left + (right - left) / 2;

            //No rotation.
            if(nums[left] < nums[right])
            {
                return nums[left];
            }

            // rotation happened but same element are on left and right index respectively.
            else if (nums[right] == nums[left])
            {
                return FindMin(nums, left + 1, right);
            }

            // rotation hasn't happened yet, min element shld be on right.
            else if(nums[middle] >= nums[left])
            {
                return FindMin(nums, middle, right);
            }

            else
            {
                return FindMin(nums, left, middle);
            }
        }
    }
}
