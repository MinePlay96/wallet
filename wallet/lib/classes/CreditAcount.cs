using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class CreditAcount:BankAcount
    {
        public CreditAcount(Money balance, String name) : base(balance, name)
        {
        }

        public CreditAcount(Currency currency, decimal amount, String name) : base(currency, amount, name)
        {
        }
    }
}
