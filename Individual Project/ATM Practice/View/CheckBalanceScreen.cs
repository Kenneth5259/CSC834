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
        // local variables for form information and navigation
        private Account selectedAccount;
        private Form parent;
        private Transaction transactionInfo;
        public CheckBalanceScreen(Form parent, int accountNum)
        {

            // designate the parent form
            this.parent = parent;

            // pull the entire account info from the account num, save locally
            this.selectedAccount = new Account().retrieveAccountInformation(accountNum);

            // initialize component
            InitializeComponent();

            // update dynamic label
            CheckBalanceDynamicLabel.Text = $"{this.selectedAccount.balance.ToString("C")}";

            // generate transaction in database
            this.generateTransaction(accountNum);
        }

        // click handler to return to account list
        private void AccBalanceReturnButton_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        // click handler to return to the main menu
        private void AccBalanceMainMenuButton_Click(object sender, EventArgs e)
        {
            this.parent.Close();
            this.Close();
        }

        /**
         * Private method for generating a transaction and calling the model's 
         * function to save the information in the proper table
         * 
         */
        private void generateTransaction(int accountNum)
        {
            // initialize the local variable
            this.transactionInfo = new Transaction();

            // save the current selection as account num
            this.transactionInfo.accountNum = accountNum;

            // save the date, accurate within a few seconds based on runtime
            this.transactionInfo.date = DateTime.Now;

            // check balance does not have a to/from account
            this.transactionInfo.fromAccount = null;
            this.transactionInfo.toAccount = null;

            // check balance is the transaction type
            this.transactionInfo.transactionType = "Check Balance";

            // method to save the transaction
            this.transactionInfo.createTransaction();
        }
    }
}
