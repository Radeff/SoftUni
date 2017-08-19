using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            var listPersons = new List<Person>();

            var inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                var inputParams = inputLine.Split();

                var currentPerson = new Person(
                    inputParams[0],
                    int.Parse(inputParams[1]),
                    inputParams[2]);

                listPersons.Add(currentPerson);

                inputLine = Console.ReadLine();
            }

            var number = int.Parse(Console.ReadLine());
            var personToCompare = listPersons[number - 1];
            var equals = listPersons.Count(p => p.CompareTo(personToCompare) == 0);
            var notEquals = listPersons.Count - equals;

            var result = $"{equals} {notEquals} {listPersons.Count}";
            if (equals < 2)
            {
                result = "No matches";
            }

            Console.WriteLine(result);
        }
    }
}
