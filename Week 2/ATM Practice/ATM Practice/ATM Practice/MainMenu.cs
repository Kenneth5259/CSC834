using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Practice
{
    public partial class MainMenuForm : Form
    {
        private AccountList accList;
        public MainMenuForm()
        {
            // initialization of teh component
            InitializeComponent();
            this.accList = new AccountList();
        }

        private void MainMenuFormTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            //CheckBalanceFormTable.Visible = true;
            //MainMenuFormTable.Visible = false;
            Hide();
            this.accList.Show();
        }

        private void TransferMoneyButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void WithdrawMoneyButton_Click(object sender, EventArgs e)
        {
            WithdrawAccountsTableForm.Visible = true;
            MainMenuFormTable.Visible = false;
        }

        private void DepositMoneyButton_Click(object sender, EventArgs e)
        {

        }

        private void AccountsListLabel_Click(object sender, EventArgs e)
        {

        }
        /******************* Functional Requirement 4 *************************/

        private void CheckBalanceFormMainMenuButton_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            MainMenuFormTable.Visible = true;
        }

        private void BalanceCheckAccountListItem6_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            AccountBalanceFormTable.Visible = true;

        }

        private void BalanceCheckAccountListItem5_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            AccountBalanceFormTable.Visible = true;
        }

        private void BalanceCheckAccountListItem3_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            AccountBalanceFormTable.Visible = true;

        }

        private void BalanceCheckAccountListItem4_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            AccountBalanceFormTable.Visible = true;

        }

        private void AccBalanceFormMainMenuButton_Click(object sender, EventArgs e)
        {
            AccountBalanceFormTable.Visible = false;
            MainMenuFormTable.Visible = true;
        }

        private void AccBalanceReturnButton_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = true;
            AccountBalanceFormTable.Visible = false;
        }

        private void BalanceCheckAccountListItem1_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            AccountBalanceFormTable.Visible = true;
        }

        private void BalanceCheckAccountListItem2_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            AccountBalanceFormTable.Visible = true;
        }


        private void AccBalanceSplitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WithdrawAccountListItem1_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawAccountListItem2_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawAccountListItem3_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawAccountListItem4_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawAccountListItem5_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawAccountListItem6_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawFormMainMenuButton_Click(object sender, EventArgs e)
        {
            WithdrawAccountsTableForm.Visible = false;
            MainMenuFormTable.Visible = true;
        }

        private void CheckBalanceFormTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel23_Paint(object sender, PaintEventArgs e)
        {

        }

        /************* Functional Requirement 1 ****************************/
    }
}
