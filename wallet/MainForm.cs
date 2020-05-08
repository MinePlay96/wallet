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
    public partial class MainForm : Form
    {
        public static  Currency CUR_EUR = new Currency("EUR", 1.0m);

        private List<User> users = new List<User>();
        
        public MainForm()
        {
            InitializeComponent();
            User simon = new User("Simon");
            DebitAcount simonDebit = new DebitAcount(CUR_EUR, 100.0m, "Sparkasse");
            simon.Wallets.Add(simonDebit);
            simon.Wallets.Add(new OnlineAcount(CUR_EUR, 0.0m, "Simons PayPal", simonDebit));
            User leon = new User("Leon");
            leon.Wallets.Add(new DebitAcount(CUR_EUR, 150.0m, "Ing Diba"));
            users.Add(simon);
            users.Add(leon);
            foreach (User user in users)
            {
                listBox1.Items.Add(user);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            User user = (User) listBox1.SelectedItem;
            foreach (Wallet wallet in user.Wallets)
            {
                listBox2.Items.Add(wallet);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wallet wallet = (Wallet)listBox2.SelectedItem;
            label1.Text = "Balance: " + wallet.Balance.Amount + " " + wallet.Balance.Currency.Name;
        }
    }
}
