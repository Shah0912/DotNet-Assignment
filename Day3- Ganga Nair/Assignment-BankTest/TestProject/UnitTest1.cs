using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank;
using System.Security.Principal;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Deposit()
        {
            Account acc1=new Account();
            Assert.AreEqual(acc1.Deposit(50), 50);
        }
        [TestMethod]
        public void Test_Withdrawal_Success()
        {
            Account acc1 = new Account();
            acc1.Deposit(100);
            Assert.AreEqual(acc1.Withdraw(50), 50);

        }
        [TestMethod]
        public void Test_Withdrawal_Fail()
        {
            Account acc1 = new Account();
            Assert.AreEqual(acc1.Withdraw(50), -1);
        }
        [TestMethod]
        public void Test_TransferFunds()
        {
            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.Deposit(100);
            int bal=Account.TransferFunds(acc1, acc2, 50);
            Assert.AreEqual(bal, 50) ;
            Assert.AreEqual(acc2.Withdraw(20), 30);
            
        }

    }
}
