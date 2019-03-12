using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account.AccountNumber = 12345;
            account.Balance = 10000;
        }
    }
}
