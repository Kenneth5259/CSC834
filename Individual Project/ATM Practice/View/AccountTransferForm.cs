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
    public partial class AccountTransferForm : Form
    {
        // private store for to/from account
        private Account toAccount;
        private Account fromAccount;
        public AccountTransferForm(Account toAccount, Account fromAccount)
        {
            // initialize the component
            InitializeComponent();

            // assign the local to account
            this.toAccount = toAccount;

            // assign the local from account
            this.fromAccount = fromAccount;

            // update the Input Label
            this.updateInputLabel();
        }

        public void updateInputLabel()
        {

            // local masked string variables to perform formatting
            string maskedTo, maskedFrom;

            // init with the string value of the account num 9 digit
            // (not smaller digit amoutn for long term growth of account numbers)
            // reduce to 6 characters for label size
            maskedFrom = this.fromAccount.accountNum.ToString("000000000").Substring(6);
            maskedTo = this.toAccount.accountNum.ToString("000000000").Substring(6);

            // mask first 6 digits of account number
            maskedFrom = "XXX" + maskedFrom;
            maskedTo = "XXX" + maskedTo;

            // update the label to have the account number
            this.AccountTransferFromDynamicLabel.Text = $"FROM:    {maskedFrom}";
            this.AccountTransferToDynamicLabel.Text = $"TO:    {maskedTo}";
        }
    }
}
