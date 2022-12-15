using System;

namespace Nata
{
    class Program
    {
        static bool isHappy(int i)
        {
            return (((i % 10) * (i % 10)) + ((i / 10) * (i / 10))) % 13 == 0;
        }

        static void enumeration()
        {
            for (int i = 10; i < 100; i++)
            {
                if (isHappy(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            enumeration();
            Console.ReadKey();
        }
    }
}