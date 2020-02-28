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

        public void TransferTo(Money amount, IDeposit toWallet)
        {
            toWallet.Deposit(this.Withdraw(amount));
        }

        public Money Withdraw(Money amount)
        {
            return this.Balance.Subtract(amount);
        }
    }
}
