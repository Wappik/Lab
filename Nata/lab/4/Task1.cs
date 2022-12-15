using System;

namespace Nata
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 100; i++)
            {
                if((((i % 10) * (i % 10)) + ((i / 10) * (i / 10))) % 13 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}