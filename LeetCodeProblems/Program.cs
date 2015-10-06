using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int len = s.LengthOfLongestSubstring("thebrownfxjumpover");
            Console.WriteLine(len);
        }
    }
}
