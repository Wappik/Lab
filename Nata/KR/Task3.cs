using System;

namespace Mati
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int n = int.Parse(token[0]), m = int.Parse(token[1]);
            int[,] a = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                for (int j = 0; j < str.Length; j++)
                {
                    a[i, j] = Convert.ToInt32(str[j]);
                }
            }

            int min = a[0, 0], minIndex = 0; // a[строка, столбец]

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                        minIndex = j;
                    }
                }
            }

            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (a[j, minIndex] > a[j + 1, minIndex])
                    {
                        int temp = a[j, minIndex];
                        a[j, minIndex] = a[j + 1, minIndex];
                        a[j + 1, minIndex] = temp;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}