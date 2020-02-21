using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class OnlineAcount:BankAcount
    {
        public OnlineAcount(Money balance) : base(balance)
        {
        }

        public OnlineAcount(Currency currency, double amount) : base(currency, amount)
        {
        }
    }
}
