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
        }
        public EventListForm(List<CalendarEvent> eventList, bool mode)
        {
            this.mode = mode;
            this.eventList = eventList;
            InitializeComponent();
            this.FormatEventListBox();
        }

        private void FormatEventListBox()
        {
            EventListFilteredListBox.DataSource = eventList;
            EventListFilteredListBox.DisplayMember = "name";
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

        private void EventListFilteredViewButton_Click(object sender, EventArgs e)
        {
            new EventDetailForm().Show();
        }
    }
}
