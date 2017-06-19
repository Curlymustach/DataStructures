using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresIntro
{
    class Program
    {
        //Queue
        //first in first out basis
        //Enqueue, Dequeue, Peek

        static int Fibb(int a, int b, int max)
        {

            if (a + b < 100)
            {
                Console.WriteLine(a + b);
                Fibb(b, a + b, max);
            }
            return a + b;
        }

        static void PrintFibb(int max)
        {
            Console.WriteLine("0\n1\n1");
            Fibb(1, 1, max);
        }

        static int Factorial(int a)
        {
            if (a < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if(a == 0)
            {
                return 0;
            }

            if(a == 1)
            {
                return 1;
            }

            return(a * Factorial(a - 1));          
 

        }

        static void PrintFactorial(int a)
        {
            Console.WriteLine(Factorial(6));
        }


        static void Main(string[] args)
        {

            //LinkedList<int> List = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();
            Random random = new Random();

            for (int count = 0; count < 2; count++)
            {
                stack.Push(count);
            }

            Console.WriteLine("List:");
            stack.Print();

            stack.Pop();
            Console.WriteLine("New List:");
            stack.Print();

            //Console.WriteLine("Peek:");
            //Console.WriteLine("{0}", stack.Peek());
            

           // Console.WriteLine("\n{0}", stack.Peek());


            Console.ReadKey();

            //List.Add();



            //create a linked list
            //add 10 random numbers
            //print list

        }
    }
}
