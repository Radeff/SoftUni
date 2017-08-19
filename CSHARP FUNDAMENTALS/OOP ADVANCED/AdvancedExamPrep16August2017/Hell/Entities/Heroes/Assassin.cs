
public class Assassin : AbstractHero
{
    public const long DefaultStrength = 25;
    public const long DefaultAgility = 100;
    public const long DefaultIntelligence = 15;
    public const long DefaultHitPoints = 150;
    public const long DefaultDamage = 300;

    public Assassin(string name) 
        : base(name, DefaultStrength, DefaultAgility, DefaultIntelligence, DefaultHitPoints, DefaultDamage)
    {
    }
}
