using System;
using BankOfEvil.Domain;
using BankOfEvil.Domain.Services;

namespace BankOfEvil
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerServices = new CustomerServices();

            var JohnDoe = customerServices.CreateCustomer("John", "Doe", "123456789");
            var JaneDoe = customerServices.CreateCustomer("Jane", "Doe", "987654321");
            
            PerformTransaction(JohnDoe.Accounts[0], JaneDoe.Accounts[0], 100);
            
            Console.WriteLine($"John's account balance: {JohnDoe.Accounts[0].Balance}");
            Console.WriteLine($"Jane's account balance: {JaneDoe.Accounts[0].Balance}");
            Console.ReadLine();
        }
        
        static void PerformTransaction(Account sourceAccount, Account destinationAccount, decimal amount)
        {
            var transaction = new Transaction(amount, sourceAccount, destinationAccount, DateTime.Now);
            if (transaction.SourceAccount.Balance >= transaction.Amount)
            {
                transaction.SourceAccount.Balance -= transaction.Amount;
                transaction.DestinationAccount.Balance += transaction.Amount;
                Console.WriteLine("Successfully transferred money");
            }
            else
            {
                Console.WriteLine("Failed to transfer money");
            }
        }
    }
}