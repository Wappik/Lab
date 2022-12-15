using System;

namespace test_Danya
{
    class Prog
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = 10000000;
            int[] arr = new int[n];

            for(int i = 0; i < a.Length; i++)
            {
                arr[a[i]]++;
            }
            int max = arr[0], maxIndex = 0;

            for(int i = 0; i < n; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine(maxIndex);
            Console.ReadKey();
        }
    }
}

