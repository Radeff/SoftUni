using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhonebookUpgrade
{
    public class Program
    {
        public static void Main()
        {
            var input = new string[1];

            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                input = Console.ReadLine().Split(' ').ToArray();
                ManipulatePhonebook(phonebook, input);
            }
        }

        public static void ManipulatePhonebook(SortedDictionary<string, string> phonebook, string[] input)
        {
            var command = input[0];

            if (command == "A")
            {
                var name = input[1];
                var number = input[2];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, number);
                }
                else
                {
                    phonebook[name] = number;
                }
            }

            else if (command == "S")
            {
                var name = input[1];

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }

            else if (command == "ListAll")
            {
                foreach (var person in phonebook)
                {
                    Console.WriteLine($"{person.Key} -> {person.Value}");
                }
            }
        }
    }
}
