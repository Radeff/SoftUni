using _11.InfernoInfinity.Gems;

namespace _11.InfernoInfinity
{
    public class Axe : Weapon
    {
        public Axe(string name, string rarity) : base(name, rarity)
        {
            this.Sockets = new Gem[4];
            base.MaxDamage = 10;
            base.MinDamage = 5;
        }
    }
}