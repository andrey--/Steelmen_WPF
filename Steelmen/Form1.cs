using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steelmen
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public void UpdateForm()
        {
            JoesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            BobCashLabel.Text = bob.Name + " has $" + bob.Cash;
            BankCashLabel.Text = "Bank has $" + bank;
        }
        public Form1()
        {
            InitializeComponent();
            joe = new Guy
            {
                Name = "Joe",
                Cash = 50
            };
            bob = new Guy
            {
                Name = "Bob",
                Cash = 100
            };
        }

        private void JoeGetMoney_Click(object sender, EventArgs e)
        {
            if (bank>=10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("No money in the bank");
            }
        }

        private void BobGivesMoney_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
