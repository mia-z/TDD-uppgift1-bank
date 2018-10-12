namespace BankOfEvil.Domain
{
    public class Account
    {
        public uint AccountNumber { get; }

        public Customer Owner { get; }

        public decimal Balance { get; set; }
        
        public Account(uint accountNumber, Customer owner)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = 1000;
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