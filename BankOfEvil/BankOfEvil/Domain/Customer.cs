using System.Collections.Generic;
using System.Dynamic;

namespace BankOfEvil.Domain
{
    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SSN { get; }
        public List<Account> Accounts { get; } = new List<Account>();

        public Customer(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
            
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}