using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('-').ToArray();
            var phonebook = new Dictionary<string, string>();

            while (input[0] != "search")
            {
                var name = input[0];
                var number = input[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, number);
                }
                else
                {
                    phonebook[name] = number;
                }

                input = Console.ReadLine().Split('-').ToArray();
            }

            var nameSearch = Console.ReadLine();

            while (nameSearch != "stop")
            {
                if (phonebook.ContainsKey(nameSearch))
                {
                    Console.WriteLine($"{nameSearch} -> {phonebook[nameSearch]}");
                }
                else
                {
                    Console.WriteLine($"Contact {nameSearch} does not exist.");
                }

                nameSearch = Console.ReadLine();
            }
        }
    }
}
