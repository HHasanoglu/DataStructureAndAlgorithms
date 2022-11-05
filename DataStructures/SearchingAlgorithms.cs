using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class SearchingAlgorithms
    {
        public static void Run()
        {
            var index = LinearSearch(new int[5] {20,30,4,6,78 },100);
            Console.WriteLine(index);
        }

        private static int LinearSearch(int[] array,int key) 
        {
            var index = 0;
            while (index<array.Length)
            {
                if (array[index] == key) return index;
                index++;
            }

            return -1;
        } 
    }
}
