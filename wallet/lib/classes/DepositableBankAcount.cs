using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    abstract class DepositableBankAcount : BankAcount, IDeposit
    {

        public DepositableBankAcount(Money balance) : base(balance)
        {
        }

        public DepositableBankAcount(Currency currency, double amount) : base(currency, amount)
        {
        }

        public void Deposit(Money amount, Wallet fromWallet)
        {
            this.History.AddHistoryElement(amount, fromWallet, this);
            this.Balance.Add(amount);
        }
    }
}
