public class WaterBender : Bender
{
    public WaterBender(string name, int power, double waterClarity)
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
        this.TotalPower = power * this.WaterClarity;
    }

    public double WaterClarity { get; }

    public override double TotalPower { get; }
    public override string SpecialtyName => nameof(this.WaterClarity);
    public override double SpecialtyValue => this.WaterClarity;
}
