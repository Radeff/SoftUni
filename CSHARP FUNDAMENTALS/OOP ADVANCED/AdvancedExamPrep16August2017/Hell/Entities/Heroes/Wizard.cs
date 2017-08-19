public class Wizard : AbstractHero
{
    public const long DefaultStrength = 25;
    public const long DefaultAgility = 25;
    public const long DefaultIntelligence = 100;
    public const long DefaultHitPoints = 100;
    public const long DefaultDamage = 250;


    public Wizard(string name) 
        : base(name, DefaultStrength, DefaultAgility, DefaultIntelligence, DefaultHitPoints, DefaultDamage)
    {
    }
}
