using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class SortingAlgorithms
    {
        public static void Run()
        {
            var numbers = new int[] { 20, 45, 61, 45, 34};
            Console.WriteLine(string.Join(",", numbers));

            //var result = SelectionSort(numbers);
            //Console.WriteLine(string.Join("\n", result));

            var result = InsertionSort(numbers);
            Console.WriteLine(string.Join(",", result));
        }

        #region Unstable Sorting

        private static int[] SelectionSort(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var position = i;
                for (int j = i+1; j < arr.Length; j++)
                    if (arr[j]< arr[position])
                        position = j;
                
                var temp = arr[i];
                arr[i] = arr[position];
                arr[position] = temp;
            }
            return arr;
        }

        #endregion

        #region Stable Sorting

        private static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var IValue = arr[i];
                int j = i;
                while (j>0 && IValue< arr[j-1])
                {
                    arr[j] = arr[j-1];
                    j = j - 1;
                }
                arr[j] = IValue;
                //for (int j = i ; j > 0; j--)
                //{
                //    if (arr[j] < arr[j-1]) 
                //    {
                //        var temp = arr[j];
                //        arr[j] = arr[j-1];
                //        arr[j-1] = temp;
                //    }
                //}

            }
            return arr;
        }

        #endregion

    }
}
