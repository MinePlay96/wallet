using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    interface IWithdraw
    {
        Money Withdraw(Money amount);

        void TransferTo(Money amount, IDeposit toWallet); 
    }
}
