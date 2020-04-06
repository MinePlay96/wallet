using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class OnlineAcount:BankAcount, IDeposit
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
            if (this.Balance.Amount >= 0)
            {
                return removedMoney;
            }
            Money missingMoney = new Money(this.Balance.Currency, -this.Balance.Amount);
            this.SrcWallet.TransferTo(missingMoney, this);
            return removedMoney;
        }
    }
}
