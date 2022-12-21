using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DoublyLinkedList
    {

        #region Private Fileds

        private DoublyNode _head;
        private DoublyNode _tail;
        private int _length;


        #endregion

        #region Public Properties
        public int Length { get => _length; set => _length = value; }

        public bool IsEmpty { get => _length == 0; }
        #endregion


        #region Public Methods

        public static void Run()
        {
            var doublyLinkList = new DoublyLinkedList();
            doublyLinkList.Add(1);
            doublyLinkList.Add(2);
            //doublyLinkList.Add(3);
            //doublyLinkList.Add(4);
            //doublyLinkList.Display();
            ////doublyLinkList.DisplayReverse();
            ////doublyLinkList.AddFirst(6);
            //doublyLinkList.Display();
            //doublyLinkList.DisplayReverse();
            //doublyLinkList.AddAny(3, 3);
            //doublyLinkList.Display();
            //doublyLinkList.DisplayReverse();
            //doublyLinkList.AddAny(6, 6);
            //doublyLinkList.Display();
            //doublyLinkList.DisplayReverse();
            //var removedFirstElement=doublyLinkList.RemoveFirst();
            //Console.WriteLine(removedFirstElement);
            //doublyLinkList.Add(3);
            doublyLinkList.Display();
            //var removedLast=doublyLinkList.RemoveLast();
            ////Console.WriteLine(removedLast);
            //doublyLinkList.Display();
            //doublyLinkList.DisplayReverse();
            doublyLinkList.RemoveAny(2);
            doublyLinkList.Display();

        }

        public void Display()
        {
            var i = 0;
            var p = _head;
            while (i < _length)
            {
                Console.WriteLine(p.Element);
                p = p.Next;
                i++;
            }
            Console.WriteLine();
        }

        public void DisplayReverse()
        {
            var i = Length - 1;
            var p = _tail;
            while (i >= 0)
            {
                Console.WriteLine(p.Element);
                p = p.Previous;
                i--;
            }
            Console.WriteLine();
        }


        public void Add(int element)
        {
            var newest = new DoublyNode(element, null, null);
            if (IsEmpty)
            {
                _head = newest;
                _tail = newest;
            }
            else
            {
                _tail.Next = newest;
                newest.Previous = _tail;
                _tail = newest;
            }
            Length++;
        }

        public void AddFirst(int element)
        {
            var newest = new DoublyNode(element, null, null);
            if (IsEmpty)
            {
                _head = newest;
                _tail = newest;
            }
            else
            {
                newest.Next = _head;
                _head.Previous = newest;
                _head = newest;
            }
            _length++;
        }

        public void AddAny(int element, int Position) 
        {
            if (Position<=0 || Position>=Length)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            var newest = new DoublyNode(element, null, null);
            var p = _head;
            var i = 1;
            while (i<Position-1)
            {
                p = p.Next;
                i++;
            }
            newest.Next = p.Next;
            p.Next.Previous = newest;
            newest.Previous = p;
            p.Next = newest;
            _length++;
        }

        public int RemoveFirst() 
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            var e = _head.Element;
            _head = _head.Next;
            _length--;
            if (IsEmpty)
            {
                _tail = null;
            }
            else
            {
                _head.Previous = null;
            }

            return e;

        }

        public int RemoveLast() 
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            var e = _tail.Element;
            _tail = _tail.Previous;
            _tail.Next = null;
            _length--;
            return e;
        }

        public int RemoveAny(int Position) 
        {
            if (Position<=0 || Position>=_length)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            var p = _head;
            var i = 1;
            while (i<Position-1)
            {
                p = p.Next;
                i++;
            }
            var e = p.Next.Element;
            p.Next = p.Next.Next;
            p.Next.Previous = p;
            _length--;
            return e;
        }


        #endregion


    }
}
