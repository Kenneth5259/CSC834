using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        //parent form store
        private Form parent;

        // private input string store
        private string inputAmount;

        // store the input
        public AccountTransferForm(Form parent, Account toAccount, Account fromAccount)
        {
            // initialize the component
            InitializeComponent();

            // assign the parent
            this.parent = parent;

            // assign the local to account
            this.toAccount = toAccount;

            // assign the local from account
            this.fromAccount = fromAccount;

            // set the input amount
            this.inputAmount = "0";

            // disable the confirm button until non-0 input
            this.AccountTransferConfirmButton.Enabled = false;
            // update the account labels
            this.updateAccountNumberLabels();

            // update the input label
            this.updateLabel();
        }

        private void AccountDepositTypeMainMenuButton_Click(object sender, EventArgs e)
        {

            // close the parent (Account List)
            this.parent.Close();

            // close itself (Last remaining form should be Main Menu)
            this.Close();
        }

        private void TransferInputClearButton_Click(object sender, EventArgs e)
        {

            // resets input amount
            this.inputAmount = "0";

            // re-enables all buttons on a clear
            this.AccountTransferInputDotButton.Enabled = true;
            this.AccountTransferInput0Button.Enabled = true;
            this.AccountTransferInput1Button.Enabled = true;
            this.AccountTransferInput2Button.Enabled = true;
            this.AccountTransferInput3Button.Enabled = true;
            this.AccountTransferInput4Button.Enabled = true;
            this.AccountTransferInput5Button.Enabled = true;
            this.AccountTransferInput6Button.Enabled = true;
            this.AccountTransferInput7Button.Enabled = true;
            this.AccountTransferInput8Button.Enabled = true;
            this.AccountTransferInput9Button.Enabled = true;

            // disable confirm button
            this.AccountTransferConfirmButton.Enabled = false;

            // update label
            this.updateLabel();
        }

        private void TransferInputDotButton_Click(object sender, EventArgs e)
        {

            // reuse existing code for input amount change and label update
            this.AccountTransferInputButton_Clicked(sender, e);

            // disables additional . to value unless string is cleared/reset
            this.AccountTransferInputDotButton.Enabled = false;
        }

        private void AccountTransferInputButton_Clicked(object sender, EventArgs e)
        {


            if (this.inputAmount == "0" && (sender as Button).Text != ".")
            {

                // replace the value if text is a number and value is exactly 0
                this.inputAmount = (sender as Button).Text;
            }
            else
            {
                // append the value if the value is not exactly 0 or is .
                this.inputAmount = this.inputAmount + (sender as Button).Text;
            }

            // check if there is a decimal in the amount
            if (this.inputAmount.Split('.').Length > 1)
            {
                // check if the amount of "cents" is double digits
                if (this.inputAmount.Split('.')[1].Length == 2)
                {

                    // prevent additional input if 2 decimal places are filled
                    this.AccountTransferInput0Button.Enabled = false;
                    this.AccountTransferInput1Button.Enabled = false;
                    this.AccountTransferInput2Button.Enabled = false;
                    this.AccountTransferInput3Button.Enabled = false;
                    this.AccountTransferInput4Button.Enabled = false;
                    this.AccountTransferInput5Button.Enabled = false;
                    this.AccountTransferInput6Button.Enabled = false;
                    this.AccountTransferInput7Button.Enabled = false;
                    this.AccountTransferInput8Button.Enabled = false;
                    this.AccountTransferInput9Button.Enabled = false;
                }

            }

            this.updateLabel();
        }
        public void updateLabel()
        {
            // Updates the label on the value input screen
            this.AccountTransferInputAmountDynamicLabel.Text = $"${this.inputAmount}";

            // checks if the value is a 0 dollar amount
            if (Double.Parse(this.inputAmount) != 0)
            {

                //allow for a deposit to continue with a non 0 dollar amount
                this.AccountTransferConfirmButton.Enabled = true;
            }
        }

        public void updateAccountNumberLabels()
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

        private void AccountTransferConfirmButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Button Clicked");
            double transferAmount = Double.Parse(this.inputAmount);

            // check for balance error on from account
            if(this.fromAccount.balance < transferAmount)
            {
                // desplace balance amount error
                this.AccountTransferBalanceErrorTableLayoutPanel.Visible = true;
                this.AccountTransferInputTableForm.Visible = false;

                // return the method to prevent any more execution
                return;
            }
            Trace.WriteLine("From Account Balance OKAY");

            // check for transaction limit on both accounts
            if(!(toAccount.withinDailyLimit(transferAmount) && fromAccount.withinDailyLimit(transferAmount)))
            {
                Trace.WriteLine("Outside Daily Limit");
                // display daily limit error
                AccountTransferLimitErrorTableLayoutPanel.Visible = true;

                // hide the input layout
                AccountTransferInputTableForm.Visible = false;

                // return the method to prevent any more execution
                return;
            }
            Trace.WriteLine("Daily Limit OKAY");

            // make the appropriate tablelayoutpanel visible
            AccountTransferConfirmationTableLayoutPanel.Visible = true;
            AccountTransferInputTableForm.Visible = false;




        }

        private void AccountTransferChangeAmountButton_Click(object sender, EventArgs e)
        {
            // clear everything out
            this.TransferInputClearButton_Click(null, null);

            this.AccountTransferConfirmationTableLayoutPanel.Visible = false;
            this.AccountTransferInputTableForm.Visible = true;


        }

        private void AccountTransferFinalizeButto_Click(object sender, EventArgs e)
        {
            // fill in code to update to account

            // fill in code to update from account

            // fill in code to create transaction

            // close the account list
            this.parent.Close();

            // close the transfer form
            this.Close();
        }

        private void AccountTransferLimitMainMenuButton_Click(object sender, EventArgs e)
        {
            // close account list
            this.parent.Close();

            // close this form
            this.Close();
        }

        private void AccountTransferLimitErrorChangeButton_Click(object sender, EventArgs e)
        {
            // reset the input form as if clear had been clicked
            this.TransferInputClearButton_Click(null, null);

            // hide the error table layout panel
            this.AccountTransferLimitErrorTableLayoutPanel.Visible = false;
            this.AccountTransferBalanceErrorTableLayoutPanel.Visible = false;

            // show the input form
            this.AccountTransferInputTableForm.Visible = true;
        }

        
    }
}
