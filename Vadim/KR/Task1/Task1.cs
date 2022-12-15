using System;
using System.Text;

namespace Task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = a.Length;
            int max = a[0], maxIndex = 0, min = a[0], minIndex = 0;
            searchingForValues(a, n, max, min, ref maxIndex, ref minIndex);
            actionsWithARange(a, minIndex, maxIndex); 
            printArray(a, n);
            Console.ReadKey();
        }

        static void searchingForValues(int[] a, int n, int max, int min, ref int maxIndex, ref int minIndex)
        {
            for (int i = 1; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    maxIndex = i;
                }

                if (min > a[i])
                {
                    min = a[i];
                    minIndex = i;
                }
            }
        }

        static void actionsWithARange(int[] a, int minIndex, int maxIndex)
        {
            for (int i = ((minIndex < maxIndex) ? minIndex : maxIndex) + 1; i < ((minIndex < maxIndex) ? maxIndex : minIndex); i++)
            {
                a[i] *= 2;
            }
        }

        static void printArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}