using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MulnDiv
    {
        /// <summary>
        /// Perform Division without using "/" operator.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int PerformDivision(int num1, int num2)
        {
            int sum = num2;
            int count = 1;
            while(num1 > sum)
            {
                sum += num2;
                count++;
            }

            return num1 == sum ? count : --count;
        }

        /// <summary>
        /// Perform multiplication without using "*" operator.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="times"></param>
        /// <returns></returns>
        public int PerformMultiplication(int num1, int times)
        {
            int sum = num1;
            int count = 1;

            while(times > count)
            {
                sum += num1;
                count++;
            }

            return sum;
        }
    }
}
