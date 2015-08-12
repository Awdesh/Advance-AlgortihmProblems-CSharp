using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 
    /// </summary>
    class StackWithMin
    {
        Stack<int> elements = new Stack<int>();
        Stack<int> minStack = new Stack<int>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        public void Push(int n)
        {
            elements.Push(n);
            if(minStack.Count == 0 || minStack.Peek() > n)
            {
                minStack.Push(n);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if(minStack.Count == 0)
            {
                return elements.Pop();
            }

            if(minStack.Peek() == elements.Peek())
            {
                elements.Pop();
                return minStack.Pop();
            }

            return elements.Pop();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Min()
        {
            if (minStack.Count == 0)
            {
                return -1;
            }

            return minStack.Peek();
        }
    }
}
