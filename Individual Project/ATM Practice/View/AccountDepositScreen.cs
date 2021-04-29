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
    public partial class AccountDepositScreen : Form
    {

        // store for local variables
        private Form parent;
        private Account account;
        private Transaction transaction;
        private string inputAmount;
        private List<string> storedDeposits;
        private string totalAmount;
        public AccountDepositScreen(Form parent, int accountNum)
        {
            // save previous form reference as parent
            this.parent = parent;

            // retrieve account from DB
            this.account = new Account().retrieveAccountInformation(accountNum);

            // initial input amount should be 0
            this.inputAmount = "0";

            // create a list of deposits since multple desosits can be handled
            this.storedDeposits = new List<string>();


            // initialize the components
            InitializeComponent();
        }

        private void AccountDepositTypeMainMenuButton_Click(object sender, EventArgs e)
        {

            // close the parent (Account List)
            this.parent.Close();

            // close itself (Last remaining form should be Main Menu)
            this.Close();
        }

        private void AccountDepositTypeCheckButton_Click(object sender, EventArgs e)
        {

            // Make input screen visible and update synamic label
            this.AccountDepositAmountTableLayoutPanel.Visible = true;
            this.updateLabel();
            
            this.AccountDepositTypeTableLayoutPanel.Visible = false;
            this.AccountDepositConfirmButton.Enabled = false;
        }

        private void AccountDepositInputClearButton_Click(object sender, EventArgs e)
        {

            // resets input amount
            this.inputAmount = "0";

            // re-enables all buttons on a clear
            this.AccountDepositInputDotButton.Enabled = true;
            this.AccountDepositInput0Button.Enabled = true;
            this.AccountDepositInput1Button.Enabled = true;
            this.AccountDepositInput2Button.Enabled = true;
            this.AccountDepositInput3Button.Enabled = true;
            this.AccountDepositInput4Button.Enabled = true;
            this.AccountDepositInput5Button.Enabled = true;
            this.AccountDepositInput6Button.Enabled = true;
            this.AccountDepositInput7Button.Enabled = true;
            this.AccountDepositInput8Button.Enabled = true;
            this.AccountDepositInput9Button.Enabled = true;

            // update label
            this.updateLabel();
        }

        private void AccountDepositInputDotButton_Click(object sender, EventArgs e)
        {

            // reuse existing code for input amount change and label update
            this.AccountDepositInputButton_Clicked(sender, e);

            // disables additional . to value unless string is cleared/reset
            this.AccountDepositInputDotButton.Enabled = false;
        }

        private void AccountDepositInputButton_Clicked(object sender, EventArgs e)
        {
           

            if(this.inputAmount == "0" && (sender as Button).Text != ".")
            {

                // replace the value if text is a number and value is exactly 0
                this.inputAmount = (sender as Button).Text;
            } else
            {
                // append the value if the value is not exactly 0 or is .
                this.inputAmount = this.inputAmount + (sender as Button).Text;
            }

            // check if there is a decimal in the amount
            if(this.inputAmount.Split('.').Length > 1)
            {
                // check if the amount of "cents" is double digits
                if(this.inputAmount.Split('.')[1].Length == 2)
                {

                    // prevent additional input if 2 decimal places are filled
                    this.AccountDepositInput0Button.Enabled = false;
                    this.AccountDepositInput1Button.Enabled = false;
                    this.AccountDepositInput2Button.Enabled = false;
                    this.AccountDepositInput3Button.Enabled = false;
                    this.AccountDepositInput4Button.Enabled = false;
                    this.AccountDepositInput5Button.Enabled = false;
                    this.AccountDepositInput6Button.Enabled = false;
                    this.AccountDepositInput7Button.Enabled = false;
                    this.AccountDepositInput8Button.Enabled = false;
                    this.AccountDepositInput9Button.Enabled = false;
                }
                
            }
            
            this.updateLabel();
        }
        public void updateLabel()
        {
            // Updates the label on the value input screen
            this.AccountDepositAmountDynamicLabel.Text = $"${this.inputAmount}";

            // checks if the value is a 0 dollar amount
            if(Double.Parse(this.inputAmount) != 0)
            {

                //  allow for a deposit to continue with a non 0 dollar amount
                this.AccountDepositConfirmButton.Enabled = true;
            }
        }

        private void AccountDepositConfirmButton_Click(object sender, EventArgs e)
        {
            // Make the check deposit prompt visible
            this.AccountDepositCheckPromptTableLayoutPanel.Visible = true;

            // Make the previous deposit input not visible
            this.AccountDepositAmountTableLayoutPanel.Visible = false;

            // simulate the time to insert a check
            System.Threading.Tasks.Task.Delay(new TimeSpan(0, 0, 5)).ContinueWith(o => { this.simulateDepositInput(); });
        }

        private void AccountDepositCheckPromptReturnButton_Click(object sender, EventArgs e)
        {
            // hide the prompt
            this.AccountDepositCheckPromptTableLayoutPanel.Visible = false;

            // reset the amount 
            this.inputAmount = "0";

            // update label even if table layout is hidden
            this.updateLabel();

            // present type of deposit menu
            this.AccountDepositTypeTableLayoutPanel.Visible = true;
        }
        
        private void simulateDepositInput()
        {
            // check if someone has not navigated away by return button
            if (this.AccountDepositCheckPromptTableLayoutPanel.Visible || this.AccountDepositCashDepositTableLayoutPanel.Visible)
            {
                
                // Use method invoker to avoid cross thread exception
                this.Invoke(new MethodInvoker(delegate()
                {
                    // remove the prompt
                    this.AccountDepositCheckPromptTableLayoutPanel.Visible = false;
                    this.AccountDepositCashDepositTableLayoutPanel.Visible = false;
                    
                    // present the confirmation
                    this.AccountDepositAdditionalTableLayoutPanel.Visible = true;

                    // save the previous input amount for running total
                    this.storedDeposits.Add(this.inputAmount);

                    // reset input amount for addtional deposit
                    this.inputAmount = "0";

                    // re-enables all buttons on input screen
                    this.AccountDepositInputDotButton.Enabled = true;
                    this.AccountDepositInput0Button.Enabled = true;
                    this.AccountDepositInput1Button.Enabled = true;
                    this.AccountDepositInput2Button.Enabled = true;
                    this.AccountDepositInput3Button.Enabled = true;
                    this.AccountDepositInput4Button.Enabled = true;
                    this.AccountDepositInput5Button.Enabled = true;
                    this.AccountDepositInput6Button.Enabled = true;
                    this.AccountDepositInput7Button.Enabled = true;
                    this.AccountDepositInput8Button.Enabled = true;
                    this.AccountDepositInput9Button.Enabled = true;

                    // update label for input screen
                    this.updateLabel();

                    // Change dynamic label to running total
                    double total = 0;
                    foreach(string s in this.storedDeposits)
                    {
                        total += Double.Parse(s);
                    }
                    this.totalAmount = total.ToString("C");
                    this.AccountDepositAdditionalDynamicLabel.Text = this.totalAmount;
                }));

            }
        }

        private void AccountDepositAdditionalDepositButton_Click(object sender, EventArgs e)
        {
            // make desposit type table visible
            this.AccountDepositTypeTableLayoutPanel.Visible = true;

            // hide this table layout panel
            this.AccountDepositAdditionalTableLayoutPanel.Visible = false;

        }

        private void AccountDepositAdditionalCompleteButton_Click(object sender, EventArgs e)
        {
            // hide the current table layout panel
            this.AccountDepositAdditionalTableLayoutPanel.Visible = false;


            // make the finalize screen visible
            this.AccountDepositFinalizeTableLayoutPanel.Visible = true;

            // make label reflect total amount
            this.AccountDepositFinalizeDynamicLabel.Text = this.totalAmount;
        }

        private void AccountDepositFinalizeReturnButton_Click(object sender, EventArgs e)
        {
            // hide the current layout panel
            this.AccountDepositFinalizeTableLayoutPanel.Visible = false;

            // return to last visible screen
            this.AccountDepositAdditionalTableLayoutPanel.Visible = true;
        }

        private void AccountDepositFinalizeDepositButton_Click(object sender, EventArgs e)
        {
            // create a new transaction
            this.transaction = new Transaction();

            //save the relevant information
            this.transaction.accountNum = this.account.accountNum;
            this.transaction.date = DateTime.Now;
            this.transaction.transactionType = "Deposit";
            this.transaction.amount = Double.Parse(this.totalAmount, System.Globalization.NumberStyles.Currency);
            this.transaction.toAccount = null;
            this.transaction.fromAccount = null;

            // write to database
            this.transaction.createTransaction();

            // update pendingDepositAmount
            this.account.pendingDepositAmount += Double.Parse(this.totalAmount, System.Globalization.NumberStyles.Currency);
            
            // run SQL update
            this.account.updatePendingDeposit();

            // Close Account List
            this.parent.Close();

            // Close Self (Returns to main menu)
            this.Close();
        }

        private void AccountDepositCashDepositReturnButton_Click(object sender, EventArgs e)
        {

            // hide the current panel
            this.AccountDepositCashDepositTableLayoutPanel.Visible = false;

            // show the previous panel
            this.AccountDepositTypeTableLayoutPanel.Visible = true;
        }

        private void AccountDepositTypeCashButton_Click(object sender, EventArgs e)
        {
            // Make the cash deposit prompt visible
            this.AccountDepositCashDepositTableLayoutPanel.Visible = true;

            // Make the previous deposit input not visible
            this.AccountDepositTypeTableLayoutPanel.Visible = false;

            // Randomize a currency string to simulate a random cash deposit
            this.inputAmount = (new Random().NextDouble()*100).ToString("0.00");

            // simulate the time to insert cash
            System.Threading.Tasks.Task.Delay(new TimeSpan(0, 0, 5)).ContinueWith(o => { this.simulateDepositInput(); });
        }
    }
}
