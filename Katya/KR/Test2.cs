using System;

namespace test_Danya
{
    class Prog
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] arr = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i];
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (arr[i] != a[i])
                {
                    Console.Write($"{a[i]} ");
                }
            }

            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}

