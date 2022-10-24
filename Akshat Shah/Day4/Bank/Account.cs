namespace Bank.Domain
{
    public class Account
    {
        public string Id { get; }
        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }

            private set
            {
                balance = value;
            }
        }

        public Account()
        {
            Id = Guid.NewGuid().ToString();
            Balance = 0;
        }

        public Account(int initialBalance)
        {
            Id = Guid.NewGuid().ToString();
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative");
            }
            Balance = initialBalance;
        }

        public void Withdraw(int amountToWithdraw)
        {
            if (amountToWithdraw <= 0)
            {
                throw new ArgumentException("amountToWithdraw must be > 0");
            }
            if (Balance < amountToWithdraw)
            {
                throw new Exception("Insufficient balance");
            }
            Balance -= amountToWithdraw;
        }

        public void Deposit(int amountToDeposit)
        {
            if (amountToDeposit <= 0)
            {
                throw new ArgumentException("amountToDeposit must be > 0");
            }
            Balance += amountToDeposit;
        }
    }
}