using System;

namespace Mati
{
    class Program
    {
        static void randomValues(int[] x, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                x[i] = rand.Next(-10, 10);
        }

        static void print(int[] x, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{x[i]} ");
            Console.WriteLine();
        }

        static void falseOut(bool[] isX, int n)
        {
            for (int i = 0; i < n; i++)
            {
                isX[i] = false;
            }
        }

        static void repeatCheck(int[] x, bool[] isX, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x[i] == x[j] && i != j)
                    {
                        isX[i] = isX[j] = true;
                    }
                }
            }
        }

        static void seal(List<int> a, int[] x, bool[] isX, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (isX[i])
                {
                    a.Add(x[i]);
                }
            }
        }

        static void outputCompacted(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        static void Main()
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            //int n = 10;
            //int[] x = new int[10] { 0, 1, 1, 2, 3, 1, 2, 3, 4, 5};
            randomValues(x, n);
            bool[] isX = new bool[n];
            falseOut(isX, n);
            print(x, n);
            repeatCheck(x, isX, n);
            List<int> a = new List<int>();
            seal(a, x, isX, n);
            outputCompacted(a);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
