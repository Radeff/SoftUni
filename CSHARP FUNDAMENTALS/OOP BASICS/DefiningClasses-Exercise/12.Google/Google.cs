using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Google
{
    public class Google
    {
        public static void Main()
        {
            var people = new List<Person>();
            var input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                var name = input[0];
                var person = people.FirstOrDefault(p => p.Name == name);

                if (person == null)
                {
                    person = new Person(name);
                    
                }

                switch (input[1])
                {
                    case "company":
                        var companyName = input[2];
                        var salary = decimal.Parse(input[4]);
                        var department = input[3];
                        person.AddCompany(new Company(companyName, salary, department));
                        break;

                    case "pokemon":
                        var pokemonName = input[2];
                        var type = input[3];
                        person.AddPokemon(new Pokemon(pokemonName, type));
                        break;

                    case "parents":
                        var parentName = input[2];
                        var parentBirthday = input[3];
                        person.AddParent(new Parent(parentName, parentBirthday));
                        break;

                    case "children":
                        var childName = input[2];
                        var childBirthday = input[3];
                        person.AddChild(new Child(childName, childBirthday));
                        break;

                    case "car":
                        var model = input[2];
                        var speed = int.Parse(input[3]);
                        person.AddCar(new Car(model, speed));
                        break;
                }

                people.Add(person);

                input = Console.ReadLine().Split();
            }

            var nameToFind = Console.ReadLine();
            var personFound = people
                .FirstOrDefault(p => p.Name == nameToFind);

            if (personFound != null)
            {
                Console.Write(personFound.ToString());
            }
        }
    }
}
