using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class SortingAlgorithms
    {
        public static void Run()
        {
            var numbers = new int[] { 3,5,8,2,6,9};
            Console.WriteLine(string.Join(",", numbers));

            //var result = SelectionSort(numbers);
            //Console.WriteLine(string.Join("\n", result));

            //var result = InsertionSort(numbers);
            //Console.WriteLine(string.Join(",", result));

            //var result = BubbleSort(numbers);
            //Console.WriteLine(string.Join(",", result));

            // var result = ShellSort(numbers);
            //Console.WriteLine(string.Join(",", result));

            var result = MergeSort(numbers,0,numbers.Length-1);
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

        private static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j+1]<arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }

            }
            return arr;
        }

        private static int[] ShellSort(int[] arr)
        {
            int n = arr.Length;
           var length = arr.Length;

            for (int gap = n/2; gap>0; gap/=2)
            {
                for (int i = gap ; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i - gap;
                    while (j>=0 && arr[j]>temp)
                    {
                        arr[j+gap] = arr[j];
                        j = j - gap;
                    }
                    arr[j + gap] = temp;
                }
            }

            return arr;
        }

        private static int[] MergeSort(int[] arr,int left,int right)
        {
            if (left<right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }

            return arr;
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            var i = left;
            var j = mid +1;
            var k = right;
            var B = new int[arr.Length];
            while (i<=mid && j<=right)
            {
                if (arr[i]<arr[j])
                {
                    B[k] = arr[i];
                    i += 1;
                }
                else
                {
                    B[k] = arr[j];
                    j += 1;
                }
                k += 1;
            }
            while (i <= mid)
            {
                B[k] = arr[i];
                i += 1;
                k += 1;
            }
            while (j <= right)
            {
                B[k] = arr[j];
                j += 1;
                k += 1;
            }

            for (int p = 0; p < B.Length; p++)
            {
                arr[p] = B[p];
            }
        }


        #endregion

    }
}
