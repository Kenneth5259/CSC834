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
        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            //CheckBalanceFormTable.Visible = true;
            //MainMenuFormTable.Visible = false;
            new AccountList().Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /************* Functional Requirement 1 ****************************/
    }
}
