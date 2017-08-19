using _11.InfernoInfinity.Gems;

namespace _11.InfernoInfinity
{
    public class Sword : Weapon

    {
        public Sword(string name, string rarity) : base(name, rarity)
        {
            this.Sockets = new Gem[3];
            base.MaxDamage = 6;
            base.MinDamage = 4;
        }
    }
}