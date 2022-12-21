using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class StackLinkList
    {
        #region Ctor
        public StackLinkList()
        {
            _top = null;
            _length = 0;
        }

        #endregion

        #region Private Fields

        private Node _top;
        private int _length;


        #endregion

        #region Public Properties

        public bool IsEmpty { get => _length == 0; }

        public int Length { get => _length; }

        //public bool IsFull { get => _top == _data.Length; }
        #endregion

        #region Public Methods

        public static void Run()
        {

            var stackLink = new StackLinkList();
            stackLink.Push(1);
            stackLink.Push(2);
            stackLink.Push(3);
            stackLink.Push(4);
            stackLink.Push(5);
            stackLink.Display();
            stackLink.Pop();
            stackLink.Display();
            //Console.WriteLine(list.Peek());
            //stackLink.Pop();
            //stackLink.Display();
            //stackLink.Pop();
            //stackLink.Display();
            //stackLink.Pop();
            //stackLink.Display();
            //stackLink.Pop();
            //stackLink.Display();
            //stackLink.Pop();
            //stackLink.Push(7);
            //stackLink.Push(8);
            //stackLink.Display();






        }

        public void Push(int element)
        {
            var newest = new Node(element, null);

            if (IsEmpty)
            {
                _top = newest;
            }
            else
            {
                newest.Next=_top;
                _top = newest;
            }
                _length++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            var element = _top.Element;
            _top = _top.Next;
            _length--;

            return element;
        }

        public int peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            var element = _top.Element;

            return element;
        }

        public void Display()
        {
            Node p = _top;
            while (p != null)
            {
                Console.WriteLine(p.Element);
                p = p.Next;
            }
            Console.WriteLine();
        }
        #endregion
    }
}
