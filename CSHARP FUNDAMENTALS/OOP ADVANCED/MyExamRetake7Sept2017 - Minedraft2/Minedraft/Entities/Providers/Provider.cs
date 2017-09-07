using System;

public abstract class Provider : IProvider
{
    private const double DefaultDurability = 1000;
    private const double DefaultDamage = 100;
    private double durability;

    protected Provider(int id, double energyOutput)
    {
        this.ID = id;
        this.Durability = DefaultDurability;
        this.EnergyOutput = energyOutput;
    }

    public int ID { get; }

    public virtual double Durability
    {
        get { return this.durability; }
        protected set
        {
            this.durability = value;
            if (this.durability < 0)
            {
                throw new Exception();
            }
        }
    }

    public virtual double EnergyOutput { get; protected set; }

    public virtual double Produce()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Broke()
    {
        this.Durability -= DefaultDamage;
    }

    public virtual void Repair(double val)
    {
        throw new System.NotImplementedException();
    }
}