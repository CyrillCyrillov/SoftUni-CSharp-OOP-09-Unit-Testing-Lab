using NUnit.Framework;
using System;

namespace Bank.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void WhenAcountInitilisedWithPositiveValue_AcountShouldBeChange()
        {

            decimal starAmount = 5;
            BankAccount testAcont = new BankAccount(starAmount);

            Assert.That(testAcont.Amount, Is.EqualTo(starAmount));

        }

        [Test]
        public void WhenDepositMade_AmountMustIncrease()
        {
            decimal startAmount = 5;
            decimal addAmount = 15;
            BankAccount testAcount = new BankAccount(startAmount);

            testAcount.Deposit(addAmount);

            Assert.That(testAcount.Amount, Is.EqualTo(startAmount + addAmount));
        }

    }
}
