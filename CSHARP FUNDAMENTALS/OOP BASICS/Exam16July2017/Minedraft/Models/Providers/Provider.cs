using System;
using System.Text;

public abstract class Provider : Worker
{
    private double energyOutput;

    private const double MaxEnergyOutput = 10000;
    private const double MinEnergyOutput = 0;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get => this.energyOutput;

        protected set
        {
            if (value > MaxEnergyOutput || value < MinEnergyOutput)
            {
                throw new ArgumentException($"{nameof(Provider)} is not registered, because of it's {nameof(this.EnergyOutput)}");
            }

            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var type = nameof(Provider);
        var workerName = this.GetType().Name;
        var name = workerName.Substring(0, workerName.Length - 8);

        sb.AppendLine($"{name} {type} - {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();
    }
}
