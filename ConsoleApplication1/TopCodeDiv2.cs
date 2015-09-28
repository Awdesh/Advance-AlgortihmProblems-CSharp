using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TopCodeDiv2
    {
        public string compare(int num1, int num2)
        {
            List<int> list = new List<int>();
            while ((num1 / 10) > 0)
            {
                int digit = num1 % 10;
                list.Add(digit);
                num1 = num1 / 10;
            }

            list.Add(num1);

            while ((num2 / 10) > 0)
            {
                int digit = num2 % 10;
                if (list.Contains(digit))
                    list.Remove(digit);
                num2 = num2 / 10;
            }
            list.Remove(num2);

            if (list.Count == 0 || list.Count == 1)
                return "happy";
            else
                return "glasses";
        }
    }
}
