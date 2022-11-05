using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Recursion
    {
        public static void Run()
        {

            //var list = new List<int>();
            //CalculateHeadRecursive(6, ref list);
            //list.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();

            //list.Clear();
            //CalculateTailRecursive(6, ref list);
            //list.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();

            //list.Clear();
            //CalculateRecursiveTree(6, ref list);
            //list.ForEach(x => Console.WriteLine(x));

            //var sum = SumOfNNaturalFunctions(5);
            //Console.WriteLine(sum);
            
            var factorial = FactorialOfANumbber(5);
            Console.WriteLine(factorial);
        }


        private static List<int> CalculateIterative(int startingValue)
        {
            var result = new List<int>();
            while (startingValue>0)
            {
                result.Add(startingValue);
                startingValue--;

            }
            return result;
        }

        private static void CalculateHeadRecursive(int startingValue,ref List<int> list)
        {
            if (startingValue>0)
            {
                //Console.WriteLine(startingValue);
                CalculateHeadRecursive(startingValue - 1,ref list);
                list.Add(startingValue);
            }
        }

        private static void CalculateTailRecursive(int startingValue, ref List<int> list)
        {
            if (startingValue > 0)
            {
                //Console.WriteLine(startingValue);
                list.Add(startingValue);
                CalculateTailRecursive(startingValue - 1, ref list);
            }
        }

        private static void CalculateRecursiveTree(int startingValue, ref List<int> list)
        {
            if (startingValue > 0)
            {
                CalculateRecursiveTree(startingValue - 1, ref list);
                list.Add(startingValue);
                CalculateRecursiveTree(startingValue - 1, ref list);
            }
        }


        private static int SumOfNNaturalFunctions(int n) 
        {
            if (n == 1) return 1;
            return SumOfNNaturalFunctions(n - 1) + n*n;
        }

        private static int FactorialOfANumbber(int n)
        {
            if (n == 1) return 1;
            return FactorialOfANumbber(n - 1) * n ;
        }

    }
}
