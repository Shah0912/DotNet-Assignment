// Account.cs

using System;
using System.Coolections.Generic;
using System.Text;

namesapce Account
{
public class operations
{
public int AccountBalance = 500;

public int Deposit(int credit)
{

this.AccountBalance += credit;
return this.AccountBalance;
}

public int WithDraw(int debit)
{

this.AccountBalance -= debit;

return this.AccountBalance;

}

public void transfer(int money, operations temp_acnt)
{

this.AccountBalance -= money;
temp_acnt.AccountBalance += money;

}

}
