using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class HistoryElement
    {
        public Money Amount { get; protected set; }
        public Wallet FromWallet { get; protected set; }
        public IDeposit ToWallet { get; protected set; }

        public HistoryElement(Money amount, Wallet fromWallet, IDeposit toWallet)
        {
            this.Amount = amount;
            this.FromWallet = fromWallet;
            this.ToWallet = toWallet;
        }
    }
}
