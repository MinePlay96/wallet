﻿using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    abstract class BankAcount : Wallet
    {
        protected History History = new History();

        public BankAcount(Money balance) : base(balance)
        {
        }

        public BankAcount(Currency currency, double amount) : base(currency, amount)
        {
        }

        public void TransferTo(Money amount, Wallet:IDeposit toWallet) : base (amount, toWallet)
        {
            if ()
         
            this.History.AddHistoryElement(amount, this, toWallet);
            toWallet.Deposit(this.Withdraw(amount));
        }
    }
}