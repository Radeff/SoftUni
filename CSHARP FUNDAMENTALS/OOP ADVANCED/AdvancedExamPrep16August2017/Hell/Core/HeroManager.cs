using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HeroManager : IManager
{
    private Dictionary<string, IHero> heroes;

    public HeroManager()
    {
        this.heroes = new Dictionary<string, IHero>();
    }

    public string AddHero(IList<string> arguments)
    {
        string result = null;
        string heroName = arguments[0];
        string heroType = arguments[1];

        try
        {
            Type clazz = Type.GetType(heroType);
            var constructors = clazz.GetConstructors();
            IHero hero = (IHero)constructors[0].Invoke(new object[] { heroName });
            this.heroes.Add(hero.Name, hero);

            result = string.Format($"Created {heroType} - {hero.Name}");
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return result;
    }

    public string AddItem(IList<string> arguments)
    {
        string result = null;
        var itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        IItem newItem = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
            damageBonus);
        this.heroes[heroName].AddItem(newItem);

        result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);
        return result;
    }



    public string Quit(IList<string> argsList)
    {
        var sb = new StringBuilder();
        var sortedHeroes = this.heroes.OrderByDescending(h => h.Value.PrimaryStats)
            .ThenByDescending(h => h.Value.SecondaryStats);
        var counter = 1;
        foreach (var kvp in sortedHeroes)
        {
            sb.AppendLine($"{counter++}. {kvp.Value.GetType().Name}: {kvp.Value.Name}");
            sb.AppendLine($"###HitPoints: {kvp.Value.HitPoints}");
            sb.AppendLine($"###Damage: {kvp.Value.Damage}");
            sb.AppendLine($"###Strength: {kvp.Value.Strength}");
            sb.AppendLine($"###Agility: {kvp.Value.Agility}");
            sb.AppendLine($"###Intelligence: {kvp.Value.Intelligence}");

            if (kvp.Value.Items.Count == 0)
            {
                sb.AppendLine("###Items: None");
            }
            else
            {
                sb.AppendLine("###Items: " + string.Join(", ", kvp.Value.Items.Select(i => i.Name)));
            }
        }
        return sb.ToString().Trim();
    }

    public string AddRecipe(IList<string> arguments)
    {
        string result = null;

        var itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);
        var requiredItems = arguments.Skip(7).ToList();

        IRecipe newRecipe = new Recipe(itemName, requiredItems, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus);
        this.heroes[heroName].AddRecipe(newRecipe);

        result = string.Format(Constants.RecipeCreatedMessage, newRecipe.Name, heroName);
        return result;
    }

    public string Inspect(IList<string> arguments)
    {
        string heroName = arguments[0];
        return this.heroes[heroName].ToString();
    }
}