using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RotationIndex
    {
        public int FindIndex(int[] nums)
        {
            int l = nums.Length;
            for (int i = 1; i + 1 < l; i++ )
            {
                int item = nums[i];
                if(item < nums[i+1] && item > nums[i-1])
                {
                    continue;
                }
                return i;
            }
            return -1;
        }
    }
}
