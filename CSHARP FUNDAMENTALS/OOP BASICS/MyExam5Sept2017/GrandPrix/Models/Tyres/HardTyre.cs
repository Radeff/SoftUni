public class HardTyre : Tyre
{
    public HardTyre(double hardness) : base(hardness)
    {
    }

    public override string Name => "Hard";
    public override void DegradeTyre()
    {
        this.Degradation -= this.Hardness;
    }
}