using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var check = Convert.ToBoolean(str);
            if (check)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
