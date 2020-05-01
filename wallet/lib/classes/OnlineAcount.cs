using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class OnlineAcount:BankAcount, IDeposit, IRequiersSrc
    {
        public BankAcount SrcWallet { get; protected set; }

        public OnlineAcount(Money balance, String name, BankAcount srcWallet) : base(balance, name)
        {
            this.SrcWallet = srcWallet;
        }

        public OnlineAcount(Currency currency, decimal amount, String name, BankAcount srcWallet) : base(currency, amount, name)
        {
            this.SrcWallet = srcWallet;
        }

        public void Deposit(Money amount, Wallet fromWallet)
        {
            this.History.AddHistoryElement(amount, fromWallet, this);
            this.Balance.Add(amount);
        }

        // TODO: add TranferTo override (online can not be to cash)

        override public Money Withdraw(Money amount)
        {
            Money removedMoney = this.Balance.Subtract(amount);
            // check if Online Acount is depledet / then pull money from SrcWallet
            this.Settle();
            return removedMoney;
        }

        public void Settle()
        {
            // if Balance is positive do nothing
            if (this.Balance.Amount >= 0) return;

            // TODO: add logik to add Moneys
            // pull money from src Wallet
            Money missingMoney = new Money(this.Balance.Currency, -this.Balance.Amount);
            this.SrcWallet.TransferTo(missingMoney, this);
        }
    }
}
