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
            int[] a = new int[n];

            for(int i = 0; i < n; i++)
            {
                a[i] = rand.Next(-9, 10);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // TODO: сумму элементов массива с нечетными номерами;

            int sum = 0;
            for(int i = 1; i < n; i += 2)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);

            // TODO: сумму элементов массива, расположенных между
            //       первым и последним отрицательными элементами.

            int first = 0, last = n - 1;

            for(int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    first = i;
                    break;
                }
            }

            for(int i = n - 1; i > 0; i--)
            {
                if (a[i] < 0)
                {
                    last = i;
                    break;
                }
            }

            sum = 0;
            for(int i = first + 1; i < last; i++)
            {
                sum += a[i];
            }

            Console.WriteLine(sum);

            // TODO: Сжать массив, удалив из него все элементы,
            //       модуль которых не превышает единицу.
            //       Освободившиеся в конце массива элементы
            //       заполнить нулями.

            int count = 0;
            for(int i = 0; i < n - count; i++)
            {
                if (Math.Abs(a[i]) <= 1)
                {
                    a[i] = 0;
                    for(int j = i; j < n - count - 1; j++)
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                    count++;
                    i--;
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}