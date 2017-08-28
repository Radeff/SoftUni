public class CircuitRace : Race
{
    public CircuitRace(int length, string route, int prizingPool, int laps) : base(length, route, prizingPool)
    {
        this.Laps = laps;
    }

    public override int Laps { get; }
}
