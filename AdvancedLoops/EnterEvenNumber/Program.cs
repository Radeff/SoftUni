using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
                do
                {
                    Console.Write("Enter even number: ");
                    try
                    {
                       n = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                    if (n % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                } while (n % 2 != 0 || n == 0);
                Console.WriteLine("Even number entered: {0}", n);          
        }
    }
}
