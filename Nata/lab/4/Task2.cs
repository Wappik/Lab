using System;

namespace Nata
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(Math.Pow(a, i) + " ");
            }

            Console.ReadKey();
        }
    }
}