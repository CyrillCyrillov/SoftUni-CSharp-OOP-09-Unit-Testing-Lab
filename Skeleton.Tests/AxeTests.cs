using NUnit.Framework;
using System;

namespace Skeleton
{


[TestFixture]
public class AxeTests
{
    private int startAttack = 5;
    private int startDurability = 5;

    private Axe startAxe;

    int startHealth = 5;
    int startExperience = 10;

    private Dummy target;

    [SetUp]
    public void SetUp()
    {
        startAxe = new Axe(startAttack, startDurability);

        target = new Dummy(startHealth, startExperience);
     }

    [Test]
    public void WheAxeIsSet_IsTheSetCorectly()
    {
        /*

            public Axe(int attack, int durability)
            {
                this.attackPoints = attack;
                this.durabilityPoints = durability;
            }


        */

            Assert.That(startAxe.AttackPoints, Is.EqualTo(startAttack));
            Assert.That(startAxe.DurabilityPoints, Is.EqualTo(startDurability));


    }

    [Test]
    public void WhenAtackWithPositiveDurabilityPoits_DummyDurabilityMustDecreaseWithOne()
    {
            /*
             
                    public void Attack(Dummy target)
                    {
                        if (this.durabilityPoints <= 0)
                        {
                            throw new InvalidOperationException("Axe is broken.");
                        }

                        target.TakeAttack(this.attackPoints);
                        this.durabilityPoints -= 1;
                    }

            public Dummy(int health, int experience)
            {
                this.health = health;
                this.experience = experience;
            }

            */

            


            startAxe.Attack(target);

            //Assert.That(startAxe.DurabilityPoints, Is.EqualTo(startDurability - 1));
            Assert.AreEqual(startAxe.DurabilityPoints, startDurability - 1);

        }

        [Test]
        public void WhenAtackWithNegativDurability_Mesage()
        {
            /*
             
                    public void Attack(Dummy target)
                    {
                        if (this.durabilityPoints <= 0)
                        {
                            throw new InvalidOperationException("Axe is broken.");
                        }

                        target.TakeAttack(this.attackPoints);
                        this.durabilityPoints -= 1;
                    }

            public Dummy(int health, int experience)
            {
                this.health = health;
                this.experience = experience;
            }

            InvalidOperationException("Axe is broken.")

            */

            Dummy morePorewulTarget = new Dummy(5000, 5000);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            {

                for (int i = 1; i <= 7; i++)
                {
                    startAxe.Attack(morePorewulTarget);
                }
            });

            Assert.AreEqual(ex.Message, "Axe is broken.");
        }

    }

}
