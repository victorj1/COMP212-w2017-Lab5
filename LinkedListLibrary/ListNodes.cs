using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class ListNodes
    {
        
        // automatic read-only property Data
        public double Data { get; private set; }

        // automatic property Next
        public ListNodes Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNodes(double dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNodes(double dataValue, ListNodes nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }

    }

