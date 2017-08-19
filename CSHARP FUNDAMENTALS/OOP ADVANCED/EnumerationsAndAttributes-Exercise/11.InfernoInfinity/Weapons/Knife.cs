using _11.InfernoInfinity.Gems;

namespace _11.InfernoInfinity
{
    public class Knife : Weapon
    {
        public Knife(string name, string rarity) : base(name, rarity)
        {
            this.Sockets = new Gem[2];
            base.MaxDamage = 4;
            base.MinDamage = 3;
        }
    }
}