using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int k = int.Parse(tokens[0]), l = int.Parse(tokens[1]);
            int[,] a = new int[k, l];
            int[] newA = new int[k * l];
            randomValues(a, k, l);
            printMatrix(a, k, l);
            int count = createArray(a, newA, k, l);

            Console.WriteLine();

            printArray(newA, count);

            Console.ReadKey();
        }

        static bool isZero(int a) { return a == 0; }

        static void printArray(int[] a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void printMatrix(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void randomValues(int[,] a, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rand.Next(0, 10);
                }
            }
        }

        static int createArray(int[,] a, int[] newA, int n, int m)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!isZero(a[i, j]))
                    {
                        newA[count] = a[i, j];
                        count++;
                    }
                }
            }
            return count;
        }
    }
}

