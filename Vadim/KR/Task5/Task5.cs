using System;

namespace test_Vadim
{
    class Prog
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            // A : sada : asdasd ; asdfas.
            int count = countChar(a);
            Console.WriteLine(a.Replace(':', ';'));
            Console.WriteLine(count);
            Console.ReadKey();
        }

        static int countChar(string a)
        {
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == ':')
                {
                    count++;
                }
            }
            return count;
        }
    }
}

