public class PressureProvider : Provider
{
    private const int EnergyOutputMultiplier = 2;
    private const double DurabilityDecrease = 300;

    public PressureProvider(int id, double energyOutput)
        : base(id, energyOutput)
    {

    }

    public override double EnergyOutput => this.EnergyOutput *= EnergyOutputMultiplier;

    public override double Durability => this.Durability -= DurabilityDecrease;
}