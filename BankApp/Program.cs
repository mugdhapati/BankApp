using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Welcome to my bank!");
            Console.WriteLine("*****************");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print my accounts");
                Console.WriteLine("5. Print my Transactions");
                Console.Write("Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the bank!");
                        return;
                    case "1":
                        try
                        {
                            Console.Write("Email Address: ");
                            var emailAddress = Console.ReadLine();

                            var accountTypes = Enum.GetNames(typeof(AccountType));
                            for (int i = 0; i < accountTypes.Length; i++)
                            {
                                Console.WriteLine($"{i}. {accountTypes[i]}");
                            }

                            Console.Write("Account Type: ");
                            var accountType = Enum.Parse<AccountType>(Console.ReadLine());

                            Console.Write("Amount to deposit: ");
                            var amount = Convert.ToDecimal(Console.ReadLine());

                            var a1 = Bank.CreateAccount(emailAddress, accountType, amount);
                            Console.WriteLine($"AN: {a1.AccountNumber}, CD: {a1.CreatedDate}, Balance: {a1.Balance:C}, EA: {a1.EmailAddress}, AT: {a1.AccountType}");
                        }
                        catch (ArgumentNullException nx)
                        {
                            Console.WriteLine($"Email Address Error - {nx.Message} - Please try again! ");
                        }
                        catch (ArgumentException ax)
                        {
                            Console.WriteLine($"Account Type Error - {ax.Message} - Please try again! ");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Amount Error - Please provide a valid amount. Try again! ");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($" Sorry something went wrong - {ex.Message} - Please Try again");                        
                        }
                        break;
                    case "2":
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        var accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount to deposit: ");
                        var depositAmount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Deposit(accountNumber, depositAmount);
                        Console.WriteLine("Desposit successfully completed!");
                        break;
                    case "3":
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount to withdraw: ");
                        var withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Withdraw(accountNumber, withdrawAmount);
                        Console.WriteLine("Withdrawal successfully completed!");
                        break;
                    case "4":
                        PrintAllAccounts();
                        break;
                    case "5":
                        PrintAllTransactions();
                        break;
                    default:
                        break;
                }
            }

        }

        private static void PrintAllTransactions()
        {
            PrintAllAccounts();
            Console.Write("Account Number:");
            var accountnumber = Convert.ToInt32(Console.ReadLine());
            var transactions = Bank.GetTransactionsForAccountNumber(accountnumber);
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"Id: {transaction.TransactionId}, Date: {transaction.TransactionDate}, Type: {transaction.TransactionType}, Amount: {transaction.Amount}");
            }
        }

        private static void PrintAllAccounts()
        {
            Console.Write("EmailAddress: ");
            var emailaddress = Console.ReadLine();
            var accounts = Bank.GetAllAccountsForUser(emailaddress);
            foreach (var account in accounts)
            {
                Console.WriteLine($"AN: {account.AccountNumber}, CD: {account.CreatedDate}, Balance: {account.Balance:C}, EA: {account.EmailAddress}, AT: {account.AccountType}");
            }

        }
    }
}
