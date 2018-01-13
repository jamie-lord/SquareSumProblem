using System;
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

        private static void Permutations(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                {
                    Console.Write($"{list[i]} ");
                }
                Console.Write("\n");
            }
            else
                for (i = k; i <= m; i++)
                {
                    SwapTwoNumbers(ref list[k], ref list[i]);
                    Permutations(list, k + 1, m);
                    SwapTwoNumbers(ref list[k], ref list[i]);
                }
        }
    }
}
