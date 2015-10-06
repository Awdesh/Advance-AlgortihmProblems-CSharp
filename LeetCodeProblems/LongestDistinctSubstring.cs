using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s) 
        {
            SortedDictionary<char, int> map = new SortedDictionary<char, int>();
            // Dictionary to maintain the substrings.
            SortedDictionary<string, int> ss = new SortedDictionary<string,int>();
            char[] chArr = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
        
            foreach(char c in chArr)
            {
                if(!map.ContainsKey(c))
                {
                    map.Add(c,1);
                    sb.Append(c);
                }
            
                else
                {
                    if (!ss.ContainsKey(sb.ToString()))
                    {
                        ss.Add(sb.ToString(), sb.ToString().Length);
                    }
                    sb.Clear();
                    map.Clear();
                }
            }
            
            var s1 = ss.Keys.ElementAt(0);
            Console.WriteLine(s1);
            return ss.Values.Max();
        }
    }
}
