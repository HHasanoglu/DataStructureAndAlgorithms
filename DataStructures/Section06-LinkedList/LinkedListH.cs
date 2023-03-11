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
            list.Add(4);
            list.Display();
            //Console.WriteLine(list.Length);
            //Console.WriteLine();
            //list.AddFirst(25);
            //list.Display();
            //Console.WriteLine(list.Length);
            //Console.WriteLine();
            //list.AddAny(32, 3);
            //list.Display();
            //Console.WriteLine();
            //Console.WriteLine("Removed Element is:" + list.RemoveFirst());
            //list.Display();
            //Console.WriteLine();
            //list.RemoveLast();
            //list.Display();
            //Console.WriteLine();
            //Console.WriteLine(list.RemoveAny(2));
            //Console.WriteLine();
            //list.Display();

            //Console.WriteLine(list.Search(2)); 
            list.Display();
            list.InsertSorted(3);
            list.Display();



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

        public int Length { get => _length; }

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
                _Head.Next = newest;
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

        public int RemoveFirst()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = _Head.Element;
                _Head = _Head.Next;
                _length -= 1;
                if (IsEmpty)
                {
                    _tail = null;
                }
                return e;
            }
        }

        public int RemoveLast()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is Empty");
                return -1;
            }

            var p = _Head;
            var i = 1;

            while (i < _length - 1)
            {
                p = p.Next;
                i += 1;
            }

            _tail = p;
            p = p.Next;
            _tail.Next = null;
            _length -= 1;

            var element = p.Element;

            return element;

        }

        public void AddAny(int e, int Position)
        {
            var newNode = new Node(e, null);

            var i = 1;
            var p = _Head;
            while (i < Position - 1)
            {
                p = p.Next;
                i += 1;
            }
            newNode.Next = p.Next;
            p.Next = newNode;
            _length += 1;
        }


        public int RemoveAny(int Position)
        {
            if (Position >= 0 && Position<=_length)
            {

                var p = _Head;
                var i = 1;
                while (i<Position-1)
                {
                    p = p.Next;
                    i += 1;
                }
                var e = p.Next.Element;
                p.Next = p.Next.Next;
                _length -= 1;
                return e;
            }

            Console.WriteLine("List is Empty");
            return -1;
        }

        public int Search(int key) 
        {
            var p = _Head;
            var index = 0;

            while (p!=null)
            {
                if (p.Element==key)
                {
                    return index;
                }
                p = p.Next;
                index++;
            }

            return -1;
        }

        public void InsertSorted(int element) 
        {
            var newest = new Node(element, null);
            if (IsEmpty)
            {
                _Head = newest;
            }
            else 
            {
                var p = _Head;
                var q = _Head;
                while (p != null && p.Element <element)
                {
                    q = p;
                    p = p.Next;
                }
                if (p == _Head)
                {
                    newest.Next = _Head;
                    _Head = newest;
                }
                else 
                {
                    newest.Next = q.Next;
                    q.Next = newest;
                }
            }
            _length++;
        }


        public void Display() 
        {
            Node p = _Head;
            while (p != null)
            {
                Console.WriteLine(p.Element);
                p = p.Next;
            }
            Console.WriteLine();
        }

    }
}
