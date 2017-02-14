using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var longer = new char[1];
            var shorter = new char[1];

            if (input[0].Length > input[1].Length)
            {
                longer = input[0].ToCharArray();
                shorter = input[1].ToCharArray();
            }

            else
            {
                longer = input[1].ToCharArray();
                shorter = input[0].ToCharArray();
            }

            var diff = longer.Length - shorter.Length;
            var map = new Dictionary<char, char>();

            for (int i = 0; i < shorter.Length; i++)
            {
                if (map.ContainsKey(shorter[i]) && !map[shorter[i]].Equals(longer[i]))
                {
                    Console.WriteLine("false");
                    return;
                }

                else if (map.ContainsKey(shorter[i]) && map[shorter[i]].Equals(longer[i]))
                {
                    continue;
                }

                else if (!map.ContainsKey(shorter[i]) && !map.Values.Any(x => x == longer[i]))
                {
                    map.Add(shorter[i], longer[i]);
                }

                else
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            if (diff != 0)
            {
                for (int i = longer.Length - diff; i < longer.Length; i++)
                {
                    if (map.Values.Any(x => x.Equals(longer[i])))
                    {
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            Console.WriteLine("true");
        }
    }
}
