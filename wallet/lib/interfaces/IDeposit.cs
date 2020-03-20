using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    interface IDeposit
    {
        public void Deposit(Money amount, Wallet fromWallet);
    }
}
