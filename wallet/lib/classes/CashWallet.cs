using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class CashWallet : Wallet, IDeposit
    {
        public CashWallet(Money balance) : base(balance)
        {
        }

        public CashWallet(Currency currency, double amount) : base(currency, amount)
        {
        }

        public void Deposit(Money amount, Wallet fromWallet)
        {
            this.Balance.Add(amount);
        }
    }
}
