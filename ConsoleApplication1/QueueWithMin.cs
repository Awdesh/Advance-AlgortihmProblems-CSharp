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
    class QueueWithMin
    {
        Queue<int> elements = new Queue<int>();
        Queue<int> minQueue = new Queue<int>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        public void Enqueue(int n)
        {
            elements.Enqueue(n);
            if(minQueue.Count == 0 || minQueue.Peek() > n)
            {
                minQueue.Enqueue(n);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (elements.Count == 0)
            {
                return -1;
            }
            minQueue.Dequeue();
            return elements.Dequeue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Min()
        {
            if(minQueue.Count == 0)
            {
                return -1;
            }

            elements.Peek();
            return minQueue.Peek();
        }
    }
}
