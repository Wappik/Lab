using System;
using System.Collections.Generic;
using System.Text;

namespace test_Vadim
{
    class Prog
    {
        static void Main(string[] args)
        {
            string a =
@"#include<iostream>
using namespace std;

int main() {
    cout << ""Привет мир"" << endl;
    return 0;
}";
            string[] str = a.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] dictionary = new string[]
                {"include", "iostream", "using", "namespace", "int", "main", "cout", "endl", "return"};

            lowerAllEnglishChar(str);
            upperByDictionary(str, dictionary);
            print(str);

            Console.ReadKey();
        }

        static void print(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }

        static void lowerAllEnglishChar(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if ((int)str[i][j] < 1040 || (int)str[i][j] > 1103)
                    {
                        StringBuilder s = new StringBuilder(str[i]);
                        s[j] = Convert.ToChar(Convert.ToString(str[i][j]).Substring(0, 1).ToLower());
                        str[i] = s.ToString();
                    }
                }
            }
        }

        static void upperByDictionary(string[] str, string[] dictionary)
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    string low = dictionary[i].Substring(0, dictionary[i].Length).ToLower();
                    string up = dictionary[i].Substring(0, dictionary[i].Length).ToUpper();
                    str[j] = str[j].Replace(low, up);
                }
            }
        }


    }
}

