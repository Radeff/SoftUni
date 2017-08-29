public class EarthBender : Bender
{
    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
        this.TotalPower = power * this.GroundSaturation;
    }

    public double GroundSaturation { get; }

    public override double TotalPower { get; }

    public override string SpecialtyName => nameof(this.GroundSaturation);

    public override double SpecialtyValue => this.GroundSaturation;
}

