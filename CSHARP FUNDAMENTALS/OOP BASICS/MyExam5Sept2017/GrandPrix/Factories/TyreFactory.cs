public class TyreFactory
{
    public Tyre CreateTyre(string tyreType, double tyreHardness, double tyreGrip)
    {
        if (tyreType == "Ultrasoft")
        {
            return new UltrasoftTyre(tyreHardness, tyreGrip);
        }

        if(tyreType == "Hard")
        {
            return new HardTyre(tyreHardness);
        }

        return null;
    }
}
