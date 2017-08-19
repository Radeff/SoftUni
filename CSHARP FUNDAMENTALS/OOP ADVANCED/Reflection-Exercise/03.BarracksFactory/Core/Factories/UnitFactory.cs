namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string NameSpase = "_03BarracksFactory.Models.Units";
        public IUnit CreateUnit(string unitType)
        {
            var type = Type.GetType($"{NameSpase}.{unitType}");
            return (IUnit)Activator.CreateInstance(type, true);
        }
    }
}
