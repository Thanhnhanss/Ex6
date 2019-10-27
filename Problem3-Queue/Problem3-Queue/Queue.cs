using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Queue
{
    class Queue
    {
        private int [] Buffer;
        private int top;
        private int bot;
        public Queue (int size)
        {
            Buffer = new int[size];
            top = 0;
            bot = 0;
        }

        public void EnQueue( int n)
        {
          if (top == Buffer.Length)
          {
               Console.WriteLine("Full");
          }
           Buffer[top ++] = n;
        }
        public int DeQueue ()
        {
            if ( bot >= top)
            {
                Console.WriteLine("Empty!!");
            }
            return Buffer[bot++];
        }
        public int Count
        {
            get
            {
                return top - bot;
            }
        }
        public int Peek()
        {
            if ( bot >= top)
            {
                Console.WriteLine();
            } 
            return Buffer[bot];
        }
    }
}
