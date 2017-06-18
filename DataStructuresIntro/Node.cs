using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresIntro
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node<T> Prev;



        public Node(T Value)
        {
            this.Value = Value;
            this.Next = null;
            this.Prev = null;
        }

        public Node(T Value, Node<T> Next, Node<T> Prev)
        {
            this.Value = Value;
            this.Next = Next;
            this.Prev = Prev;

        }

        public Node(T Value, Node<T> Prev)
        {
            this.Value = Value;
            this.Prev = Prev;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
