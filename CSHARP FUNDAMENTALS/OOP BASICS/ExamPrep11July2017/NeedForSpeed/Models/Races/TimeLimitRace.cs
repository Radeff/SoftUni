public class TimeLimitRace : Race
{
    public TimeLimitRace(int length, string route, int prizingPool, int goldTime) : base(length, route, prizingPool)
    {
        this.GoldTime = goldTime;
    }

    public override int GoldTime { get; }
}