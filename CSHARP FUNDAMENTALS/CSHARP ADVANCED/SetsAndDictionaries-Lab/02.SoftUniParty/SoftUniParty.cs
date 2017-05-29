using System;
using System.Collections.Generic;

namespace _02.SoftUniParty
{
    public class SoftUniParty
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var guests = new SortedSet<string>();

            while (input != "PARTY")
            {
                guests.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                guests.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
