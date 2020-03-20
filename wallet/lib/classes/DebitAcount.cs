using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class DebitAcount : DepositableBankAcount
    {
        public DebitAcount(Money balance) : base(balance)
        {
        }

        public DebitAcount(Currency currency, double amount) : base(currency, amount)
        {
        }
    }
}
