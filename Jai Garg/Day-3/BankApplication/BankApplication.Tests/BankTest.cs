using System;
using BankApplication;
using NUnit.Framework;

namespace BankApplication.Test
{
    public class BankTest
    {

        [Test]
        public void DepositTest()
        {
            Account a1 = new Account();
            a1.Deposit(1000);
            int expected = 1000;
            int actual = a1.Balance;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WithdrawTest()
        {
            Account a1 = new Account();
            a1.Deposit(1000);
            a1.Withdraw(50);
            int expected = 950;
            int actual = a1.Balance;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TransferTest()
        {
            Account a1 = new Account();
            Account a2 = new Account();
            a1.Deposit(1000);
            a2.Deposit(100);
            a2.Transfer(50, a1);
            int expected1 = 1050;
            int expected2 = 50;
            int actual1 = a1.Balance;
            int actual2 = a2.Balance;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
