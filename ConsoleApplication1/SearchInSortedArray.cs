using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SearchInSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int index = -1;
            // TC-:1 , nums can have 2 or less element so can't find rotation index.
            if (nums.Length > 2)
            {
                int l = nums.Length;
                for (int i = 1; i + 1 < l; i++)
                {
                    int item = nums[i];
                    if (item < nums[i + 1] && item > nums[i - 1])
                    {
                        continue;
                    }
                    index = i;
                }
            }

            int low = 0;
            int high = nums.Length - 1;

            // TC-2 , index returned is greater than zero i.e. array does have rotation.
            if(index > 0)
            {
                if (nums[index] == target)
                {
                    return index;
                }

                if (nums[index] > target)
                {
                    low = index + 1;
                }
                else
                {
                    high = index;
                }
            }
           
            while(low <= high)
            {
                // int overflow.
                int mid = low + (high - low) / 2;
                
                if(nums[mid] == target)
                {
                    return mid;
                }

                if(nums[mid] < target)
                {
                    low = mid + 1;
                }

                if(nums[mid] > target)
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

    }
}
