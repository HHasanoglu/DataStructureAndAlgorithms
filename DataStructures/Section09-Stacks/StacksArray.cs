using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class StacksArray
    {
        #region Ctor
        public StacksArray(int n)
        {
            _data = new int[n];
        }

        #endregion

        #region Private Fields

        int[] _data;
        int _top;


        #endregion

        #region Public Properties

        public bool IsEmpty { get=>_top==0;}

        public int Length { get=>_top; }

        public bool IsFull { get=>_top==_data.Length; }
        #endregion

        #region Public Methods

        public static void Run()
        {
            var list = new StacksArray(5);
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(5);
            list.Display();
            list.Pop();
            list.Display();
            Console.WriteLine(list.Peek());
            list.Pop();
            list.Display();
            list.Pop();
            list.Display();
            list.Pop();
            list.Display();
            list.Pop();
            list.Display();
            list.Pop();
            list.Push(7);
            list.Push(8);
            list.Display();
        }

        public void Push(int element) 
        {
            if (IsFull)
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            _data[_top] = element;
            _top++;
        }

        public int Pop() 
        {
            int element;
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty");
                element= -1;
            }
            else
            {
                element = _data[_top - 1];
                _top--;
            }

            return element;
        }

        public int Peek() {
            
            int ret;
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty");
                ret= -1;
            }
            else
            {
                ret = _data[_top - 1];
            }

            return ret;
        }

        public void Display() 
        {
            for (int i = 0; i < _top; i++)
            {
                Console.WriteLine(_data[i]);
            }
            Console.WriteLine();
        }
        #endregion

    }
}
