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
    public partial class AccountList : Form
    {

        // store the active customer
        private Customer activeCustomer;

        // store the list of accounts held by the user
        private List<int> customerAccounts = new List<int>();

        // store reference to previous/parent form
        private Form parent;

        // store To Account
        private Account toAccount;

        // store From Account
        private Account fromAccount;

        // store the Mode that the list is being used in
        private string mode;

        // constructor without a customer
        public AccountList(Form parent)
        {

            // initialize component
            InitializeComponent();

            // store the parent reference
            this.parent = parent;

            // initialize a customer object
            activeCustomer = new Customer();

            // initialize a list object
            customerAccounts = new List<int>();
            
            // configure the datagridview that holds account list
            this.configureDataGridView();

        }

        // constructor with a customer
        public AccountList(Form parent, Customer c, string mode)
        {

            // initialize a component
            InitializeComponent();

            // store the parent reference
            this.parent = parent;

            // store the mode
            this.mode = mode;

            // store the active customer
            activeCustomer = c;

            // get the acccounts from the account model using the active customer's id
            customerAccounts = new Account().retrieveAccounts(this.activeCustomer.id);

            // configure the datagridview
            this.configureDataGridView();

            // remove default selection
            AccountListDataGridView.ClearSelection();

            // check if its a transfer for appropriate deposit
            if(this.mode == "Transfer")
            {
                AccountListAccountsHeldStaticLabel.Text = "Please select an account to transfer FROM: ";
            }

        }

        // method to create rows for datagridview
        private void configureDataGridView()
        {

            // sets the column reference and title
            AccountListDataGridView.Columns.Add("AccountNumbers", "Account Numbers");

            // increment over the list of accounts
            for(int i = 0; i < customerAccounts.Count; i++)
            {

                // insert the row to the grid with the following format
                AccountListDataGridView.Rows.Add($"Account {customerAccounts[i].ToString("0000000")}");
            }

            // configure the autosize mode for the column
            AccountListDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // set the text alignment for the cells
            AccountListDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        // click handler for account list main menu button
        private void AccountListMainMenuButton_Click(object sender, EventArgs e)
        {

            // show the main menu (parent form)
            this.parent.Show();

            // close the form
            this.Close();
        }


        // form closing handler in case of user closing
        private void AccountList_FormClosing(object sender, FormClosingEventArgs e)
        {

            // show the main menu (parent form)
            this.parent.Show();
        }

        // handler for cell click
        private void AccountListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Trace.WriteLine("Cell Clicked");

            switch(this.mode)
            {
                // Widthdraw Transaction Begins
                case "Withdraw":

                    // pull in the account from id
                    Account acc = new Account().retrieveAccountInformation(this.customerAccounts[e.RowIndex]);
                    
                    // update daily transaction date
                    acc.updateDailyTransactionDate();

                    // check if limit is reached already
                    if(acc.withinDailyLimit(0))
                    {

                        // display withdraw input screen
                        new AccountWithdrawScreen(this, acc).Show();
                        this.Hide();
                    
                    } else
                    {
                        // display daily limit error screen
                        new ErrorScreen(this, 161).Show();
                        this.Hide();
                    }
                    break;

                // Transfer Transaction Begins
                case "Transfer":

                    // check if the to account is elected
                    if (this.fromAccount == null)
                    {
                        // check for the minimum number of accounts
                        if(this.customerAccounts.Count < 2)
                        {
                            this.Hide();
                            new ErrorScreen(this, 3311).Show();
                        }

                        // set a To Account
                        this.fromAccount = new Account().retrieveAccountInformation(this.customerAccounts[e.RowIndex]);

                        // remove the account from the list
                        this.AccountListDataGridView.Rows.RemoveAt(e.RowIndex);

                        // remove the account from the local list
                        this.customerAccounts.RemoveAt(e.RowIndex);

                        // update the label
                        this.AccountListAccountsHeldStaticLabel.Text = "Please select an account to transfer TO: ";


                        // avoid the Hide statemeent for all other cases
                        return;
                    } else
                    {
                        // set the to account
                        this.toAccount = new Account().retrieveAccountInformation(this.customerAccounts[e.RowIndex]);

                        // show the transfer account screen
                        new AccountTransferForm(this, this.toAccount, this.fromAccount).Show();
                    }
                    break;

                // Deposit transaction begins
                case "Deposit":
                    new AccountDepositScreen(this, this.customerAccounts[e.RowIndex]).Show();
                    break;

                // Check Balance will be the default behavior as it is the least intrusive transaction type
                case "CheckBalance":
                default:
                    new CheckBalanceScreen(this, this.customerAccounts[e.RowIndex]).Show();
                    break;
            }
            this.Hide();
        }

    }
}
