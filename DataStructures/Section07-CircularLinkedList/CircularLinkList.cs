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

        public bool IsEmpty { get => _length == 0; }

        public static void Run()
        {
            CircularLinkList list = new CircularLinkList();
            list.AddFirst(1);
            list.Add(2);
            list.Add(4);
            list.Display();
            list.AddFirst(5);
            list.Display();
            list.AddAny(15, 3);
            list.Display();
            int removedElement=list.RemoveFirst();
            Console.WriteLine($"Removed Element {removedElement}");
            list.Display();
            //var lastRemoved=list.RemoveLast();
            //Console.WriteLine($"Last Removed Element is {lastRemoved}");
            list.Display();
            list.Add(2);
            list.Display();
            var removeAny=list.RemoveAny(3);
            Console.WriteLine($"The element {removeAny} is removed");
            list.Display();
        }

        private void Display()
        {
            var p = _head;
            var i = 0;
            while (i < _length)
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

        public void AddFirst(int element)
        {
            if (IsEmpty)
            {
                Add(element);
            }
            else
            {
                var newewst = new Node(element, null);
                newewst.Next = _head;
                _head = newewst;
                _tail.Next = newewst;
                _length++;
            }
        }

        public void AddAny(int element, int Position)
        {
            if (Position >= 0 && Position < _length)
            {
                var p = _head;
                var i = 1;
                while (i < Position - 1)
                {
                    p = p.Next;
                    i++;
                }
                var newest = new Node(element, null);
                newest.Next = p.Next;
                p.Next = newest;
                _length++;
            }
            else
            {
                Console.WriteLine("Position is Not Valid");
            }
        }

        public int RemoveFirst()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int e = _head.Element;
            _tail.Next = _head.Next;
            _head = _head.Next;
            _length--;
            //if (IsEmpty)
            //{
            //    _head = null;
            //    _tail = null;
            //}
            return e;
        }

        public int RemoveLast() 
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            var p = _head;
            var i = 1;
            while (i<_length-1)
            {
                p = p.Next;
                i++;
            }
            _tail = p;
            p = p.Next;
            var e = p.Element;
            _tail.Next = _head;
            _length--;

            return e;
        }

        public int RemoveAny(int Position) 
        {
            if (Position >= 0 && Position < _length)
            {
                var p = _head;
                var i = 1;
                while (i < Position-1)
                {
                    p = p.Next;
                    i++;
                }
                var e = p.Next.Element;
                p.Next = p.Next.Next;
                _length--;
                return e;
            }
            else 
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
        }

    }
}
