using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    interface IWithdraw
    {
        public Money Withdraw(Money amount);

        public void TransferTo(Money amount, IDeposit toWallet); 
    }
}
