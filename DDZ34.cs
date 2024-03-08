using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public abstract void Withdraw(double amount);
        public abstract void Deposit(double amount);
    }

    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостатньо коштів");
            }
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public double CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }

    public class CheckingAccount : Account
    {
        public double OverdraftLimit { get; set; }

        public override void Withdraw(double amount)
        {
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Перевищено ліміт переписки");
            }
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
        }
    }

    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void PrintAllAccounts()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Номер рахунку: {account.AccountNumber}, Власник: {account.HolderName}, Залишок: {account.Balance}");
            }
        }

        public Account FindAccount(string accountNumber)
        {
            return accounts.Find(account => account.AccountNumber == accountNumber);
        }

        public void Withdraw(string accountNumber, double amount)
        {
            var account = FindAccount(accountNumber);
            if (account != null)
            {
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Рахунок не знайдено");
            }
        }

        public void Deposit(string accountNumber, double amount)
        {
            var account = FindAccount(accountNumber);
            if (account != null)
            {
                account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Рахунок не знайдено");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var savingsAccount = new SavingsAccount
            {
                AccountNumber = "SA123",
                HolderName = "Іван Петров",
                Balance = 1000,
                InterestRate = 0.05
            };

            var checkingAccount = new CheckingAccount
            {
                AccountNumber = "CA456",
                HolderName = "Ольга Іванова",
                Balance = 2000,
                OverdraftLimit = 500
            };

            var bank = new Bank();
            bank.AddAccount(savingsAccount);
            bank.AddAccount(checkingAccount);

            bank.PrintAllAccounts();

            bank.Withdraw("SA123", 200);
            bank.Deposit("CA456", 300);

            bank.PrintAllAccounts();

            Console.WriteLine($"Відсотки за рахунком: {savingsAccount.CalculateInterest()}");
        }
    }
}
