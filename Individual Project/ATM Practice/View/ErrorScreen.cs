using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Practice
{
    public partial class ErrorScreen : Form
    {
        private string errorText;
        private string buttonText;
        private Form parent;
        private int error;
        public ErrorScreen(Form parent, int err)
        {
            InitializeComponent();
            this.parent = parent;
            this.error = err;
            this.switchOnError();
        }

        // intakes an error code to set the values based on the requirement error
        // error referenced in requirement 5 as 5.5 will be input as 55, requirement 4 as 3.3.1.1 would be 3311
        public void switchOnError()
        {
            switch(this.error)
            {
                case 161:
                    this.errorText = "Account has reached $3000 limit or transaction wlll place account over the $3000 limit";
                    this.buttonText = "Return";
                    break;
                case 55:
                    this.errorText = "You have entered an incorrect PIN. If 3 incorrect PINs are entered in this session, the account will be locked until the bank unlocks the account. Please return to the pin entry screen.";
                    this.buttonText = "PIN Entry Screen";
                    break;

                case 3311:
                    this.errorText = "At least two accounts are required to be held with this bank to initiate a transfer. Please return to the main menu.";
                    this.buttonText = "Main Menu";
                    break;

                default:
                    this.errorText = "An Error has occurred.";
                    this.buttonText = "Return";
                    break;
            }
            ErrorScreenDynamicErrorButton.Text = this.buttonText;
            ErrorScreenDynamicErrorLabel.Text = this.errorText;
        }

        private void ErrorScreenDynamicErrorButton_Click(object sender, EventArgs e)
        {
            switch (this.error)
            {
                case 161:
                    
                    break;
                case 55:
                    
                    break;

                case 3311:

                    // Close the account list
                    this.parent.Close();
                    
                    // close the error screen
                    this.Close();
                    break;

                default:
                    
                    break;
            }

        }
    }
}
