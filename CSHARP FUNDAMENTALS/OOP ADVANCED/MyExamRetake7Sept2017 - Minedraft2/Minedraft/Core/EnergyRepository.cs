public class EnergyRepository : IEnergyRepository
{
    public double EnergyStored { get; private set; }

    public bool TakeEnergy(double energyNeeded) // where is this for?
    {
        return !(energyNeeded > this.EnergyStored);
    }

    public void StoreEnergy(double energy)
    {
        this.EnergyStored += energy;
    }
}