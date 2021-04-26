using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ATM_Practice.Model;

namespace ATM_Practice
{
    public partial class CheckBalanceScreen : Form
    {
        private Account selectedAccount;
        private Form parent;
        public CheckBalanceScreen(Form parent, int accountNum)
        {
            this.parent = parent;
            this.selectedAccount = new Account().getAccountById(accountNum);
            InitializeComponent();
            CheckBalanceDynamicLabel.Text = $"{this.selectedAccount.balance.ToString("C")}";
        }

        private void AccBalanceReturnButton_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void AccBalanceMainMenuButton_Click(object sender, EventArgs e)
        {
            this.parent.Close();
            this.Close();
        }
    }
}
