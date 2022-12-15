using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace test_Vadim
{
    class Prog
    {
        static void Main(string[] args)
        {
            string path = "/Users/eduard/Projects/test_Vitya/test_Vitya/student.txt";
            string a = File.ReadAllText(path);
            check(a, "студент");
            Console.ReadKey();
        }

        static void check(string a, string b)
        {
            if (a.Contains(b))
            {
                Console.WriteLine("Содержит");
            }
            else
            {
                Console.WriteLine("Не содержит");
            }
        }
    }
}

