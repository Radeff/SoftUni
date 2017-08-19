using System.Collections.Generic;

public class Recipe : IRecipe
{
    public Recipe(string name, IList<string> requiredItems, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus)
    {
        this.Name = name;
        this.RequiredItems = requiredItems;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
    }

    public string Name { get; }
    public IList<string> RequiredItems { get; }
    public long StrengthBonus { get; }
    public long AgilityBonus { get; }
    public long IntelligenceBonus { get; }
    public long HitPointsBonus { get; }
    public long DamageBonus { get; }
}