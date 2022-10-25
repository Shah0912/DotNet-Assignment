using System;

namespace Bank
{
    public class Account
    {
        int BalanceAmount;
        public Account()
        {
            //intially all accounts will have a balance of 0
            BalanceAmount = 0;

        }
        //assuming we get all valid amt 
        public int Deposit(int amt)
        {
            BalanceAmount += amt;
            return BalanceAmount;
        }
        public int Withdraw(int amt)
        {
            if (amt > BalanceAmount)
            {
                return -1; //more than balance amount cant withdraw
            }
            BalanceAmount -= amt;
            return BalanceAmount;
        }
        //static method to transfer money from one acc to other and returns balance
        public static int TransferFunds(Account FromAcc, Account ToAcc, int amt)
        {
            FromAcc.Withdraw(amt);
            ToAcc.Deposit(amt);
            return FromAcc.BalanceAmount;

        }
    }
}
