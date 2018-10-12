using System;
using BankOfEvil.Domain;

namespace BankOfEvil
{
    class Program
    {
        static void Main(string[] args)
        {
            var JohnDoe = new Domain.Customer("John", "Doe");
            var JaneDoe = new Domain.Customer("Jane", "Doe");
            
            var JohnAccount = new Domain.Account(0001, JohnDoe, 1000);
            var JaneAccount = new Domain.Account(0002, JaneDoe, 1000);
            
            var transaction = new Transaction(100, JohnAccount, JaneAccount, DateTime.Now);

            if (transaction.SourceAccount.Balance >= transaction.Amount)
            {
                transaction.SourceAccount.Balance =- transaction.Amount;
                transaction.DestinationAccount.Balance += transaction.Amount;
            }
        }
    }
}