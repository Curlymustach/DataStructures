using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresIntro
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void Add(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
                head.Next = head;
                head.Prev = head;
                tail = head;
            }
            else
            {
                Node<T> add = new Node<T>(value, head, tail);
                tail.Next = add;
                head.Prev = add;

                tail = add;
            }
                    
            count++;
        }

        public Node<T> Find(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                return head;
            }

            if (index == this.count - 1)
            {
                return head.Prev;
            }

            int count = 0;
            Node<T> temp = head;
            while (count < index)
            {
                temp = temp.Next;
                count++;
            }
            return temp;
        }

        public void AddAfter(Node<T> nodeBefore, T value)
        {
            Node<T> temp;

            temp = new Node<T>(value, nodeBefore.Next, nodeBefore);

            nodeBefore.Next.Prev = temp;
            nodeBefore.Next = temp;
            //if (nodeBefore.Next != null)
            //{
            //    temp = new Node<T>(value, nodeBefore.Next, nodeBefore);
            //    nodeBefore.Next = temp;
            //    temp.Next.Prev = temp;
            //}

            //if (nodeBefore.Next == null)
            //{
            //    temp = new Node<T>(value, null, nodeBefore);
            //    nodeBefore.Next = temp;
            //}


        }

        public void AddBefore(Node<T> nodeAfter, T value)
        {
            //if nodeAfter is the first node == head then just 
            // make the new node the head and link stuff
            Node<T> temp;

            temp = new Node<T>(value, nodeAfter, nodeAfter.Prev);

            nodeAfter.Prev.Next = temp;
            nodeAfter.Prev = temp;

            //if (nodeAfter.Prev != null)
            //{
            //    Node<T> temp = new Node<T>(value, nodeAfter, nodeAfter.Prev);
            //    nodeAfter.Prev.Next = temp;
            //    nodeAfter.Prev = temp;
            //}

            //if (nodeAfter.Prev == null)
            //{
            //    Node<T> temp = new Node<T>(value);
            //    temp.Next = head;
            //    head = temp;
            //}
        }


        public void Remove(int index)
        {
            Remove(Find(index));
        }

        public void Remove(Node<T> node)
        {

            if (node.Prev == head && node.Next == head)
            {
                head = null;
            }
            else if(node == head)
            {                
                node.Prev.Next = node.Next;
                node.Next.Prev = node.Prev;
                head = head.Next;
            }
            else
            {
                node.Prev.Next = node.Next;
                node.Next.Prev = node.Prev;
                //head = head.Next;
            }




            //if (node.Prev == null && node.Next == null)
            //{
            //    head = null;
            //}

            //if (node.Next == null)
            //{
            //    node.Prev.Next = null;
            //}

            //if (node.Prev == null)
            //{
            //    node.Next.Prev = null;
            //    head = node.Next;
            //}

            //if (node.Next != null && node.Prev != null)
            //{
            //    node.Prev.Next = node.Next;
            //    node.Next.Prev = node.Prev;
            //}
        }



        public void Print()
        {
            if (head != null)
            {
                Node<T> temp = head;
                Console.WriteLine(head.Value);
                while (temp.Next != head)
                {
                    temp = temp.Next;
                    Console.WriteLine(temp.Value);
                }
            }
        }

        public T Get(int index)
        {
            return Find(index).Value;
        }




    }
}
