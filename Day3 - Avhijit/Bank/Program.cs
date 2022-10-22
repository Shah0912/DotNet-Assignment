namespace Bank
{
    public class Account
    {
        public int BankBalance = 0;

        public void Deposit(int money)
        {
            BankBalance += money;
        }
        public void Withdraw(int money)
        {
            BankBalance -= money;
        }

        public void Transfer(int money, Account acc1,Account acc2)
        {
            acc1.BankBalance -= money;
            acc2.BankBalance += money;
        }
    }
    public class MainClass
    {
        static void Main()
        {
            Account acc1 = new Account();
            Account acc2 = new Account();
        }
    }
}