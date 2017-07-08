using System;

namespace _01.People
{
    public class Person
    {
        private const int MinimumNameLength = 3;

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < MinimumNameLength)
                {
                    throw new ArgumentException($"Name's length should not be less than {MinimumNameLength} symbols!");
                }

                this.name = value;
            }
        }

        public virtual int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
