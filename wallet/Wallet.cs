using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    abstract class Wallet : IWithdraw
    {
        public Money Balance { get; protected set; }

        public Wallet(Money balance)
        {
            this.Balance = balance;
        }

        public Wallet(Currency currency, double amount) : this(new Money(currency, amount))
        {
        }

        public Money Withdraw(Money amount)
        {
            return this.Balance.Subtract(amount);
        }
    }
}
