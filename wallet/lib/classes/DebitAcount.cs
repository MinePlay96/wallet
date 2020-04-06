using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class DebitAcount : BankAcount, IDeposit
    {
        public DebitAcount(Money balance, String name) : base(balance, name)
        {
        }

        public DebitAcount(Currency currency, decimal amount, String name) : base(currency, amount, name)
        {
        }

        public void Deposit(Money amount, Wallet fromWallet)
        {
            this.History.AddHistoryElement(amount, fromWallet, this);
            this.Balance.Add(amount);
        }
    }
}
