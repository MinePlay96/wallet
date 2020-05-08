using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    abstract class Wallet : IWithdraw
    {
        public Money Balance { get; protected set; }
        public String Name { get; protected set; }

        public Wallet(Money balance, String name)
        {
            this.Balance = balance;
            this.Name = name;
        }

        public Wallet(Currency currency, decimal amount, String name) : this(new Money(currency, amount), name)
        {
        }

        virtual public void TransferTo(Money amount, IDeposit toWallet)
        {
            toWallet.Deposit(this.Withdraw(amount), this);
        }

        /*
         * Just for Testing Porpuise do not USE in Application
         */
        public void TransferTo(decimal amount, IDeposit toWallet)
        {
            Money moneyAmount = new Money(this.Balance.Currency, amount);
            this.TransferTo(moneyAmount, toWallet);
        }

        virtual public Money Withdraw(Money amount)
        {
            return this.Balance.Subtract(amount);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
