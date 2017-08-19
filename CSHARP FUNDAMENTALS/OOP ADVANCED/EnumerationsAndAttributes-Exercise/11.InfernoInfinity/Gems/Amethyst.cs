namespace _11.InfernoInfinity.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(string clarity) : base(clarity)
        {
            this.Strength = 2 + base.Bonus;
            this.Agility = 8 + base.Bonus;
            this.Vitality = 4 + base.Bonus;
        }
    }
}