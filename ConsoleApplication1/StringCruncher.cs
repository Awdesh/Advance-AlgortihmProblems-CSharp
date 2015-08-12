using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringCruncher
    {
        /// <summary>
        /// Expedia.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public char[] Crunch(string s)
        {
            // Alternative approach to solve this can be to use a hash tableand store char(key) and its frequency(value) in the map.
            // that would be faster. O(n) time to store in map then O(n) time to read from map. so total O(n). 

            // below approach is O(nlogn).
            char[] chArr = s.ToCharArray();
            // this will put all chars together.
            Array.Sort(chArr);

            int l = chArr.Length;
            int count = 1;
            int index = 0;
            for (int i = l - 1; i - 1 >= 0; i--)
            {
                if (chArr[i - 1] != chArr[i])
                {
                    if (count > 1)
                    {
                        chArr[index] = (char)count;
                        count = 1;
                        index = 0;
                    }
                }
                else
                {
                    if(index == 0)
                        index = i;
                    count++;
                }
            }
            
            if(count > 0)
            {
                chArr[index] = (char)++count;
            }

            return chArr;
        }
    }
}
