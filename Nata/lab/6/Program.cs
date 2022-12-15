using System;

namespace Nata
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: создание массива

            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] a = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(-9, 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            // TODO: произведение элементов в тех строках, которые
            //       не содержат отрицательных элементов

            for(int i = 0; i < n; i++)
            {
                bool isNegative = false;
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        isNegative = true;
                        break;
                    }
                }

                if(!isNegative)
                {
                    int composition = 1;
                    for (int j = 0; j < n; j++)
                    {
                        composition *= a[i, j];
                    }
                    Console.WriteLine($"Строка {i}: {composition}");
                }
            }

            // TODO: максимум среди сумм элементов диагоналей,
            //       параллельных главной диагонали матрицы.

            int[] sumDiagonals1 = new int[n - 1];
            int[] sumDiagonals2 = new int[n - 1];

            for(int i = 1; i < n; i++)
            {
                for(int j = 0; j < n - i; j++)
                {
                    sumDiagonals1[i - 1] += a[i + j, j];
                    sumDiagonals2[i - 1] += a[j, i + j];
                }
            }
            int max1 = sumDiagonals1[0], max2 = sumDiagonals2[0];
            for(int i = 1; i < n - 1; i++)
            {
                if(max1 < sumDiagonals1[i])
                {
                    max1 = sumDiagonals1[i];
                }
            }

            for (int i = 1; i < n - 1; i++)
            {
                if (max2 < sumDiagonals2[i])
                {
                    max2 = sumDiagonals2[i];
                }
            }

            Console.WriteLine(Math.Max(max1, max2));

            Console.ReadLine();
        }
    }
}