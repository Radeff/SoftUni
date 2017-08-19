namespace _11.InfernoInfinity.Gems
{
    public class Emerald : Gem
    {
        public Emerald(string clarity) : base(clarity)
        {
            this.Strength = 1 + base.Bonus;
            this.Agility = 4 + base.Bonus;
            this.Vitality = 9 + base.Bonus;
        }
    }
}