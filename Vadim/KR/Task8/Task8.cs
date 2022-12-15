using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace test_Vadim
{
    class Prog
    {
        private static string path = "/Users/eduard/Projects/test_Vitya/test_Vitya/";

        static void Main(string[] args)
        {
            writeFile("g.txt", createLine(File.ReadAllText(path + "f.txt")));
            Console.ReadKey();
        }

        static string createLine(string a)
        {
            string b = "";
            if (a[1] == 'a')
            {
                b += a[0];
            }
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i - 1] == 'a' || a[i + 1] == 'a')
                {
                    b += a[i];
                }
            }
            return b;
        }

        static void writeFile(string file, string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path + file);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        
    }
}

