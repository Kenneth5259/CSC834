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
        private CalendarEvent ev;
        private bool mode;
        public EventDetailForm(CalendarEvent ev, bool mode)
        {
            this.ev = ev;
            this.mode = mode;
            InitializeComponent();
            this.ConfigureMode();
        }
        private void ConfigureMode()
        {
            
            this.EventDetailsCreatorDynamicLabel.Text = this.ev.createdBy.firstName + " " + this.ev.createdBy.lastName;
            if(this.mode)
            {

                // Make Editing Panels Visible
                this.EventDetailsEditTimeTableLayoutPanel.Visible = true;
                this.EventDetailsEditTitleDynamicTableLayoutPanel.Visible = true;
                this.EventDetailsEditNotesLayoutPanel.Visible = true;

                // Make Unnecessary Panels hidden
                this.EventDetailsNotesTableLayoutPanel.Visible = false;
                this.EventDetailsTimeTableLayoutPanel.Visible = false;

                // Populate Inputs With Existing Information
                this.EventDetailsDynamicTitleTextBox.Text = this.ev.Title;
                this.EventDetailsEditStartTimeDatePicker.Value = DateTime.ParseExact(this.ev.StartTime, "MM/dd/yyyy hh:mm tt", null);
                this.EventDetailsEditEndTimeDatePicker.Value = DateTime.ParseExact(this.ev.EndTime, "MM/dd/yyyy hh:mm tt", null);
                this.EventDetailsEditNotesTextBox.Text = this.ev.EventNotes;

                // Update the Button to reflect a Save Action
                this.EventDetailsDeleteButton.Text = "Confirm";
                this.EventsDetailsCloseButton.Text = "Cancel";
            } else
            {
                this.EventTitleDynamicLabel.Text = this.ev.Title;
                this.EventDetailsStartTimeDynamicLabel.Text = this.ev.StartTime;
                this.EventDetailsEndTimeDynamicLabel.Text = this.ev.EndTime;
                this.EventDetailsNotesDynamicLabel.Text = this.ev.EventNotes;
            }
        }
        private void EventDetailsDeleteButton_Click(object sender, EventArgs e)
        {
            if(this.mode) // edit mode
            {
                if (this.checkConflict())
                {
                    this.EditEventConflictingMessageTableLayoutPanel.Visible = true;
                } else
                {
                    this.SaveEventChanges();
                }
                
            } else
            {
                this.EventDetailsDeletionsConfirmationTableLayoutPanel.Visible = true;
            }
        }

        private bool checkConflict()
        {
            return true;
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
        private void SaveEventChanges()
        {
            this.Close();
        }

        private void EventsDetailsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventConflicNoButton_Click(object sender, EventArgs e)
        {
            this.EditEventConflictingMessageTableLayoutPanel.Visible = false;
        }

        private void EventConflicYesButton_Click(object sender, EventArgs e)
        {
            this.SaveEventChanges();
        }
    }
}
