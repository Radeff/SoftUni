using System.Linq;
using _11.InfernoInfinity.Gems;

namespace _11.InfernoInfinity
{
    public class Weapon
    {
        private int minDamage;
        private int maxDamage;

        public Weapon()
        {

        }
        public Weapon(string name, string rarity)
        {
            switch (rarity)
            {
                case "Uncommon":
                    this.BonusDamage = 2;
                    break;
                case "Rare":
                    this.BonusDamage = 3;
                    break;
                case "Epic":
                    this.BonusDamage = 5;
                    break;
                case "Common":
                    this.BonusDamage = 1;
                    break;
            }

            this.Name = name;
            this.Rarity = rarity;
        }

        public string Name { get; protected set; }

        public int Strength
        {
            get
            {
                return Sockets.Where(gem => gem != null).Sum(gem => gem.Strength);
            }
            protected set
            {
                this.Strength = value;
            }
        }

        public int Agility
        {
            get
            {
                return this.Sockets.Where(gem => gem != null).Sum(gem => gem.Agility);
            }
            protected set
            {
                this.Agility = value;
            }
        }

        public int Vitality
        {
            get
            {
                return Sockets.Where(gem => gem != null).Sum(gem => gem.Vitality);
            }
            protected set
            {
                this.Vitality = value;
            }
        }

        public int MinDamage
        {
            get
            {
                return minDamage * this.BonusDamage + this.Strength * 2 + this.Agility;
            }
            protected set
            {
                minDamage = value;
            }
        }

        public int MaxDamage
        {
            get
            {
                return maxDamage * this.BonusDamage + this.Strength * 3 + this.Agility * 4;
            }
            protected set
            {
                maxDamage = value;
            }
        }

        public string Rarity { get; protected set; }

        public Gem[] Sockets { get; protected set; }

        public int BonusDamage { get; protected set; }
    }
}