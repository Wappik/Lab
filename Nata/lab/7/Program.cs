using System;

namespace Nata
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string s = "";
            for(int i = 0; i < a.Length - 1; i++)
            {
                s += a[i];
            }

            int intValue;

            if (int.TryParse(s, out intValue))
            {
                Console.WriteLine($"Yes: {intValue}");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadLine();
        }
    }
}