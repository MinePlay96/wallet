using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallet
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Currency euro = new Currency("euro", 1);
            Currency dollar = new Currency("dollar", 1.08);

            CashWallet leons = new CashWallet(euro, 10.50);
            CashWallet simon = new CashWallet(dollar, 0);

            Money toTransfer = new Money(euro, 10);

            leons.TransferTo(toTransfer, simon);
            
            System.Diagnostics.Debug.WriteLine(leons.Balance.Amount + leons.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine(simon.Balance.Amount + simon.Balance.Currency.Name);
        }
    }
}
