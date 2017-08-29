public class AirBender : Bender
{
    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
        this.TotalPower = power * this.AerialIntegrity;
    }

    public double AerialIntegrity { get; }

    public override string SpecialtyName => nameof(this.AerialIntegrity);

    public override double SpecialtyValue => this.AerialIntegrity;

    public override double TotalPower { get; }
}
