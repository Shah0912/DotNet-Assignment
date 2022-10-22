
using Bank;

namespace BankTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DepositTest()
        {
            Account acc1 = new Account();
            acc1.Deposit(100);
            int expected = acc1.BankBalance;
            int actual = 100;
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void WithdrawTest()
        {
            Account acc1 = new Account();
            acc1.Deposit(100);
            acc1.Withdraw(50);
            int expected = acc1.BankBalance;
            int actual = 50;
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TransferTest()
        {
            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.Deposit(100);
            acc1.Transfer(50, acc1, acc2);
            int expected1 = acc1.BankBalance;
            int expected2 = acc2.BankBalance;
            int actual1 = 50;
            int actual2 = 50;
            Assert.That(actual1, Is.EqualTo(expected1));
            Assert.That(actual2, Is.EqualTo(expected2));
        }
    }
}