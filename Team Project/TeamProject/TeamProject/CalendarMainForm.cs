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
        //declare constants for modes to prevent confusion
        private const bool VIEW_MODE = false;
        private const bool EDIT_MODE = true;


        // private current date for calendar population
        private DateTime currentDate;

        private User activeUser;

        // private list of calendar events for gridview
        private List<CalendarEvent> eventList;
        public CalendarBaseForm()
        {

            // initializes the local user, this test case is for a manager to enable all 5 options
            this.activeUser = new User();
            this.activeUser.firstName = "Test First";
            this.activeUser.lastName = "Test Last";
            this.activeUser.userId = 1;
            this.activeUser.managerId = -1; 
            this.activeUser.userType = 2;
            this.currentDate = DateTime.Now;
            this.eventList = new List<CalendarEvent>();

            // initialize the componenets
            InitializeComponent();

            // set the values for dynamic components
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

            if(this.activeUser.userType == 2)
            {
                ManagerCalendarOptionsTableLayoutPanel.Visible = true;
            } else
            {
                UserCalendarOptionsTableLayoutPanel.Visible = true;
            }
            
        }
        private void AddNewCalendarEventButton_Click(object sender, EventArgs e)
        {
            // create a new form instance and show it
            new AddEventForm().Show();
        }

        private void EventDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // create a new form instance and show it
            new EventDetailForm().Show();
        }

        private void ManagerFilterCalendarEventButton_Click(object sender, EventArgs e)
        {
            // create a new form instance and show it
            new EventListForm(this.eventList, VIEW_MODE).Show();
        }

    }
    public class CalendarEvent
    {
        public string name { get; set; }
        public CalendarEvent(string name)
        {
            this.name = name;
        }
    }
    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int userId { get; set; }
        public int managerId { get; set; }
        public int userType { get; set; } // 1 = User, 2 = Manager

    }
    class Manager : User
    {
        public string serviceType { get; set; }
    }
}
