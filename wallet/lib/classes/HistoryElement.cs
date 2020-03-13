using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class HistoryElement
    {
        public Money Amount { get; protected set; }
        public Wallet FromWallet { get; protected set; }
        public Wallet ToWallet { get; protected set; }

        public HistoryElement(Money amount, Wallet fromWallet, Wallet toWallet)
        {
            this.Amount = amount;
            this.FromWallet = fromWallet;
            this.ToWallet = toWallet;
        }
    }
}
