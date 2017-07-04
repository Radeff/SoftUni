using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.badges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
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

        public int Badges
        {
            get { return this.badges; }
        }

        public void AddBadge()
        {
            this.badges++;
        }

        internal void RemoveDead()
        {
            if (this.pokemons.Count > 0 && this.pokemons.FirstOrDefault(p => p.Health <= 0) != null)
            {
                this.pokemons = new List<Pokemon>(this.pokemons.Where(p => p.Health > 0));
            }
        }
    }
}
