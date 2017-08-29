public class WaterMonument : Monument
{
    public WaterMonument(string name, int waterAffinity)
        : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int WaterAffinity { get; }

    public override int Affinity => this.WaterAffinity;
}