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

            this.eventList.Add(new CalendarEvent(
                "Event 1", 
                "04/17/2021 05:30 PM",// MM/dd/yyyy hh:mm tt
                "04/17/2021 05:45 PM", 
                "",
                this.activeUser
                ));
            this.eventList.Add(new CalendarEvent(
                "Event 2",
                "04/18/2021 05:30 PM",// MM/dd/yyyy hh:mm tt
                "04/18/2021 05:45 PM",
                "",
                this.activeUser
                ));
            this.InitDataGridBoxes();
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
            new EventDetailForm(this.eventList[0], VIEW_MODE).Show();
        }

        private void ManagerFilterCalendarEventButton_Click(object sender, EventArgs e)
        {
            // create a new form instance and show it
            new EventListForm(this.eventList, VIEW_MODE).Show();
        }

        private void EditCalendarEventButton_Click(object sender, EventArgs e)
        {
            new EventListForm(this.eventList, EDIT_MODE).Show();
        }
        private void InitDataGridBoxes()
        {
            List<DataGridView> datatGridViews = new List<DataGridView>
            {
                Week1MondayDataGridView,
                Week1TuesdayDataGridView,
                Week1WednesdayDataGridView,
                Week1ThursdayDataGridView,
                Week1FridayDataGridView,
                Week1SaturdayDataGridView,
                Week1SundayDataGridView,

                Week2MondayDataGridView,
                Week2TuesdayDataGridView,
                Week2WednesdayDataGridView,
                Week2ThursdayDataGridView,
                Week2FridayDataGridView,
                Week2SaturdayDataGridView,
                Week2SundayDataGridView,

                Week3MondayDataGridView,
                Week3TuesdayDataGridView,
                Week3WednesdayDataGridView,
                Week3ThursdayDataGridView,
                Week3FridayDataGridView,
                Week3SaturdayDataGridView,
                Week3SundayDataGridView,

                Week4MondayDataGridView,
                Week4TuesdayDataGridView,
                Week4WednesdayDataGridView,
                Week4ThursdayDataGridView,
                Week4FridayDataGridView,
                Week4SaturdayDataGridView,
                Week4SundayDataGridView,

                Week5MondayDataGridView,
                Week5TuesdayDataGridView,
                Week5WednesdayDataGridView,
                Week5ThursdayDataGridView,
                Week5FridayDataGridView,
                Week5SaturdayDataGridView,
                Week5SundayDataGridView,

                Week6MondayDataGridView,
                Week6TuesdayDataGridView,
                Week6WednesdayDataGridView,
                Week6ThursdayDataGridView,
                Week6FridayDataGridView,
                Week6SaturdayDataGridView,
                Week6SundayDataGridView
            };

            foreach (DataGridView dataGrid in datatGridViews)
            {
                dataGrid.DataSource = this.eventList;
                dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDataGridview_CellContentClick);
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    if (dataGrid.Columns[i].DataPropertyName != "Title")
                    {
                        dataGrid.Columns[i].Visible = false;
                    }
                }
            }
            
        }
        /*
         Manager Delete Team Event will use the same route as the standard user delete event except it will only use a list of
         events that span multiple users.
         */
        private void ManagerCancelTeamEventButton_Click(object sender, EventArgs e)
        {
            new EventListForm(this.eventList, VIEW_MODE).Show();
        }
    }
    public class CalendarEvent
    {
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string EventNotes { get; set; }
        public User createdBy { get; set; }

        public CalendarEvent(string title, string start, string end, User creator)
        {
            this.Title = title;
            this.StartTime = start;
            this.EndTime = end;
            this.EventNotes = "";
            this.createdBy = creator;
        }
        public CalendarEvent(string title, string start, string end, string notes, User creator)
        {
            this.Title = title;
            this.StartTime = start;
            this.EndTime = end;
            this.EventNotes = notes;
            this.createdBy = creator;
        }
    }
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int userId { get; set; }
        public int managerId { get; set; }
        public int userType { get; set; } // 1 = User, 2 = Manager

    }
    public class Manager : User
    {
        public string serviceType { get; set; }
    }
}
