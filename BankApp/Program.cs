using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Welcome to my Bank");
            Console.WriteLine("*********************************");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print my Accounts");
                Console.Write("Select an Option:");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Bank"); ///Writeline - Writes and goes to next line 
                        return;
                    case "1":
                        Console.Write("Email Address:");   ///write - ONLY writes and doesn't go to the next line
                        var emailAddress = Console.ReadLine();

                        var accountTypes = Enum.GetNames(typeof(AccountType));
                        for (int i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {accountTypes[i]}");
                        }
                        Console.Write("Account Type: ");
                        var accountType = Enum.Parse<AccountType>(Console.ReadLine());

                        Console.Write("Amount to Deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine()); ///Convert ONLY allows us to convert into built in types like int, string

                        var a1 = Bank.CreateAccount(emailAddress, accountType, amount);

                        Console.WriteLine($"AN {a1.AccountNumber}, CD: {a1.CreatedDate}, B: {a1.Balance:C}, EA: {a1.EmailAddress}, AT: {a1.AccountType}");
      
                        
                        break;
                    case "2":
                    case "3":
                    case "4":
                    default:///if a case is not in our list
                        break;
                }
            }
        }

    }
}
