using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private BenderFactory benderFactory;
    private MonumentFactory monumentFactory;
    private Dictionary<string, List<Entity>> entities;
    private int counter;
    private StringBuilder warsRecord;

    public NationsBuilder()
    {
        this.benderFactory = new BenderFactory();
        this.monumentFactory = new MonumentFactory();
        this.entities = new Dictionary<string, List<Entity>>
        {
            { Constants.Air, new List<Entity>() },
            { Constants.Fire, new List<Entity>() },
            { Constants.Water, new List<Entity>() },
            { Constants.Earth, new List<Entity>() }
        };
        this.counter = Constants.DefaultCounter;
        this.warsRecord = new StringBuilder();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var special = double.Parse(benderArgs[3]);

        var bender = this.benderFactory.AddBender(type, name, power, special);
        this.entities[type].Add(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        var monument = this.monumentFactory.AddMonument(type, name, affinity);
        this.entities[type].Add(monument);
    }

    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
        var filteredNation = this.entities[nationsType];
        var benderType = typeof(Bender);
        var monumentType = typeof(Monument);

        this.OutputBuilder(sb, filteredNation, benderType);
        this.OutputBuilder(sb, filteredNation, monumentType);

        return sb.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        var warResult = new Dictionary<string, double>();

        foreach (var kvp in this.entities)
        {
            var sumTotalPower = 0d;
            var sumAffinity = 0;

            foreach (var entity in kvp.Value)
            {
                if (entity.GetType().BaseType == typeof(Bender))
                {
                    sumTotalPower += entity.TotalPower;
                }
                else
                {
                    sumAffinity += entity.Affinity;
                }
            }

            var nationTotalPower = sumTotalPower / 100 * (sumAffinity == 0 ? 1 : sumAffinity);
            warResult.Add(kvp.Key, nationTotalPower);
        }

        var winner = warResult.OrderByDescending(kvp => kvp.Value).First().Key;

        foreach (var kvp in this.entities.Where(kvp => kvp.Key != winner))
        {
            kvp.Value.Clear();
        }

        this.warsRecord.AppendLine($"War {this.counter} issued by {nationsType}");
        this.counter++;
    }

    public string GetWarsRecord()
    {
        return this.warsRecord.ToString().Trim();
    }

    private void OutputBuilder(StringBuilder sb, List<Entity> filteredNation, Type type)
    {
        if (filteredNation.Any(e => e.GetType().BaseType == type))
        {
            sb.AppendLine($"{type.Name}s:");

            foreach (var entity in filteredNation.Where(e => e.GetType().BaseType == type))
            {
                sb.AppendLine(entity.ToString());
            }
        }
        else
        {
            sb.AppendLine($"{type.Name}s: None");
        }
    }
}
