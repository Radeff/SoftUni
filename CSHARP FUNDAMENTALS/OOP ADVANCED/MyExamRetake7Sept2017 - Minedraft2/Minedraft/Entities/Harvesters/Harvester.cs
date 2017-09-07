using System.Text;

public abstract class Harvester : IHarvester
{
    private const int InitialDurability = 1000;
    
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(int id, double oreOutput, double energyRequirement)
    {
        this.ID = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
        this.Durability = InitialDurability;
    }

    public int ID { get; }

    public double OreOutput { get; protected set; }

    public double EnergyRequirement { get; protected set; }

    public virtual double Durability { get; protected set; }

    public double Produce()
    {
        throw new System.NotImplementedException();
    }

    public void Broke()
    {
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name}");
        sb.AppendLine($"Durability: {this.Durability}");
        return sb.ToString().Trim();
    }
}