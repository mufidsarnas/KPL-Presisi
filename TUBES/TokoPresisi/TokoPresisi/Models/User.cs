using System;

namespace TokoPresisi.Models
{
    public class User
    {
        public string UserId { get; set; }
        public decimal Balance { get; private set; }

        public User(string userId, decimal initialBalance)
        {
            UserId = userId;
            Balance = initialBalance;
        }

        public void AddBalance(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive", nameof(amount));
            Balance += amount;
        }
    }
}
