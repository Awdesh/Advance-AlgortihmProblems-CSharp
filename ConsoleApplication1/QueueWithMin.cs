using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// FIFO
    /// Class responsible for creating Enqueue, Dequeue and min operation.
    /// </summary>
    class QueueWithMin
    {
        Queue<int> elements = new Queue<int>();
        Queue<int> minQueue = new Queue<int>();

        /// <summary>
        /// Enqueue method that adds an item in the queue.
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
        /// Dequeue method that removes an item in the queue.
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
        /// Method returns min. element from the queue.
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
