using NUnit.Framework;

namespace Skeleton
{

    [TestFixture]
    public class HeroTests
    {

        [Test]
        public void CorectSet()
        {
            /*

            public Hero(string name)
            {
                this.name = name;
                this.experience = 0;
                this.weapon = new Axe(10, 10);
            }

            */

            string firstHeroName = "Test Name";

            Hero testHero = new Hero(firstHeroName);

            Assert.AreEqual(testHero.Name, firstHeroName);
            Assert.AreEqual(testHero.Experience, 0);
            Assert.AreEqual(testHero.Weapon.AttackPoints, 10);
            Assert.AreEqual(testHero.Weapon.DurabilityPoints, 10);

        }

        
    }

}

