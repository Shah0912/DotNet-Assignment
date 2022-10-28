namespace BankApplication
{
    public class Account
    {
        public int Balance = 0;

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }

        public void Transfer(int amount, Account a)
        {
            this.Balance -= amount;
            a.Balance += amount;
        }
    }
}