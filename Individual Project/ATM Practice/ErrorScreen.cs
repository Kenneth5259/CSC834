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
        public ErrorScreen()
        {
            InitializeComponent();
            this.switchOnError(55);
        }

        // intakes an error code to set the values based on the requirement error
        // error referenced in requirement 5 as 5.5 will be input as 55, requirement 4 as 4.2.1 would be 421
        public void switchOnError(int errorCode)
        {
            switch(errorCode)
            {
                case 55:
                    this.errorText = "You have entered an incorrect PIN. If 3 incorrect PINs are entered in this session, the account will be locked until the bank unlocks the account. Please return to the pin entry screen.";
                    this.buttonText = "PIN Entry Screen";
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
