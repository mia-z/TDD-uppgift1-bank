namespace BankOfEvil.Domain
{
    public class Account
    {
        public uint AccountNumber { get; }

        public Customer Owner { get; }

        public decimal Balance { get; set; }
        
        public Account(uint accountNumber, Customer owner, decimal balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }
    }
}