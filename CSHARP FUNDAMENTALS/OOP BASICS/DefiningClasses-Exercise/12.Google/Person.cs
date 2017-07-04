using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;

        public Person(string name)
        {
            this.Name = name;
            this.pokemons = new List<Pokemon>();
            this.parents = new List<Parent>();
            this.children = new List<Child>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public void AddCompany(Company company)
        {
            this.company = company;
        }

        public void AddCar(Car car)
        {
            this.car = car;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void AddParent(Parent parent)
        {
            this.parents.Add(parent);
        }

        public void AddChild(Child child)
        {
            this.children.Add(child);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.name);

            sb.AppendLine("Company:");
            if (this.company != null)
            {
                sb.AppendLine(this.company.ToString());
            }

            sb.AppendLine("Car:");
            if (this.car != null)
            {
                sb.AppendLine(this.car.ToString());
            }

            sb.AppendLine("Pokemon:");
            if (this.pokemons.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.pokemons.Select(p => p.ToString())));
            }

            sb.AppendLine("Parents:");
            if (this.parents.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.parents.Select(p => p.ToString())));
            }

            sb.AppendLine("Children:");
            if (this.children.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.children.Select(c => c.ToString())));
            }

            return sb.ToString();
        }
    }
}
