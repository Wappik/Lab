using System;

namespace Mati
{
    class Program
    {
        static void replacement(int[] x, int n, bool isEven)
        {
            for (int i = 0; i < n; i++)
                if ((x[i] % 2 == 0) == isEven)
                    x[i] = -x[i];
        }

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

        static void Main()
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            randomValues(x, n);
            print(x, n);
            Console.WriteLine("Максимальное число в массиве: " + x.Max());
            replacement(x, n, (x.Max() % 2 == 0) ? true : false);
            print(x, n);
            Console.ReadKey();
        }
    }
}
