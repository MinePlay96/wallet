using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class DebitAcount : OnlineAcount, IDeposit
    {
        public DebitAcount(Money balance) : base(balance)
        {
        }

        public DebitAcount(Currency currency, double amount) : base(currency, amount)
        {
        }

        public void Deposit(Money amount, Wallet fromWallet)
        {
            this.History.AddHistoryElement(amount, fromWallet, this);
            this.Balance.Add(amount);
        }
    }
}
