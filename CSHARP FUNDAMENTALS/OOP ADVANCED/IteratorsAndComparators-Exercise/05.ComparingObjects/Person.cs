using System;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person otherPerson)
        {
            var result = this.Name.CompareTo(otherPerson.Name);
            if (result == 0)
            {
                result = this.Age - otherPerson.Age;
                if (result == 0)
                {
                    result = this.Town.CompareTo(otherPerson.Town);
                }
            }
            return result;
        }
    }
}