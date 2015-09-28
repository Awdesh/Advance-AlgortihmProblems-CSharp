using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CodeKata
    {
        public int FindMin(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = 0;

            if(start == end)
            {
                return arr[start];
            }

            if(end - start == 1)
            {
                return Math.Min(arr[start], arr[end]);
            }
            
            while(start <= end)
            {
                mid = (start + end) / 2;
                // rotation point.
                if(arr[mid] > arr[0] && arr[mid] > arr[--mid] && arr[mid] > arr[++mid])
                {
                    return ++mid;
                }
                else if(arr[mid] > arr[0] && arr[mid] > arr[--mid] && arr[mid] < arr[++mid])
                {
                    start = ++mid;
                }
                else
                {
                    end = mid;
                }
            }
            return mid;
        }

        public int SearchrotatedSortedArray(int[] arr, int num)
        {
            int start = 0;
            int end = arr.Length - 1;

            if(start == end)
            {
                return arr[start] == num ? start : -1;
            }

            if(end - start == 1)
            {
                if(arr[start] == num)
                {
                    return start;
                }
                else if(arr[end] == num)
                {
                    return end;
                }
                else
                {
                    return -1;
                }
            }

            int mid = 0;
            while(start <= end)
            {
                mid = (start + end) / 2;
                if(arr[mid] == num)
                {
                    return mid;
                }
                
                // number exists on right side of mid.
                if(arr[mid] > num && arr[start] > num)
                {
                    start = mid++;
                }
                else if (arr[mid] < num && arr[start] > num)
                {
                    start = mid++;
                }
            }
        }
    }
}
