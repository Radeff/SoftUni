public class FireBender : Bender
{
    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
        this.TotalPower = power * this.HeatAggression;
    }

    public double HeatAggression { get; }

    public override double TotalPower { get; }

    public override string SpecialtyName => nameof(this.HeatAggression);

    public override double SpecialtyValue => this.HeatAggression;
}
