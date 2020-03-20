using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class OnlineAcount: DepositableBankAcount
    {
        public BankAcount SrcWallet { get; protected set; }

        public OnlineAcount(Money balance, BankAcount srcWallet) : base(balance)
        {
            this.SrcWallet = srcWallet;
        }

        public OnlineAcount(Currency currency, double amount, BankAcount srcWallet) : base(currency, amount)
        {
            this.SrcWallet = srcWallet;
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
