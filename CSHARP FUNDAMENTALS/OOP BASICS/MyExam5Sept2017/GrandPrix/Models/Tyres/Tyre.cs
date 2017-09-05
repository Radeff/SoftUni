using System;

public abstract class Tyre
{
    private double degradation;
    private const double DefaultDegradation = 100.0;

    protected Tyre( double hardness)
    {
        this.Degradation = DefaultDegradation;
        this.Hardness = hardness;
    }

    public abstract string Name { get; }

    public double Hardness { get; }

    public virtual double Degradation
    {
        get { return this.degradation; }
        protected set
        {
            if (value < 0)
            {
                throw new Exception("Blown Tyre");
            }

            this.degradation = value;
        }
    }

    public abstract void DegradeTyre();
}