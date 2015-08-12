using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RemoveDupFromSorted
    {
        public int[] Remove(int[] arr)
        {
            int len = arr.Length;
            int count = 0;
            int i = 0;
            while(i + 1 < len)
            {
	            if(arr[i] != arr[i+1])
	            {
                    arr[count] = arr[i];
                    arr[++count] = arr[i + 1];
	            }
	            i++;
            }
            int[] B = new int[++count];
            Array.Copy(arr, B, count);

            return B;
        }

        // alternatively a dictionary can be used to maintain count of each number inside the array.
    }
}
