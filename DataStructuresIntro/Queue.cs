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
        }

        public void Enqueue(T value)
        {
            queue.Add(value);
        }

        //public T Dequeue()
        //{
        //    if (Count == 0)
        //    {
        //        throw new IndexOutOfRangeException();
        //    }
        //    else
        //    {
        //        T item = queue.tail.Value();
        //        queue.Remove(queue.tail);
        //        return item;
        //    }
        //}

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
                return (queue.tail.Value);
            }
            
        }


    }
}
