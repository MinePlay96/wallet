using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class History
    {
        protected List<HistoryElement> HistoryElements = new List<HistoryElement>();

        public void AddHistoryElement (Money amount, Wallet fromWallet, Wallet toWallet)
        {
            HistoryElements.Add(new HistoryElement(amount, fromWallet, toWallet));
        }
    }
}
