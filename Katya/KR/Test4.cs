using System;

namespace test_Danya
{
    class Prog
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int n = int.Parse(tokens[0]), m = int.Parse(tokens[1]);
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                for(int j = 0; j < m; j++)
                {
                    a[i, j] = arr[j];
                }
            }

            for(int j = 0; j < m; j++)
            {
                if (a[0, j] < 0)
                {
                    for(int i = 0; i < n; i++)
                    {
                        a[i, j] = a[i, j] * a[i, j];
                    }

                    int temp = a[0, j];

                    for(int i = 0; i < n; i++)
                    {
                        for(int k = 0; k < m; k++)
                        {
                            a[i, k] /= temp;
                        }
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
            }

            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}

