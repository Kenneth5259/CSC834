﻿using System;
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
        public MainMenuForm()
        {

            // initialization of teh component
            InitializeComponent();
        }

        private void MainMenuFormTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = true;
            MainMenuFormTable.Visible = false;
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

        }

        private void DepositMoneyButton_Click(object sender, EventArgs e)
        {

        }

        private void AccountsListLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            CheckBalanceFormTable.Visible = false;
            MainMenuFormTable.Visible = true;
        }

        private void AccountListItem6_Click(object sender, EventArgs e)
        {

        }

        private void AccountListItem5_Click(object sender, EventArgs e)
        {

        }

        private void AccountListItem3_Click(object sender, EventArgs e)
        {

        }

        private void AccountListItem4_Click(object sender, EventArgs e)
        {

        }
    }
}