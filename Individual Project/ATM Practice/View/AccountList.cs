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
        private Customer activeCustomer;
        private List<int> customerAccounts = new List<int>();
        private Form parent;
        public AccountList(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            activeCustomer = new Customer();
            customerAccounts = new List<int>();
            //AccountListDataGridView.DataSource = this.customerAccounts;
            this.configureDataGridView();
        }
        public AccountList(Form parent, Customer c)
        {
            InitializeComponent();
            this.parent = parent;
            activeCustomer = c;
            customerAccounts = new Account().getAllAccounts(this.activeCustomer.id);

            this.configureDataGridView();
            AccountListDataGridView.ClearSelection();

        }

        private void configureDataGridView()
        {
            AccountListDataGridView.Columns.Add("AccountNumbers", "Account Numbers");
            for(int i = 0; i < customerAccounts.Count; i++)
            {
                AccountListDataGridView.Rows.Add($"Account {customerAccounts[i].ToString("0000000")}");
            }
            AccountListDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccountListDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void WithdrawMainMenuButton_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void AccountList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void AccountListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Trace.WriteLine("Cell Clicked");
        }

    }
}
