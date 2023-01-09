using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class QueuesArray
    {
        #region Ctor
        public QueuesArray(int n)
        {
            _data = new int[n];
        }

        #endregion

        #region Private Fields

        int[] _data;
        int _front;
        int _rear;
        int _size;


        #endregion

        #region Public Properties

        public bool IsEmpty { get => _size == 0; }

        public int Length { get => _size; }

        public bool IsFull { get => _size == _data.Length; }
        #endregion

        #region Public Methods

        public static void Run()
        {
            var list = new QueuesArray(5);
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
            if (IsFull)
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            _data[_rear] = element;
            _rear++;
            _size++;
        }
        public int Deque()
        {
            
            if (IsEmpty)
            {
                Console.WriteLine("Queue is Empty");
                return-1;
            }
            int element = _data[_front];
            _front++;
            _size--;
            return element;
        }
        public void Display()
        {
            for (int i = _front; i < _rear; i++)
            {
                Console.WriteLine(_data[i]);
            }
            Console.WriteLine();
        }
        #endregion
    }
}
