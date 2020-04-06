using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallet
{
    public partial class AcountView : Form
    {
        private Wallet Acount;
        public AcountView()
        {
            InitializeComponent();
            Currency euro = new Currency("euro", 1);
            this.Acount = new DebitAcount(euro, 10, "leons Debit");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Name.Text = Acount.Name;
            this.CurrencyName.Text = Acount.Balance.Currency.Name;
            this.Amount.Text = Acount.Balance.Amount.ToString();
        }

        private void changeAcount(decimal amount)
        {
            Money change = new Money(this.Acount.Balance.Currency, amount);
            this.Acount.Balance.Add(change);
            this.Amount.Text = this.Acount.Balance.Amount.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            changeAcount(this.ChangeAmount.Value);
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            changeAcount(-this.ChangeAmount.Value);
        }
    }
}
