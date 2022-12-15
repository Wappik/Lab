using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            randomValues(a, n);
            print(a, n);
            sortMatrix(a, n);
            Console.WriteLine();
            print(a, n);
            Console.ReadKey();
        }

        static void print(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void randomValues(int[,] a, int n)
        {
            Random rand = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            }
        }

        static void sortMatrix(int[,] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[0, j] > a[0, j + 1])
                    {
                        for (int k = 0; k < n; k++)
                        {
                            int temp = a[k, j];
                            a[k, j] = a[k, j + 1];
                            a[k, j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}

