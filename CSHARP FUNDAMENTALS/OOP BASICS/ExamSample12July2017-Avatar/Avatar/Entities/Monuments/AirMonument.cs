public class AirMonument : Monument
{
    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity { get; }

    public override int Affinity => this.AirAffinity;
}
