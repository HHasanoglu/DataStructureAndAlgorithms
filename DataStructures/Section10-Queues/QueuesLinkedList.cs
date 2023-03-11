using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class QueuesLinkedList
    {
        #region Ctor
        public QueuesLinkedList()
        {

        }

        #endregion

        #region Private Fields

        Node _front;
        Node _rear;
        int _size;

        #endregion

        #region Public Properties

        public bool IsEmpty { get => _size == 0; }

        public int Length { get => _size; }

        #endregion

        #region Public Methods

        public static void Run()
        {
            var list = new QueuesLinkedList();
            list.Enque(1);
            list.Enque(2);
            list.Display();
            list.Deque();
            list.Display();
            list.Deque();
            list.Display();
            Console.WriteLine(list.Length);



        }

        public void Enque(int element)
        {
            var node = new Node(element);
            if (IsEmpty)
            {
                _front = node;
            }
            else
            {
                _rear.Next = node;
            }
            _rear = node;
            _size++;
        }
        public int Deque()
        {

            if (IsEmpty)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            var element = _front.Element;
            _front = _front.Next;
            _size--;
            if (IsEmpty)
            {
                _rear = null;
            }
            return element;
        }
        public void Display()
        {
            var temp = _front;
            while (temp!=null)
            {
                Console.Write(temp.Element);
                temp = temp.Next;
                if (temp!=null)
                {
                    Console.Write("=>");
                }
            }
            Console.WriteLine();
        }
        #endregion

    }
}
