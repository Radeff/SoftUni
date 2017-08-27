using System;
using System.Text;

public abstract class Harvester : Worker
{
    private double oreOutput;
    private double energyRequirement;

    private const double MaxEnergyRequirement = 20000;
    private const double MinEnergyRequirement = 0;
    
    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get => this.oreOutput;

        protected set
        {
            if (value < MinEnergyRequirement)
            {
                throw new ArgumentException($"{nameof(Harvester)} is not registered, because of it's {nameof(this.OreOutput)}");
            }

            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get => this.energyRequirement;

        protected set
        {
            if (value > MaxEnergyRequirement || value < MinEnergyRequirement)
            {
                throw new ArgumentException($"{nameof(Harvester)} is not registered, because of it's {nameof(this.EnergyRequirement)}");
            }

            this.energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var type = nameof(Harvester);
        var workerName = this.GetType().Name;
        var name = workerName.Substring(0, workerName.Length - 9);

        sb.AppendLine($"{name} {type} - {this.Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString().Trim();
    }
}