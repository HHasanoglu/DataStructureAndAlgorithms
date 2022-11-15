using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class CircularLinkList
    {
        private Node _head;
        private Node _tail;
        private int _length;

        public bool IsEmpty { get => _length==0; }

        public static void Run()
        {
            CircularLinkList list = new CircularLinkList();
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Display();

        }

        private void Display()
        {
            var p = _head;
            var i = 0;
            while (i<_length)
            {
                Console.WriteLine(p.Element);
                p = p.Next;
                i++;
            }

            Console.WriteLine();
        }

        public void Add(int e)
        {
            var newest = new Node(e, null);
            if (IsEmpty)
            {
                newest.Next = newest;
                _head = newest;
            }
            else
            {
                newest.Next = _tail.Next;
                _tail.Next = newest;
            }

            _length++;
            _tail = newest;
        }

    }
}
