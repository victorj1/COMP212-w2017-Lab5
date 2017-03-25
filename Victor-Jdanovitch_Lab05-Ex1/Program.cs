using LinkedListLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab05_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise #1");
            try
            {
               

                List l = new List("SampleList");

                Console.WriteLine("\nInserting five elements:\n1)   2.5\n2)   3.5\n3)   4.0\n4)   5.8\n5)   7.1\n");
                //+Front Value
                l.InsertAtFront(2.5);
                //+Value
                l.InsertAtBack(3.5);
                //+Value
                l.InsertAtFront(4.0);
                //+value
                l.InsertAtFront(5.8);
                //+backvalue
                l.InsertAtFront(7.1);
                //Displays list
                l.Display();

                Console.WriteLine("Removed elements from front:\n");
                l.RemoveFromFront();
                l.Display();
                Console.WriteLine("Value 7.1 Removed \n");

                Console.WriteLine("Searching for element with value 4.0");
                if (l.Search(4.0) != null)
                    Console.WriteLine("Found!\n");
                else
                    Console.WriteLine("Not Found!\n");

                Console.WriteLine("Searching for value 10");
                if (l.Search(10) != null)
                    Console.WriteLine("Found!\n");
                else
                    Console.WriteLine("Not Found!\n");

                //All values removed from linked list
                Console.WriteLine("Removing 2 more elements from list:");
                l.RemoveFromFront();
                l.RemoveFromFront();
                l.Display();

                Console.WriteLine("\nRemoving Element from an empty linkedlist");
                l.RemoveFromFront();
            }
            catch (EmptyListException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
