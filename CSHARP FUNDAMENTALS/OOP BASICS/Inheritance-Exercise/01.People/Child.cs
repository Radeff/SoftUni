﻿using System;

namespace _01.People
{
    public class Child : Person
    {
        private const int MaxAge = 15;

        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get { return base.Age; }

            set
            {
                if (value > MaxAge)
                {
                    throw new ArgumentException($"Child's age must be less than {MaxAge}!");
                }

                base.Age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
