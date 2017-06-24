using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresIntro
{
    public class Stack<T>

     {
        LinkedList<T> stack = new LinkedList<T>();
        //Node<T> top;
        public int Count
        {
            get
            {
                return stack.count;
            }
        }


        public Stack()
        {
        }

        public void Push(T value)
        {
            stack.Add(value);
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T item = stack.tail.Value;
                stack.Remove(stack.tail);
                return item;
            }
        }

        public void Print()
        {
            stack.Print();
        }

        public T Peek()
        {
            if(Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return stack.tail.Value;
            }
                
        }
    }
}
