namespace _11.InfernoInfinity.Gems
{
    public class Ruby : Gem
    {
        public Ruby(string clarity) : base(clarity)
        {
            this.Strength = 7 + base.Bonus;
            this.Agility = 2 + base.Bonus;
            this.Vitality = 5 + base.Bonus;
        }
    }
}