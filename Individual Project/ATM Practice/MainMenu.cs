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


        /************* Functional Requirement 1 ****************************/
    }
}
