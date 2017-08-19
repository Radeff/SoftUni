using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int AxeDurability = 10;
        private const int AxeAttack = 10;
        private const int DummyHealth = 20;
        private const int DummyXp = 10;
        private const string HeroName = "Batman";
        private const int None = 0;

        private Axe axe;
        private Dummy dummy;
        private Hero hero;

        [SetUp]
        public void InitializeAxeAndDummy()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXp);
            this.hero = new Hero(HeroName);
        }

        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            this.axe.Attack(this.dummy);
            Assert.AreEqual(DummyHealth - AxeAttack, this.dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsException()
        {
            KillDummy();
            Assert.Throws<InvalidOperationException>(() => this.axe.Attack(this.dummy));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            KillDummy();
            Assert.AreEqual(DummyXp, this.hero.Experience);
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            this.hero.Attack(this.dummy);
            Assert.AreEqual(None, this.hero.Experience);
        }

        private void KillDummy()
        {
            while (this.dummy.Health > None)
            {
                this.hero.Attack(this.dummy);
            }
        }
    }
}
