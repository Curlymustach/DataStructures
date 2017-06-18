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
        int count;
        public Stack()
        {
            count = 0;
        }

        public void Push(T value)
        {
            stack.Add(value);
            count++;
        }

        public void Pop()
        {
            if(count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                stack.Remove(stack.head);
            }
        }

        public void Print()
        {
            stack.Print();
        }

        public T Peek()
        {
            return stack.head.Prev.Value;
        }
    }
}
