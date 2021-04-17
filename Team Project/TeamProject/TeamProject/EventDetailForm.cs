using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class EventDetailForm : Form
    {
        public EventDetailForm()
        {
            InitializeComponent();
        }

        private void EventDetailsDeleteButton_Click(object sender, EventArgs e)
        {
            this.EventDetailsDeletionsConfirmationTableLayoutPanel.Visible = true;
        }

        private void EventDetailsDeletionConfirmationNoButton_Click(object sender, EventArgs e)
        {
            this.EventDetailsDeletionsConfirmationTableLayoutPanel.Visible = false;
        }

        private void EventDetailsDeletionConfirmationYesButton_Click(object sender, EventArgs e)
        {
            this.DeleteEvent();
        }

        private void DeleteEvent()
        {
            // Execute SQL to DELEETE EVENT

            // Set the visibility flase
            this.EventDetailsDeletionsConfirmationTableLayoutPanel.Visible = false;

            // close the window
            this.Close();
        }
    }
}
