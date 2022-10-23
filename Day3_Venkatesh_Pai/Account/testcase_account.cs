// testcase

using System;
using System.Collections.Generic;
using System.Text;
using Nunit.Framework;
using Account;

{

[TestFixture]
public class TestCases
{
operations Acnt1 = null;
operations Acnt2 = null;

[SetUp]
public void set_up()
{
Acnt1 = new operations();
Acnt2 = new operations();
}

[Test]
public void deposit_test()
{
int actual = Acnt1.Deposit(100);
int expected = 600;
Assert.AreEqual(expected,actual);
}

[Test]
public void withdraw_test()
{

int actual = Acnt1.WithDraw(200);
int expected = 300;
Assert.AreEqual(expected,actual);

}

[Test]
{
public void Transfer_Test()
{

Acnt1.transfer(50,acnt2);
Assert.AreEqual(450,Acnt1.AccountBalance);
Assert.AreEqual(550,Acnt2.AccountBalance);
}

[TearDown]
public void tear_down()
{
Acnt1 = null;
Acnt2 = null;
}

}

}