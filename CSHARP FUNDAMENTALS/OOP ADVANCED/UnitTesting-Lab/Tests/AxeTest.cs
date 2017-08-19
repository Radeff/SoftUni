using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AxeTest
    {
        private const int AxeDurability = 10;
        private const int AxeAttack = 10;
        private const int DummyHealth = 20;
        private const int DummyXp = 20;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void InitializeAxeAndDummy()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXp);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            this.axe.Attack(this.dummy);
            this.axe.Attack(this.dummy);
            Assert.AreEqual(8, this.axe.DurabilityPoints);
        }
    }
}
