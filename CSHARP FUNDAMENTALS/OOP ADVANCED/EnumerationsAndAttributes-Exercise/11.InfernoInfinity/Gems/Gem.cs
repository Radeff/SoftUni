namespace _11.InfernoInfinity.Gems
{
    public class Gem
    {
        public Gem()
        {
            
        }

        public Gem(string clarity)
        {
            switch (clarity)
            {
                case "Chipped":
                    this.Bonus = 1;
                    break;
                case "Regular":
                    this.Bonus = 2;
                    break;
                case "Perfect":
                    this.Bonus = 5;
                    break;
                case "Flawless":
                    this.Bonus = 10;
                    break;
            }
        }

        public int Strength { get; protected set; }

        public int Agility { get; protected set; }

        public int Vitality { get; protected set; }

        public int Bonus { get; protected set; }
    }
}