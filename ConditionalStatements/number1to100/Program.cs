using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0._._._100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num < 0 || num > 100)
            {
                Console.Write("invalid number");
            }
            else
            {
                if (num == 100)
                {
                    Console.WriteLine("one hundred");
                }
                if (num == 0)
                {
                    Console.WriteLine("zero");
                }
                int tens = num / 10;
                int ones = num % 10;

                if (num == 1)
                {
                    Console.WriteLine("one");
                }
                if (num == 2)
                {
                    Console.WriteLine("two");
                }
                if (num == 3)
                {
                    Console.WriteLine("three");
                }
                if (num == 4)
                {
                    Console.WriteLine("four");
                }
                if (num == 5)
                {
                    Console.WriteLine("five");
                }
                if (num == 6)
                {
                    Console.WriteLine("six");
                }
                if (num == 7)
                {
                    Console.WriteLine("seven");
                }
                if (num == 8)
                {
                    Console.WriteLine("eight");
                }
                if (num == 9)
                {
                    Console.WriteLine("nine");
                }
                if (num == 10)
                {
                    Console.WriteLine("ten");
                }
                if (num == 11)
                {
                    Console.WriteLine("eleven");
                }
                if (num == 12)
                {
                    Console.WriteLine("twelve");
                }
                if (num == 13)
                {
                    Console.WriteLine("thirteen");
                }
                if (num == 14)
                {
                    Console.WriteLine("fourteen");
                }
                if (num == 15)
                {
                    Console.WriteLine("fifteen");
                }
                if (num == 16)
                {
                    Console.WriteLine("sixteen");
                }
                if (num == 17)
                {
                    Console.WriteLine("seventeen");
                }
                if (num == 18)
                {
                    Console.WriteLine("eighteen");
                }
                if (num == 19)
                {
                    Console.WriteLine("nineteen");
                }
                if (tens > 1)
                {
                    if (tens == 2)
                    {
                        Console.Write("twenty");
                    }
                    else if (tens == 3)
                    {
                        Console.Write("thirty");
                    }
                    else if (tens == 4)
                    {
                        Console.Write("fourty");
                    }
                    else if (tens == 5)
                    {
                        Console.Write("fifty");
                    }
                    else if (tens == 6)
                    {
                        Console.Write("sixty");
                    }
                    else if (tens == 7)
                    {
                        Console.Write("seventy");
                    }
                    else if (tens == 8)
                    {
                        Console.Write("eighty");
                    }
                    else if (tens == 9)
                    {
                        Console.Write("ninety");
                    }
                    if (ones == 1)
                    {
                        Console.WriteLine(" one");
                    }
                    else if (ones == 2)
                    {
                        Console.WriteLine(" two");
                    }
                    else if (ones == 3)
                    {
                        Console.WriteLine(" three");
                    }
                    else if (ones == 4)
                    {
                        Console.WriteLine(" four");
                    }
                    else if (ones == 5)
                    {
                        Console.WriteLine(" five");
                    }
                    else if (ones == 6)
                    {
                        Console.WriteLine(" six");
                    }
                    else if (ones == 7)
                    {
                        Console.WriteLine(" seven");
                    }
                    else if (ones == 8)
                    {
                        Console.WriteLine(" eight");
                    }
                    else if (ones == 9)
                    {
                        Console.WriteLine(" nine");
                    }
                }
            }
        }
    }
}
