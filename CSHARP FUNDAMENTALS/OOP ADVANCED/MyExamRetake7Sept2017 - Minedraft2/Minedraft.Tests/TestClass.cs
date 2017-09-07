using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class TestClass
{
    private ProviderController pc;
    private EnergyRepository er;

    [SetUp]
    public void InitializeTests()
    {
        this.er = new EnergyRepository();
        this.pc = new ProviderController(this.er);
    }
    
    [Test]
    public void ProvidersProduceCorrectEnergyAndStoresIt()
    {
        var args = new List<string> { "Standart", "10", "100" };
        this.pc.Register(args);
        this.pc.Produce();
        Assert.AreEqual(this.pc.TotalEnergyProduced, 100.0);
    }
    
    [Test]
    public void RegisterReturnsCorrectCount()
    {
        var args = new List<string> { "Pressure", "10", "100" };
        this.pc.Register(args);
        Assert.AreEqual(1, this.pc.Entities.Count);
    }

    [Test]
    public void BrokenStuffGetsRemoved()
    {
        var args = new List<string> { "Standart", "10", "100" };
        this.pc.Register(args);

        for (int i = 0; i < 12; i++)
        {
            this.pc.Produce();
        }
        Assert.AreEqual(0, this.pc.Entities.Count);
    }
}

