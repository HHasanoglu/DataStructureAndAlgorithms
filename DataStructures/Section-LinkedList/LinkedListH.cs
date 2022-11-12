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
            Console.WriteLine();
            list.AddFirst(25);
            list.Display();
            Console.WriteLine(list.Length);
            list.AddAny(32, 3);
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

        public void AddFirst(int e) 
        {
            var newest = new Node(e, null);
            if (IsEmpty)
            {
                _Head = newest;
                _tail = newest;
            }
            else 
            {
                newest.Next = _Head;
                _Head = newest;
            }
            _length += 1;
        }

        public void AddAny(int e, int Position)
        {
            var newNode = new Node(e, null);

            var i = 1;
            var p = _Head;
            while (i<Position-1)
            {
                p = p.Next;
                i += 1;
            }
            newNode.Next = p.Next;
            p.Next = newNode;
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
