using System;

public class AmmunitionFactory : IAmmunitionFactory
{
    public IAmmunition CreateAmmunition(string ammunitionName)
    {
        var type = Type.GetType(ammunitionName);
        var instance = (IAmmunition)Activator.CreateInstance(type, new object[] {ammunitionName});
        return instance;
    }
}
