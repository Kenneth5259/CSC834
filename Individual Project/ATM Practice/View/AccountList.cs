using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Practice
{
    public partial class AccountList : Form
    {
        public Form previousForm;
        
        public AccountList()
        {
            InitializeComponent();
        }

        private void WithdrawMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
