using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class EvenOdd
    {
        public int FindIndex(int[] arr)
        {
            if(arr.Length <= 1)
            {
                return -1;
            }

            int left = 0;
            int right = arr.Length - 1;
            bool isEven = false;
            bool isOdd = false;

            while(left <= right)
            {
                int mid = (left + right) / 2;

                if(arr[mid] % 2 == 0)
                {
                    if(isOdd)
                    {
                        return ++mid;
                    }
                    left = mid + 1;
                    isEven = true;
                }

                else
                {
                    if (isEven)
                    {
                        return --mid;
                    }
                    right = mid - 1;
                    isOdd = true;
                }
            }

            return -1;
        }
    }
}
