using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresIntro
{
    public class Queue<T>
    {
        LinkedList<T> queue;

        public int Count
        {
            get
            {
                return queue.count;
            }
        }

        public Queue()
        {
            queue = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            queue.Add(value);
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T item = queue.head.Value;
                queue.Remove(queue.head);
                return item;
            }
        }

        public bool IsEmpty()
        {
            if(Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            queue.Print();
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return (queue.head.Value);
            }
            
        }


    }
}
