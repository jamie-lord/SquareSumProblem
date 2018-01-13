using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareSumProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            var array = CreateStaringArray(15);

            Permutations(array, 0, array.Length - 1);
        }

        private static int[] CreateStaringArray(int length)
        {
            return Enumerable.Range(1, length).ToArray();
        }

        private static void SwapTwoNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static List<int[]> _results = new List<int[]>();

        private static void Permutations(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                if (IsListOrderCorrect(ref list))
                {
                    for (i = 0; i <= m; i++)
                    {
                        Console.Write($"{list[i]} ");
                    }
                    Console.Write("\n");

                    _results.Add(list);
                }
            }
            else
                for (i = k; i <= m; i++)
                {
                    SwapTwoNumbers(ref list[k], ref list[i]);
                    Permutations(list, k + 1, m);
                    SwapTwoNumbers(ref list[k], ref list[i]);
                }
        }

        private static bool IsListOrderCorrect(ref int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (!SumIsSquare(ref list[i], ref list[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }
            

        private static bool SumIsSquare(ref int i, ref int j)
        {
            return Math.Sqrt(i + j) % 1 == 0;
        }
    }
}
