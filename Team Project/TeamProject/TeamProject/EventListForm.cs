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
    public partial class EventListForm : Form
    {
        private List<CalendarEvent> eventList; // pass event list through to prevent unnecessary db calls
        private bool mode; // false for view mode, true for edit mode

        public EventListForm(bool mode)
        {
            this.mode = mode;
            this.eventList = new List<CalendarEvent>();
            InitializeComponent();
            this.FormatEventListBox();
            this.FormatModeButton();
        }
        public EventListForm(List<CalendarEvent> eventList, bool mode)
        {
            this.mode = mode;
            this.eventList = eventList;
            InitializeComponent();
            this.FormatEventListBox();
            this.FormatModeButton();
        }

        private void FormatEventListBox()
        {
            EventListFilteredListBox.DataSource = eventList;
            EventListFilteredListBox.DisplayMember = "Title";

            if(eventList.Count < 1)
            {
                EventListFilteredListBox.Visible = false;
                EventListFilteredNoEventsMessageBox.Visible = true;
                EventListFilteredModeButton.Enabled = false;
            }
        }
        private void EventListFilterByDateButton_Click(object sender, EventArgs e)
        {
            this.EventListFilterDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.EventListFilterDateTimePicker.ShowUpDown = false;
            this.EventListFilterDateTimePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void EventListFilterByMonthButton_Click(object sender, EventArgs e)
        {
            this.EventListFilterDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.EventListFilterDateTimePicker.ShowUpDown = true;
            this.EventListFilterDateTimePicker.CustomFormat = "MM/yyyy";
        }

        private void EventListFilterByYearButton_Click(object sender, EventArgs e)
        {
            this.EventListFilterDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.EventListFilterDateTimePicker.ShowUpDown = true;
            this.EventListFilterDateTimePicker.CustomFormat = "yyyy";
        }

        private void EventListFilteredViewModeCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FormatModeButton()
        {
            if(this.mode) // indicates EDIT
            {
                EventListFilteredModeButton.Text = "Edit";
            } 
        }
        private void EventListFilteredViewButton_Click(object sender, EventArgs e)
        {
            if(this.mode)
            {
                new EventDetailForm(eventList[0], this.mode).Show();
            } else
            {
                new EventDetailForm(eventList[0], this.mode).Show();
            }
        }
    }
}
