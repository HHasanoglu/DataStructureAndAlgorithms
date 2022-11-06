using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class SearchingAlgorithms
    {
        public static void Run()
        {
            var index = LinearSearch(new int[5] {20,30,4,6,78 },20);
            Console.WriteLine(index);
            
            index = BinarySearch(new int[5] {4,11,18,30,54 },30);
            Console.WriteLine(index);


            index = BinarySearchRecursive(new int[5] {4,11,18,30,54 },54,0,4);
            Console.WriteLine(index);




        }

        private static int LinearSearch(int[] array,int Value) 
        {
            var index = 0;
            while (index<array.Length)
            {
                if (array[index] == Value) return index;
                index++;
            }

            return -1;
        }

        private static int BinarySearch(int[] array, int Value) 
        {
            int LValue = 0;
            int RValue = array.Length-1;
          
            while (LValue <= RValue)
            {
                int index = (LValue + RValue) / 2;
                if (array[index]==Value)
                {
                    return index;
                }
                else if (Value>array[index] )
                {
                    LValue = index+1;
                }
                else 
                {
                    RValue = index-1;
                }
            }
            return -1;
        }

        private static int BinarySearchRecursive(int[] array, int Value,int LValue,int RValue)
        {

            if (LValue <= RValue)
            {
                int index = (LValue + RValue) / 2;
                if (array[index] == Value)
                {
                    return index;
                }
                else if (Value > array[index])
                {
                    return BinarySearchRecursive(array, Value, index + 1, RValue);
                }
                else
                {
                    return BinarySearchRecursive(array, Value, RValue, index - 1);
                }
            }
            return -1;
        }
    }
}
