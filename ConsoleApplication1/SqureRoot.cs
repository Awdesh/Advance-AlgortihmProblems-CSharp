using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SqureRoot
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int FindSquareRoot(int num)
        {
            int count = 1;
            for (int i = 1; i * i <= num; i *= 2 )
            {
                if(i*i == num)
                {
                    return i;
                }
                count++;
            }
            return -1;
        }
    }
}
