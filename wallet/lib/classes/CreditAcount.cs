using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class CreditAcount:BankAcount
    {
        public CreditAcount(Money balance) : base(balance)
        {
        }

        public CreditAcount(Currency currency, double amount) : base(currency, amount)
        {
        }
    }
}
