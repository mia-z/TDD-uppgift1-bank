using System;

namespace BankOfEvil.Domain.Services
{
    public class CustomerServices
    {
        public Customer CreateCustomer(string firstName, string lastName, string ssn)
        {
            var customer = new Customer(firstName, lastName, ssn);

            Random r = new Random();
            var accountNumber = (uint)r.Next(10000, 99999);
            
            var account = new Account(accountNumber, customer);
            customer.AddAccount(account);
            return customer;
        }
    }
}