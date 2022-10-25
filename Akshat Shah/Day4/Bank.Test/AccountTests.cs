using Bank.Domain;

namespace Bank.Test
{
    public class AccountTests
    {
        Account account;

        [SetUp]
        public void Setup()
        {
            account = new Account();
        }

        [Test]
        public void InitialBalanceIsZero()
        {
            Assert.That(account.Balance, Is.EqualTo(0));
        }

        [Test]
        public void InitialBalanceGetsSet()
        {
            Account account2 = new Account(100);
            Assert.That(account2.Balance, Is.EqualTo(100));
        }

        [Test]
        public void CannotSetNegativeInitialBalance()
        {
            Assert.Catch(typeof(ArgumentException), () => new Account(-1), "Initial balance cannot be negative");
        }

        [Test]
        public void AccountIdIsAssigned()
        {
            Assert.That(account.Id, Is.Not.Null);
        }

        [Test]
        public void DepositAmountGetsAdded()
        {
            Assert.That(account.Balance, Is.EqualTo(0));

            account.Deposit(100);

            Assert.That(account.Balance, Is.EqualTo(100));
        }

        [Test]
        public void CannotDepositInvalidAmount()
        {
            Assert.Catch(typeof(ArgumentException), () => account.Deposit(0), "amountToDeposit must be > 0");
            Assert.Catch(typeof(ArgumentException), () => account.Deposit(-1), "amountToDeposit must be > 0");
        }

        [Test]
        public void WithdrawAmountGetsSubtracted()
        {
            account.Deposit(100);
            account.Withdraw(50);
            Assert.That(account.Balance, Is.EqualTo(50));
        }

        [Test]
        public void CannotWithdrawInvalidAmount()
        {
            Assert.Catch(typeof(ArgumentException), () => account.Withdraw(0), "amountToWithdraw must be > 0");
            Assert.Catch(typeof(ArgumentException), () => account.Withdraw(-1), "amountToWithdraw must be > 0");
        }

        [Test]
        public void CannotUnderflowBalance()
        {
            Assert.That(account.Balance, Is.EqualTo(0));
            Assert.Catch(typeof(InvalidOperationException), () => account.Withdraw(1), "Insufficient balance");
        }
    }
}