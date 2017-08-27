using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private const string FullMode = "Full";
    private const string HalfMode = "Half";
    private const string EnergyMode = "Energy";
    private const double HalfModeEnergyModifier = 0.6;
    private const double HalfModeOreModifier = 0.5;

    private readonly Dictionary<string, Harvester> harvesters;
    private readonly Dictionary<string, Provider> providers;
    private readonly HarvesterFactory harvesterFactory;
    private readonly ProviderFactory providerFactory;
    private string mode;
    private double totalMinedOre;
    private double totalEnergyStored;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        harvesterFactory = new HarvesterFactory();
        providerFactory = new ProviderFactory();
        this.mode = FullMode;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);
        var sonicFactor = 1;
        if (arguments.Count == 5)
        {
            sonicFactor = int.Parse(arguments[4]);
        }

        try
        {
            var harvester = harvesterFactory.CreateHarvester(id, type, oreOutput, energyRequirement, sonicFactor);
            harvesters.Add(id, harvester);
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return $"Successfully registered {type} {nameof(Harvester)} - {id}";
    }
    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);

        try
        {
            var provider = providerFactory.CreateProvider(id, type, energyOutput);
            providers.Add(id, provider);

        }
        catch (Exception e)
        {
            return e.Message;
        }

        return $"Successfully registered {type} {nameof(Provider)} - {id}";
    }

    public string Day()
    {
        var summedOreOutput = 0d;
        var summedEnergyRequired = 0d;


        foreach (var harvester in harvesters.Values)
        {
            summedEnergyRequired += harvester.EnergyRequirement;
            summedOreOutput += harvester.OreOutput;
        }

        var summedEnergyOutput = providers.Values.Sum(provider => provider.EnergyOutput);

        this.totalEnergyStored += summedEnergyOutput;

        if (this.mode == HalfMode)
        {
            summedOreOutput *= HalfModeOreModifier;
            summedEnergyRequired *= HalfModeEnergyModifier;
        }

        if (this.mode != EnergyMode)
        {
            if (this.totalEnergyStored < summedEnergyRequired)
            {
                summedOreOutput = 0d;
            }
            else
            {
                this.totalEnergyStored -= summedEnergyRequired;
                this.totalMinedOre += summedOreOutput;
            }
        }
        else
        {
            summedOreOutput = 0d;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {summedEnergyOutput}");
        sb.AppendLine($"Plumbus Ore Mined: {summedOreOutput}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        if (harvesters.ContainsKey(id))
        {
            return harvesters[id].ToString();
        }

        if (providers.ContainsKey(id))
        {
            return providers[id].ToString();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString().Trim();
    }
}