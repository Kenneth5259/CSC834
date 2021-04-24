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
        public ErrorScreen(int err)
        {
            InitializeComponent();
            this.switchOnError(err);
        }

        // intakes an error code to set the values based on the requirement error
        // error referenced in requirement 5 as 5.5 will be input as 55, requirement 4 as 3.3.1.1 would be 3311
        public void switchOnError(int errorCode)
        {
            switch(errorCode)
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
    }
}
