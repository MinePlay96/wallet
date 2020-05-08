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
        public MainForm()
        {
            InitializeComponent();
            listBox1.Items.Add("Simon");
            listBox1.Items.Add("Leon");
            listBox2.Items.Add("Select User...");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.SelectedItem.ToString().Equals("Simon"))
            {
                listBox2.Items.Add("Simons Paypal");
                listBox2.Items.Add("Simons Girokonto");
            }
            else if (listBox1.SelectedItem.ToString().Equals("Leon"))
            {
                listBox2.Items.Add("Mein Paypal");
                listBox2.Items.Add("Kreditkarte");
                listBox2.Items.Add("Sparkasse Leon");
            }
        }
    }
}
