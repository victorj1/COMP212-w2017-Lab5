using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class List
    {
        public ListNodes firstNode;
        private ListNodes lastNode;
        private string name; // string like "list" to display
        private int count = 0;

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert object at front of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNodes(insertItem);
            }
            else
            {
                firstNode = new ListNodes(insertItem, firstNode);
            }

            count++;
        }

        // Insert object at end of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNodes(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNodes(insertItem);
            }

            count++;
        }

        // remove first node from List
        public double RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            double removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            count--;

            return removeItem; // return removed data
        }

        // remove last node from List
        public double RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            double removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNodes current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            count--;
            return removeItem; // return removed data
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNodes current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }

        public ListNodes Search(double item)
        {
            ListNodes node = firstNode;

            while (node != null)
            {
                if (node.Data == item)
                {
                    break;
                }
                else
                {
                    node = node.Next;
                }
            }

            return node;
        }

        public int Count()
        {
            return count;
        }
    }
}
