using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double EUR = 1.95583;
            double USD = 1.79549;
            double GBP = 2.53405;
            var amount = double.Parse(Console.ReadLine());
            var inputCurr = "";
            do
            {
                inputCurr = Console.ReadLine();
            } while (inputCurr != "EUR" && inputCurr != "BGN" && inputCurr != "USD" && inputCurr != "GBP");        
            var outputCurr = "";
            do
            {
                outputCurr = Console.ReadLine();
            } while (outputCurr == inputCurr || (outputCurr != "EUR" && outputCurr != "BGN" && outputCurr != "USD" && outputCurr != "GBP"));
            switch (inputCurr)
            {
                case "BGN":
                    if (outputCurr == "EUR")
                    {
                        amount /= EUR;
                    }
                    else if (outputCurr == "USD")
                    {
                        amount /= USD;
                    }
                    else
                    {
                        amount /= GBP;
                    }
                    break;
                case "EUR":
                    if (outputCurr == "BGN")
                    {
                        amount *= EUR;
                    }
                    else if (outputCurr == "USD")
                    {
                        amount *= EUR / USD;
                    }
                    else 
                    {
                        amount *= EUR / GBP;
                    }
                    break;
                case "USD":
                    if (outputCurr == "EUR")
                    {
                        amount *= USD / EUR;
                    }
                    else if (outputCurr == "BGN")
                    {
                        amount *= USD;
                    }
                    else
                    {
                        amount *= USD / GBP;
                    }
                    break;
                case "GBP":
                    if (outputCurr == "BGN")
                    {
                        amount *= GBP;
                    }
                    else if (outputCurr == "EUR")
                    {
                        amount *= GBP / EUR;
                    }
                    else
                    {
                        amount *= GBP / USD;
                    }
                    break;
            }
            Console.WriteLine(Math.Round(amount, 2) + " " + outputCurr);
        }
    }
}
