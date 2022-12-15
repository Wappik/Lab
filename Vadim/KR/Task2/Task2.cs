using System;
using System.Text;
using Internal;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = a.Length;

            bubbleSort(a, n); // вызываем метод пузырьковой сортировки
                              // нагляднее: https://www.youtube.com/watch?v=5JMInXAtnQg&t=217s
            printArray(a, n);
            Console.ReadKey();
        }

        static void bubbleSort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    /* суть пузрьковой сортировки в том что мы проходим по массиву проверяя нынешний и следующий
                     * элементы, если нынешний больше чем следующий, меняем их местами
                     */
                    if (a[j] > a[j + 1])
                    {
                        // замена значений через 3ю переменную, можешь так и гуглить
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void printArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} "); // выводим получившийся массив через пробел 
            }
        }
    }
}