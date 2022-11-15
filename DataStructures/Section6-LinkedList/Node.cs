using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node
    {
        public Node(int element, Node next)
        {
            Element = element;
            Next = next;
        }

        public int Element { get; set; }

        public Node Next { get; set; }
    }
}
