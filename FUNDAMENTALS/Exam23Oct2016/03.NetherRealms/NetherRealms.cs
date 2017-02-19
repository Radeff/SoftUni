using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    public class NetherRealms
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ,\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var demons = new SortedDictionary<string, double>();

            foreach (var name in input)
            {
                var damage = 0.0;
                var numberPattern = new Regex(@"[-+]*\d*[.]*\d+");
                var numbersInName = numberPattern.Matches(name);
                var modifierPattern = new Regex(@"[*\/]");
                var modifersInName = modifierPattern.Matches(name);

                foreach (Match number in numbersInName)
                {
                    damage += double.Parse(number.Value);
                }                

                foreach (Match modifier in modifersInName)
                {
                    if (modifier.Value == "/")
                    {
                        damage /= 2.0;
                    }

                    else
                    {
                        damage *= 2.0;
                    }
                }

                demons.Add(name, damage);
            }

            foreach (var demon in demons)
            {                
                var health = 0;
                var symbolsPattern = new Regex(@"[^0-9+\-.\/*]");
                var symbolsInName = symbolsPattern.Matches(demon.Key);

                foreach (Match symbol in symbolsInName)
                {
                    health += symbol.Value[0];
                }

                Console.WriteLine($"{demon.Key} - {health} health, {demon.Value:F2} damage");
            }
        }
    }
}
