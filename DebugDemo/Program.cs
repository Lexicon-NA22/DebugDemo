using System;
using System.Linq;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //}

            int a = 50;
            int b = 50;

            int result = GetSum(a, b);

            Console.WriteLine(result);

            int result2 = 0;
            int[] manyNumbers = Enumerable.Range(1, 100).ToArray();

            for (int i = 0; i < manyNumbers.Length; i++)
            {
                result2 = i;
            }

        }

        private static int GetSum(int a, int b)
        {
            return a + b;
        }
    }
}
