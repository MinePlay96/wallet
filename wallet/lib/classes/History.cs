using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class History
    {
        protected List<HistoryElement> HistoryElements = new List<HistoryElement>();

        public void AddHistoryElement (Money amount, Wallet fromWallet, IDeposit toWallet)
        {
            HistoryElements.Add(new HistoryElement(amount, fromWallet, toWallet));
        }

        public int GetElementCount()
        {
            return this.HistoryElements.Count;
        }
    }
}
