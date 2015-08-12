using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class strStr
    {
        public bool IsSubString(string s1, string s2)
        {
            int l1 = s1.Length;
            int l2 = s2.Length;

            for (int i = 0; i < l1; i++ )
            {
                int j = 0;
                while(j < l2 && i < l1)
                {
                    if(s1[i] == s2[j])
                    {
                        if (j == l2 -1)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                    j++;
                    i++;
                }
            }
            return false;
        }
    }
}
