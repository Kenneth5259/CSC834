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
    public partial class AddEventForm : Form
    {
        private bool formIsValid;
        private bool eventIsConflicting;
        private bool eventConflictingAcknowledgement;
        public AddEventForm()
        {
            // initialize component
            InitializeComponent();
            this.formIsValid = true;
            this.eventIsConflicting = true;
            this.eventConflictingAcknowledgement = false;
        }

        private void AddEventCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEventConfirmButton_Click(object sender, EventArgs e)
        {
            if(this.formIsValid)
            {
                if(this.eventIsConflicting)
                {
                    // load confirmation form for conflicting event
                    // will set the eventConflictingAcknowledgement flag based on user response
                    this.AddEventConflictingMessageTableLayoutPanel.Visible = true;
                    
                    return;
                }

                //
            } else
            {
                // prompt regarding invalid input selections, prevents form close
                return;
            }

            // if it makes it to the end, event will save and will close the form
            this.SaveEvent();
        }

        // click handler to ensure that the Acknowledgement is false
        private void EventConflicNoButton_Click(object sender, EventArgs e)
        {
            this.eventConflictingAcknowledgement = false;

            // return to the Form
            this.AddEventConflictingMessageTableLayoutPanel.Visible = false;
        }

        // click handler to set the acknowledgement to true, set the visibility to false and to save the event
        private void EventConflicYesButton_Click(object sender, EventArgs e)
        {
            this.eventConflictingAcknowledgement = true;
            this.AddEventConflictingMessageTableLayoutPanel.Visible = false;
            this.SaveEvent();
        }

        // save the event to the data base and close the form
        private void SaveEvent()
        {
            // Save Event to SQL
            
            // Close the From and return to calendar
            this.Close();
        }
    }
}
