using System;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var nameSet = new SortedSet<Person>(new NameComparator());

            // var nameSet = new List<Person>();
            // nameSet.Sort(new NameComparator());
            // ------------------------------------------
            // var nameSet = new Person[5];
            // Array.Sort(nameSet, new AgeComparator());

            var ageSet = new SortedSet<Person>(new AgeComparator());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var person = new Person(input[0], int.Parse(input[1]));
                nameSet.Add(person);
                ageSet.Add(person);
            }

            

            foreach (var person in nameSet)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            foreach (var person in ageSet)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
