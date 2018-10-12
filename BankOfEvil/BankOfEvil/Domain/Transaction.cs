using System;

namespace BankOfEvil.Domain
{
    public class Transaction
    {
        public decimal Amount { get; }
        public Account SourceAccount { get; }
        public Account DestinationAccount { get; }
        public DateTime Date { get; }

        public Transaction(decimal amount, Account sourceAccount, Account destinationAccount, DateTime date)
        {
            Amount = amount;
            SourceAccount = sourceAccount;
            DestinationAccount = destinationAccount;
            Date = date;
        }
    }
}