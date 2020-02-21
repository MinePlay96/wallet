using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    abstract class BankAcount : Wallet
    {
        public BankAcount(Money balance) : base(balance)
        {
        }

        public BankAcount(Currency currency, double amount) : base(currency, amount)
        {
        }

        protected History History = new History();
    }
}
