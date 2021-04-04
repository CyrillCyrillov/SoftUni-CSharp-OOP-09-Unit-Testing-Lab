using NUnit.Framework;
using System;

namespace Skeleton
{


    [TestFixture]
    public class DummyTests
    {
        private int startHealth = 10;
        private int startExperience = 10;

        Dummy startDummy;

        [SetUp]
        public void SetUp()
        {
            startDummy = new Dummy(startHealth, startExperience);
        }



        [Test]
        public void WwenDummySet_IsCorectrly()
        {
            /*
                public Dummy(int health, int experience)
                {
                    this.health = health;
                    this.experience = experience;
                }
             
            */

            Assert.AreEqual(startDummy.Health, startHealth);

        }

        [Test]
        public void When_DummyWasAtacked_IsHealthDecreace()
        {
            /*

            public void TakeAttack(int attackPoints)
            {
                if (this.IsDead())
                {
                    throw new InvalidOperationException("Dummy is dead.");
                }

                this.health -= attackPoints;
            }

            */

            int nextAttackPoint = 2;

            startDummy.TakeAttack(nextAttackPoint);

            Assert.AreEqual(startDummy.Health, startHealth - nextAttackPoint);


        }

        [Test]
        public void WhenAtackeDeathDummy_MustThrowMesage()
        {
            /*

            public void TakeAttack(int attackPoints)
            {
                if (this.IsDead())
                {
                    throw new InvalidOperationException("Dummy is dead.");
                }

                this.health -= attackPoints;
            }

            InvalidOperationException("Dummy is dead.")

            */

            Dummy lowDummy = new Dummy(1, 1);
            lowDummy.TakeAttack(2);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            {

                lowDummy.TakeAttack(1);
            });

            Assert.AreEqual(ex.Message, "Dummy is dead.");

        }


        [Test]
        public void WhenAskForExperienceFromDeathDummy_TakeCorectValue()
        {
            /*
             
            public int GiveExperience()
            {
                if (!this.IsDead())
                {
                    throw new InvalidOperationException("Target is not dead.");
                }

                return this.experience;
            }

            */

            int nextAttackPoint = 11;

            startDummy.TakeAttack(nextAttackPoint);

            int curentExperience = startDummy.GiveExperience();

            Assert.AreEqual(curentExperience, startExperience);


        }

        [Test]
        public void WhenAskForExperienceFromNotDeathDummy_TakeCorectValue()
        {
            /*
             
            public int GiveExperience()
            {
                if (!this.IsDead())
                {
                    throw new InvalidOperationException("Target is not dead.");
                }

                return this.experience;
            }

            */

            

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            {

                int curentExperience = startDummy.GiveExperience();
            });

            Assert.AreEqual(ex.Message, "Target is not dead.");

        }

        [Test]
        public void WhenDummyIsNotDeath_ReturnFalse()
        {
            /*

            public bool IsDead()
            {
                return this.health <= 0;
            }

            */

            bool IsDeath = startDummy.IsDead();
            Assert.AreEqual(IsDeath, false);

        }

        [Test]
        public void WhenDummyIstDeath_ReturnTrue()
        {
            /*

            public bool IsDead()
            {
                return this.health <= 0;
            }

            */

            startDummy.TakeAttack(11);

            bool IsDeath = startDummy.IsDead();
            Assert.AreEqual(IsDeath, true);

        }
    }


}

