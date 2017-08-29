public class FireMonument : Monument
{
    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public int FireAffinity { get; }

    public override int Affinity => this.FireAffinity;
}