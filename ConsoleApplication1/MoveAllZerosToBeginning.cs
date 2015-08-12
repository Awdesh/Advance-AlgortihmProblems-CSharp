using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MoveAllZerosToBeginning
    {
        /// <summary>
        /// Two index problem-: Expedia.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] Move(int[] arr)
        {
            int zeroCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    ++zeroCount;
                }
            }

            // By default. while declaring an array all elements are assgined to 0.
            int[] res = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    res[zeroCount] = arr[i];
                    zeroCount++;
                }
            }
            return res;
        }
    }
}
