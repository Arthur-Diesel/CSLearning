// C# code​​​​​​‌​‌​​‌​‌​​‌‌​​​​​​​‌‌‌​‌‌ below
using System;

public class BankAccount
{

    public string AccountOwner;
    public decimal Balance = 0.0m;

    public BankAccount(string firstName, string lastName, decimal balance)
    {
        AccountOwner = $"{firstName} {lastName}";
        Balance = balance;
    }

    public void Deposit(decimal value)
    {
        Balance += value;
    }

    virtual public bool Withdraw(decimal value)
    {
        if (value > Balance)
        {
            return false;
        }
        else
        {
            Balance -= value;
            return true;
        }
    }
}

public class CheckingAcct : BankAccount
{
    public CheckingAcct(string firstName, string lastName, decimal balance) : base(firstName, lastName, balance) { }

    public override bool Withdraw(decimal value)
    {
        if (value > Balance)
        {
            Balance -= value + 35;
        }
        else
        {
            Balance -= value;
        }

        return true;
    }
}

public class SavingsAcct : BankAccount
{
    private decimal _interestRate;
    private int _withDraws = 0;

    public SavingsAcct(string firstName, string lastName, decimal interestRate, decimal Balance) : base(firstName, lastName, Balance)
    {
        _interestRate = interestRate;
    }

    public void ApplyInterest()
    {
        Balance += (_interestRate * Balance);
    }

    public override bool Withdraw(decimal value)
    {
        if (value > Balance)
        {
            return false;
        }
        else
        {
            if (_withDraws >= 3)
            {
                _withDraws += 1;
                Balance -= value + 2;
                return true;
            } else {
                _withDraws += 1;
                Balance -= value;
                return true;
            }
        }
    }
}
