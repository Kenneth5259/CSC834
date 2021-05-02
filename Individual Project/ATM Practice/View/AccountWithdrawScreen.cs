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
    public partial class AccountWithdrawScreen : Form
    {
        // local data stores
        private Form parent;
        private Account account;
        private string inputAmount;
        public AccountWithdrawScreen(Form parent, Account account)
        {
            // assign local parent
            this.parent = parent;

            // assign received account
            this.account = account;

            // initialize input amount
            this.inputAmount = "0";

            // initialize component
            InitializeComponent();

            // update label
            this.updateLabel();

            
        }
        private void AccountWithdrawInputClearButton_Click(object sender, EventArgs e)
        {

            // resets input amount
            this.inputAmount = "0";

            // re-enables all buttons on a clear
            this.AccountWithdrawInputDotButton.Enabled = true;
            this.AccountWithdrawInput0Button.Enabled = true;
            this.AccountWithdrawInput1Button.Enabled = true;
            this.AccountWithdrawInput2Button.Enabled = true;
            this.AccountWithdrawInput3Button.Enabled = true;
            this.AccountWithdrawInput4Button.Enabled = true;
            this.AccountWithdrawInput5Button.Enabled = true;
            this.AccountWithdrawInput6Button.Enabled = true;
            this.AccountWithdrawInput7Button.Enabled = true;
            this.AccountWithdrawInput8Button.Enabled = true;
            this.AccountWithdrawInput9Button.Enabled = true;

            // update label
            this.updateLabel();
        }

        private void AccountWithdrawInputDotButton_Click(object sender, EventArgs e)
        {

            // reuse existing code for input amount change and label update
            this.AccountWithdrawInputButton_Clicked(sender, e);

            // disables additional . to value unless string is cleared/reset
            this.AccountWithdrawInputDotButton.Enabled = false;
        }

        private void AccountWithdrawInputButton_Clicked(object sender, EventArgs e)
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
                    this.AccountWithdrawInput0Button.Enabled = false;
                    this.AccountWithdrawInput1Button.Enabled = false;
                    this.AccountWithdrawInput2Button.Enabled = false;
                    this.AccountWithdrawInput3Button.Enabled = false;
                    this.AccountWithdrawInput4Button.Enabled = false;
                    this.AccountWithdrawInput5Button.Enabled = false;
                    this.AccountWithdrawInput6Button.Enabled = false;
                    this.AccountWithdrawInput7Button.Enabled = false;
                    this.AccountWithdrawInput8Button.Enabled = false;
                    this.AccountWithdrawInput9Button.Enabled = false;
                }

            }

            this.updateLabel();
        }
        public void updateLabel()
        {
            // Updates the label on the value input screen
            this.AccountWithdrawInputDynamicLabel.Text = $"${this.inputAmount}";

            // checks if the value is a 0 dollar amount
            if (Double.Parse(this.inputAmount) != 0)
            {

                //  allow for a deposit to continue with a non 0 dollar amount
                this.AccountWithdrawConfirmButton.Enabled = true;
            }
        }

        private void AccountWithdrawConfirmButton_Click(object sender, EventArgs e)
        {
            // parse the double
            double withdrawAmount = Double.Parse(this.inputAmount);

            // check daily limit
            if(!this.account.withinDailyLimit(withdrawAmount))
            {
                // new error screen with daily limit error code
                new ErrorScreen(this, 161).Show();
                this.Hide();

                // reset input so they can try a smaller amount
                this.AccountWithdrawInputClearButton_Click(null, null);
                
                // end the method
                return;
            }

            // check if amount is within account balance
            if(withdrawAmount > this.account.balance)
            {
                new ErrorScreen(this, 1101).Show();
                this.Hide();

                // reset the input
                this.AccountWithdrawInputClearButton_Click(null, null);

                return;
            }

            // check machine balance
            if(withdrawAmount > 100000)
            {
                new ErrorScreen(this, 1111).Show();
                this.Hide();

                // reset the input
                this.AccountWithdrawInputClearButton_Click(null, null);

                return;
            }

            // create transaction

            Transaction t = new Transaction();
            t.accountNum = this.account.accountNum;
            t.date = DateTime.Now;
            t.amount = withdrawAmount;
            t.transactionType = "Withdraw";
            t.toAccount = null;
            t.fromAccount = null;

            // save transaction
            t.createTransaction();

            // update account info
            this.account.balance -= withdrawAmount;
            this.account.dailyTransactionTotal += withdrawAmount;

            // save to database
            this.account.updateAccountInformation();

            // close the account list to return to main menu
            this.parent.Close();

            // close the window
            this.Close();


        }

    }
}
