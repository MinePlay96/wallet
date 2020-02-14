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
            Currency doller = new Currency("dolar", 1.08);
            Currency pfund = new Currency("Pfund", 0.83);
            Money amountOne = new Money(doller, 10);
            Money amountToo = new Money(pfund, 0);
            Money schiebung = amountOne.substract(5);
            amountToo.Add(schiebung);
            
            System.Diagnostics.Debug.WriteLine(amountToo.Amount);
        }
    }
}
