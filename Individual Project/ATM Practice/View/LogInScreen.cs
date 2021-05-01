using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Practice
{
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();

            // simulate the time to insert a card
            System.Threading.Tasks.Task.Delay(new TimeSpan(0, 0, 5)).ContinueWith(o => { this.simulateCardInsert(); });
        }
        private void simulateCardInsert()
        {
            // Use method invoker to avoid cross thread exception
            this.Invoke(new MethodInvoker(delegate ()
            {
                // make the pin entry visible 
                LoginScreenPinEntryTableLayoutPanel.Visible = true;

                // hide the card insertion prompt
                LoginScreenInsertCardTableLayoutPanel.Visible = false;
            }));

        }
    }
}
