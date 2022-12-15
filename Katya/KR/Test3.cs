using System;

namespace test_Danya
{
    class Prog
    {
        static void Main(string[] args)
        {
            double[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
            int n = a.Length;

            a[0] = (a[0] + a[1]) / 2;

            for(int i = 1; i < n - 1; i++)
            {
                a[i] = (a[i - 1] + 2 * a[i] + a[i + 1]) / 4;
            }

            a[n - 1] = a[n - 2] + a[n - 1];

            for(int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }

            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}

