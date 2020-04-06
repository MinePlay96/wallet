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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AcountView());
            
            Currency euro = new Currency("euro", 1);
            Currency dollar = new Currency("dollar", 1.08m);

            DebitAcount leons = new DebitAcount(euro, 10.50m, "leons");
            OnlineAcount leonsPaypal = new OnlineAcount(euro, 10, "leons", leons);
            CashWallet simon = new CashWallet(dollar, 0);

            System.Diagnostics.Debug.WriteLine("Leons " + leons.Balance.Amount + leons.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("LeonsPaypal " + leonsPaypal.Balance.Amount + leonsPaypal.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("simon " + simon.Balance.Amount + simon.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("Leons " + "History count: " + leons.History.GetElementCount());
            System.Diagnostics.Debug.WriteLine("LeonsPaypal " + "History count: " + leonsPaypal.History.GetElementCount());

            leonsPaypal.TransferTo(15, simon);

            System.Diagnostics.Debug.WriteLine("Leons " + leons.Balance.Amount + leons.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("LeonsPaypal " + leonsPaypal.Balance.Amount + leonsPaypal.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("simon " + simon.Balance.Amount + simon.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("Leons " + "History count: " + leons.History.GetElementCount());
            System.Diagnostics.Debug.WriteLine("LeonsPaypal " + "History count: " + leonsPaypal.History.GetElementCount());

            simon.TransferTo(5, leons);

            System.Diagnostics.Debug.WriteLine("Leons " + leons.Balance.Amount + leons.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("LeonsPaypal " + leonsPaypal.Balance.Amount + leonsPaypal.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("simon " + simon.Balance.Amount + simon.Balance.Currency.Name);
            System.Diagnostics.Debug.WriteLine("Leons " + "History count: " + leons.History.GetElementCount());
            System.Diagnostics.Debug.WriteLine("LeonsPaypal " + "History count: " + leonsPaypal.History.GetElementCount());
        }
    }
}
