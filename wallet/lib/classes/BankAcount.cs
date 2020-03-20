using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    abstract class BankAcount : Wallet
    {
        public History History { get; protected set; } = new History();

        public BankAcount(Money balance) : base(balance)
        {
        }

        public BankAcount(Currency currency, double amount) : base(currency, amount)
        {
        }

        override public void TransferTo(Money amount, IDeposit toWallet)
        {
            base.TransferTo(amount, toWallet);
            this.History.AddHistoryElement(amount, this, toWallet);
        }
    }
}
