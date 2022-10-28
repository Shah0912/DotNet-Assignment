using System.Security.Principal;

namespace BankApplication.Tests
{
    public class AccountTests
    {

        [Test]
        public void DepositTest()
        {
            Account a1 = new Account();
            a1.Deposit(5000);
            int expected = 5000;
            int actual = a1.Balance;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void WithdrawTest()
        {
            Account a1 = new Account();
            a1.Deposit(5000);
            a1.Withdraw(500);
            int expected = 4500;
            int actual = a1.Balance;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TransferTest()
        {
            Account a1 = new Account();
            Account a2 = new Account();
            a1.Deposit(5000);
            a2.Deposit(1000);
            a2.Transfer(500, a1);
            int expected1 = 5500;
            int expected2 = 500;
            int actual1 = a1.Balance;
            int actual2 = a2.Balance;
            Assert.That(actual1, Is.EqualTo(expected1));
            Assert.That(actual2, Is.EqualTo(expected2));
        }
    }
}