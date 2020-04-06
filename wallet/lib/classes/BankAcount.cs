using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    abstract class BankAcount : Wallet
    {
        public History History { get; protected set; } = new History();

        public BankAcount(Money balance, String name) : base(balance, name)
        {
        }

        public BankAcount(Currency currency, decimal amount, String name) : base(currency, amount, name)
        {
        }

        override public void TransferTo(Money amount, IDeposit toWallet)
        {
            base.TransferTo(amount, toWallet);
            this.History.AddHistoryElement(amount, this, toWallet);
        }
    }
}
