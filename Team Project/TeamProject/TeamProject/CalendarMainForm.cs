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
    
    public partial class CalendarBaseForm : Form
    {
        // private form for addEventForm
        private Form addEventForm;

        // private current date for calendar population
        private DateTime currentDate;

        // private list of calendar events for gridview
        private List<CalendarEvent> eventList;
        public CalendarBaseForm()
        {
            InitializeComponent();
            this.currentDate = DateTime.Now;
            

            this.eventList = new List<CalendarEvent>();
            this.initCalendarMonth();
            this.initCalendarYear(); 
            this.initCalendarEvents();

        }
        /****** Initialization Functions ******/

        private void initCalendarMonth()
        {
            string month = this.currentDate.ToString("MMMM");
            CalendarMonthLabel.Text = month;

        }
        private void initCalendarYear()
        {
            string year = this.currentDate.Year.ToString();
            YearCalendarLabel.Text = year;
        }

        private void initCalendarEvents()
        {

            this.eventList.Add(new CalendarEvent("Event 1"));
            this.eventList.Add(new CalendarEvent("Super Long Title for resizing"));
            Week1MondayDataGridView.DataSource = this.eventList;
            Week1SundayDataGridview.DataSource = this.eventList;
        }

        /****** Button Click Handlers ******/
        private void ShowCalendarOptionsButton_Click(object sender, EventArgs e)
        {
            ShowCalendarOptionsButton.Visible = false;
            UserCalendarOptionsTableLayoutPanel.Visible = true;
        }
        private void AddNewCalendarEventButton_Click(object sender, EventArgs e)
        {
            // initializes a new AddEventForm on click
            this.addEventForm = new AddEventForm();

            // shows the new form after initialization
            this.addEventForm.Show();

            //test for accessing specific cell of a table layout panel
            CalendarGridTableLayoutPanel.GetControlFromPosition(0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
    class CalendarEvent
    {
        public string name { get; set; }
        public CalendarEvent(string name)
        {
            this.name = name;
        }
    }
}
