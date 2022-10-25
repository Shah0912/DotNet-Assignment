using System;
using System.Xml.Serialization;

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
    public class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Account a2 = new Account(); 
        }
    }
}
