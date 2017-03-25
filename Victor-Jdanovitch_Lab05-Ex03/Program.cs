using QueueInheritanceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab05_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise #3");
            QueueInheritance Q = new QueueInheritance();

            //Adding Elements to the queue
            Console.WriteLine("\n---Adding three string values---");
            Q.Enqueue("Alex");
            Q.Enqueue("Ben");
            Q.Enqueue("Chris");
            //Displaying items in Q
            Q.Display();

            //Removing element from Queue
            Console.WriteLine("\n---Removing two names from the queue---");
            Q.Dequeue();
            Q.Dequeue();
            Q.Display();
        }
    }
}
