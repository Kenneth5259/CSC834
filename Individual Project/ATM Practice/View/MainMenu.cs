using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM_Practice.Model;

namespace ATM_Practice
{
    public partial class MainMenuForm : Form
    {
        private Customer customer;
        public MainMenuForm()
        {
            this.customer = new Customer().getCustomerById(1);
            // initialization of the component
            InitializeComponent();
        }
        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            //CheckBalanceFormTable.Visible = true;
            //MainMenuFormTable.Visible = false;
            new AccountList(this, this.customer, "CheckBalance").Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /************* Functional Requirement 1 ****************************/
    }
}
