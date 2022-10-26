using System;

namespace Bank
{
    public class Account
    {
        int BalanceAmount;
        public Account()
        {
            BalanceAmount = 0;

        }

        public int Deposit(int amt)
        {
            BalanceAmount += amt;
            return BalanceAmount;
        }
        public int Withdraw(int amt)
        {
            if (amt > BalanceAmount)
            {
                return -1;
            }
            BalanceAmount -= amt;
            return BalanceAmount;
        }s

        public static int TransferFunds(Account FromAcc, Account ToAcc, int amt)
        {
            FromAcc.Withdraw(amt);
            ToAcc.Deposit(amt);
            return FromAcc.BalanceAmount;

        }
    }
}
