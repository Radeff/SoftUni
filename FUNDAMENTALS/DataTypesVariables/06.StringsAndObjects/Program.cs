using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            object obj = str1 + ' ' + str2;
            string str3 = (string)obj;
            Console.WriteLine(str3);
        }
    }
}
