using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Class responsible for creating a stack with optimized min operation.
    /// </summary>
    class StackWithMin
    {
        Stack<int> elements = new Stack<int>();
        Stack<int> minStack = new Stack<int>();

        /// <summary>
        /// Method pushes integer into stack.
        /// </summary>
        /// <param name="n">integer</param>
        public void Push(int n)
        {
            elements.Push(n);
            if(minStack.Count == 0 || minStack.Peek() > n)
            {
                minStack.Push(n);
            }
        }

        /// <summary>
        /// Method pops integer from stack.
        /// </summary>
        /// <returns>integer</returns>
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
        /// Method returns minimum integer from stack.
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
