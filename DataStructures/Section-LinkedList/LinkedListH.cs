using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedListH
    {


        public static void Run() 
        {
            LinkedListH list = new LinkedListH();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Display();
            Console.WriteLine(list.Length);
        }


        public LinkedListH() 
        {
            _Head = null;
            _tail = null;
            _length = 0;
        }



        private Node _Head;

        private Node _tail;

        private int _length;

        public int Length { get => _length;}

        public bool IsEmpty { get => _length == 0; }

        public void Add(int element) 
        {
            var newest = new Node(element, null);

            if (IsEmpty)
            {
                _Head = newest;
            }
            else
            {
                _tail.Next = newest;
            }

            _tail = newest;

            _length += 1;
        }

        public void Display() 
        {
            Node p = _Head;
            while (p!=null)
            {
                Console.WriteLine(p.Element);
                p = p.Next;
            }
        }

    }
}
