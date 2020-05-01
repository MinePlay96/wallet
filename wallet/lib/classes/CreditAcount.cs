using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class CreditAcount: BankAcount, IRequiersSrc
    {
        public BankAcount SrcWallet { get; protected set; }
        public Decimal Condition { get; protected set; }
        public CreditAcount(Money balance, String name, BankAcount srcWallet, Decimal condition) : base(balance, name)
        {
            this.SrcWallet = srcWallet;
            this.Condition = condition;
        }

        public CreditAcount(Currency currency, decimal amount, String name, BankAcount srcWallet, Decimal condition) : base(currency, amount, name)
        {
            this.SrcWallet = srcWallet;
            this.Condition = condition;
        }

        public void Settle()
        {
            if (this.Balance.Amount >= 0)
            {
                return;
            }
            // TODO: add logik to add Moneys
            // pull money from src Wallet
            Money missingMoney = new Money(this.Balance.Currency, -this.Balance.Amount);
            Money withdrawn = this.SrcWallet.Withdraw(missingMoney);

            // pull charged interest from src Wallet
            Money interest = new Money(this.Balance.Currency, -this.Balance.Amount * this.Condition);
            this.SrcWallet.Withdraw(interest);

            // add Money to set money to a value of 0
            this.Balance.Add(withdrawn);
        }
    }
}
