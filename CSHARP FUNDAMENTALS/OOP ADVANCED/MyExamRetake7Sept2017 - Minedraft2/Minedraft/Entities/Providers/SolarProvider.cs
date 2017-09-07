public class SolarProvider : Provider
{
    private const double DurabilityIncrease = 500;

    public SolarProvider(int id, double energyOutput) 
        : base(id, energyOutput)
    {
        
    }

    public override double Durability => this.Durability += DurabilityIncrease;
}