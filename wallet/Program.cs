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

            DebitAcount leons = new DebitAcount(euro, 10.50);
            CashWallet simon = new CashWallet(dollar, 0);

            leons.TransferTo(10, simon);
            
            System.Diagnostics.Debug.WriteLine("Leons " + leons.Balance.Amount + leons.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("simon " + simon.Balance.Amount + simon.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("Leons " + "History count: " + leons.History.GetElementCount());

            simon.TransferTo(5, leons);

            System.Diagnostics.Debug.WriteLine("Leons " + leons.Balance.Amount + leons.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("simon " + simon.Balance.Amount + simon.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("Leons " + "History count: " + leons.History.GetElementCount());
        }
    }
}
