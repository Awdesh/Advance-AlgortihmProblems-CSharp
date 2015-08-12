using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FindMaxSubArraySum
    {
        public int FindMaxSum(int[] arr)
        {
            int maxSum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    maxSum += arr[i];
                }
                else
                {
                    maxSum = 0;
                }
            }
            return maxSum;
        }
    }
}
