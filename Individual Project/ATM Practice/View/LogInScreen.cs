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
    public partial class LogInScreen : Form
    {
        // customer Id
        private int customerId;

        // local store for the customer
        private Customer customer;

        // lcoal store for the user input
        private string userInput;

        public LogInScreen()
        {
            // initialize component
            InitializeComponent();

            // Initialize user input
            this.userInput = "";

            // update the label
            this.updatePinLabel();

            // simulate the time to insert a card
            System.Threading.Tasks.Task.Delay(new TimeSpan(0, 0, 5)).ContinueWith(o => { this.simulateCardInsert(); });
        }
        private void simulateCardInsert()
        {
            // Use method invoker to avoid cross thread exception
            this.Invoke(new MethodInvoker(delegate ()
            {
                //simulate the card belonging to customer id 1 
                this.customerId = 1;

                //grab user by id
                this.customer = new Customer().getCustomerById(1);

                // make the pin entry visible 
                LoginScreenPinEntryTableLayoutPanel.Visible = true;

                // hide the card insertion prompt
                LoginScreenInsertCardTableLayoutPanel.Visible = false;
            }));

        }
        private void updatePinLabel()
        {
            // update the label
            LoginScreenPinEntryDynamicLabel.Text = this.mask();
        }

        // basic method to return an * for each digit entered
        private string mask()
        {

            // empty string
            string s = "";

            // loop over the lenght of the current input
            for(int i = 0; i < userInput.Length; i++)
            {

                // add *
                s += "*";
            }

            // return the string
            return s;
        }

        private void LogInScreenClearButton_Click(object sender, EventArgs e)
        {
            // reset the input
            this.userInput = "";

            // reset the label
            this.updatePinLabel();

            // disable the confirm button
            LogInScreenEnterButton.Enabled = false;

            // disable the clear button
            LogInScreenClearButton.Enabled = false;

            // enable all numeric buttons
            LogInScreen1Button.Enabled = true;
            LogInScreen2Button.Enabled = true;
            LogInScreen3Button.Enabled = true;
            LogInScreen4Button.Enabled = true;
            LogInScreen5Button.Enabled = true;
            LogInScreen6Button.Enabled = true;
            LogInScreen7Button.Enabled = true;
            LogInScreen8Button.Enabled = true;
            LogInScreen9Button.Enabled = true;
            LogInScreen0Button.Enabled = true;
        }

        private void LogInScreenEnterButton_Click(object sender, EventArgs e)
        {
            if (this.customer.validatePin(this.userInput))
            {
                // if valid open the main menu
                Trace.WriteLine("Pin is valid");

                new MainMenuForm(this, this.customer).Show();
                this.Hide();
            } else
            {
                // display incorrect pin error message
                Trace.WriteLine("Pin is invalid");

                // check if the failed pin count is within the limit
                if(this.customer.failedPinCount < 3)
                {

                    // display error and prompt for additional input
                    new ErrorScreen(this, 55).Show();

                    // hide the login screen until error is closed
                    this.Hide();

                    // reset the input screen
                    this.LogInScreenClearButton_Click(null, null);

                } else
                {
                    // display the account locked 
                    this.Close();
                }
            }
        }

        private void LogInScreenNumber_Click(object sender, EventArgs e)
        {
            // append the text value from the number clicked
            this.userInput += (sender as Button).Text;

            // validate that there is something to clear
            if(this.userInput.Length > 0)
            {
                LogInScreenClearButton.Enabled = true;
            }

            // validate that length is at max 
            if(this.userInput.Length == 4)
            {

                // pin must be 4 digit for the enter to enable
                LogInScreenEnterButton.Enabled = true;

                // max pin is 4 digits so disabled until clear or enter
                LogInScreen1Button.Enabled = false; 
                LogInScreen2Button.Enabled = false;
                LogInScreen3Button.Enabled = false;
                LogInScreen4Button.Enabled = false;
                LogInScreen5Button.Enabled = false;
                LogInScreen6Button.Enabled = false;
                LogInScreen7Button.Enabled = false;
                LogInScreen8Button.Enabled = false;
                LogInScreen9Button.Enabled = false;
                LogInScreen0Button.Enabled = false;
            }

            // update the pin label
            this.updatePinLabel();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // make sure there is no crash if closed before pin entry
            if(this.customer != null)
            {
                // set the last sign off time
                this.customer.lastSignOff = DateTime.Now;

                // save the customer's new info to the database
                this.customer.updateCustomerInformation();
            }
            

            

        }
    }
}
