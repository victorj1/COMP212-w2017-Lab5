using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class ListNodes2
    {

        // automatic read-only property Data
        public string Data { get; private set; }

        // automatic property Next
        public ListNodes2 Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNodes2(string dataValue) : this(dataValue.ToString(), null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNodes2(string dataValue, ListNodes2 nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
