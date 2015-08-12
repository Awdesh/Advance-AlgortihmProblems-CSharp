using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQSample ls = new LINQSample();
            //ls.QueryUsingEnumerable();
            //Console.WriteLine("\n\n");
            //ls.QueryUsingVar();
            //Console.WriteLine("\n\n");
            //ls.QueryModification();
            //Console.WriteLine("\n\n");
            //ls.QueryUsingLetKeyword();

            //GroupAnagrams ga = new GroupAnagrams();
            //Dictionary<string, int> map = new Dictionary<string, int>();
            //map.Add("bat", 1);
            //map.Add("rat", 2);
            //map.Add("tab", 3);
            //map.Add("tar", 4);
            //map.Add("art", 5);
            //ga.Group(map);

            //int[] arr = new int[]{4, 5, 2, 2, 0, -1, 25, 20, 11, 13, 21, 3};
            //NextLarger nl = new NextLarger();
            //nl.FindNext(arr);

            //StringCruncher sc = new StringCruncher();
            //char[] arr = sc.Crunch("AAABBCDEE");

            //int[] arr = new int[] { 6, 8, 9, 1, 4, 5 };
            //FindMinSortedArray fa = new FindMinSortedArray();
            //int min = fa.FindMin(arr);

            //SearchInSortedArray s = new SearchInSortedArray();
            //int index = s.Search(arr, 1);

            //strStr ss = new strStr();
            //bool val = ss.IsSubString("DUMBELL", "DUMB");

            //int[] arr = new int[]{1,2,2,3,4,4,5,5,6,6,6,7,8,9};
            //RemoveDupFromSorted dup = new RemoveDupFromSorted();
            //dup.Remove(arr);

            //int[] arr = new int[] { 2,2, 9};
            //EvenOdd eo = new EvenOdd();
            //int index = eo.FindIndex(arr);

            //MulnDiv md = new MulnDiv();
            //int data = md.PerformDivision(100, 55);
            //Console.WriteLine(data);

            //int mul = md.PerformMultiplication(3, 180000);
            //Console.WriteLine(mul);

            //SqureRoot sr = new SqureRoot();
            //int num = sr.FindSquareRoot(81);
            //Console.WriteLine(num);

            //FindMaxSubArraySum f = new FindMaxSubArraySum();
            //int[] arr = new int[] {5,7,8,10,-5,-2,6,15,31 };
            //int sum = f.FindMaxSum(arr);

            //MoveAllZerosToBeginning m = new MoveAllZerosToBeginning();
            //int[] arr = new int[] {5,7,8,0,0,6,15,31 };

            //int[] res = m.Move(arr);

            StackWithMin sMin = new StackWithMin();
            sMin.Push(5);
            sMin.Push(15);
            sMin.Push(3);
            sMin.Push(2);
            sMin.Push(1);

            int min = sMin.Min();
        }
    }
}
