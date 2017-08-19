public class Barbarian : AbstractHero
{
    public const long DefaultStrength = 90;
    public const long DefaultAgility = 25; 
    public const long DefaultIntelligence = 10;
    public const long DefaultHitPoints = 350;
    public const long DefaultDamage = 150;

    public Barbarian(string name) 
        : base(name, DefaultStrength, DefaultAgility, DefaultIntelligence, DefaultHitPoints, DefaultDamage)
    {
    }
}
