using System;

class Program
{
    static void Main()
    {
        Account account = new Account(1000); // Starting with an initial balance of $1000
        ATM atm = new ATM(account);
        atm.Start();
    }
}
