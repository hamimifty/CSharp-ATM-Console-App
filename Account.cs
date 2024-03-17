using System;

public class Account
{
    public decimal Balance { get; private set; }

    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"${amount} has been deposited to your account.");
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance && amount > 0)
        {
            Balance -= amount;
            Console.WriteLine($"${amount} has been withdrawn from your account.");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }
}
