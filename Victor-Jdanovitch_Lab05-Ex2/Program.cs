using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackInheritanceLibrary;
using LinkedListLibrary;

namespace Victor_Jdanovitch_Lab05_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise #2 --> Testing StackInheritenceLibrary");

            StackInheritance st = new StackInheritance();

            //Pushing 4 objects in a stack

            Console.WriteLine("\nFour double values: \n 1)   5.0 \n 2)   7.2 \n 3)   9.7 \n 4)   6.5\n");

            st.Push(5.0);
            st.Push(7.2);
            st.Push(9.7);
            st.Push(6.5);
            st.Display();

            //Poping Values
            Console.WriteLine("Removed a value from the stack");
            st.Pop();
            st.Display();
            Console.ReadKey();

            //Peeking the top value
            Console.WriteLine("Showing the top value of stack");
            st.peek();
            st.Display();
        }
    }
}
