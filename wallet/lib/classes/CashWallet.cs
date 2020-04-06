using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class CashWallet : Wallet, IDeposit
    {
        public CashWallet(Money balance) : base(balance, "Bargeld")
        {
        }

        public CashWallet(Currency currency, decimal amount) : base(currency, amount, "Bargeld")
        {
        }

        public void Deposit(Money amount, Wallet fromWallet)
        {
            this.Balance.Add(amount);
        }
    }
}
