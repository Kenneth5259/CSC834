using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM_Practice.Model;

namespace ATM_Practice
{
    public partial class MainMenuForm : Form
    {
        private Customer customer;
        private Form parent;
        public MainMenuForm(Form parent, Customer customer)
        {
            // store the parent form
            this.parent = parent;

            // store the customer
            this.customer = customer;

            // initialization of the component
            InitializeComponent();
        }
        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            //CheckBalanceFormTable.Visible = true;
            //MainMenuFormTable.Visible = false;
            new AccountList(this, this.customer, "CheckBalance").Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepositMoneyButton_Click(object sender, EventArgs e)
        {
            new AccountList(this, this.customer, "Deposit").Show();
            this.Hide();
        }

        private void TransferMoneyButton_Click(object sender, EventArgs e)
        {
            new AccountList(this, this.customer, "Transfer").Show();
            this.Hide();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Close();
        }

        private void WithdrawMoneyButton_Click(object sender, EventArgs e)
        {
            new AccountList(this, this.customer, "Withdraw").Show();
            this.Hide();
        }
    }
}
