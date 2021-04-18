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
    public partial class AddTeamEventForm : Form
    {
        private List<User> teamMembers;
        private List<DateTime> allSlots;
        private DateTime preferredDate;
        private bool formIsComplete;
        private bool timeSlotSelected;
        public AddTeamEventForm()
        {
            InitializeComponent();
            this.getTeamMembers();
            this.preferredDate = DateTime.Now;
            AddTeamEventTeamMembersCheckBoxList.DataSource = this.teamMembers;
            AddTeamEventTeamMembersCheckBoxList.DisplayMember = "fullName";
            this.findAllSlots();
            this.formIsComplete = true;
            this.timeSlotSelected = true;
            
            if(!formIsComplete)
            {
                AddTeamEventNextButton.Text = "Form is Incomplete!";
                AddTeamEventNextButton.Enabled = false;
            }
            if(!timeSlotSelected)
            {
                AddTeamEventConfirmButton.Text = "No Time Slot Selected";
                AddTeamEventConfirmButton.Enabled = false;
            }
                

            
        }
        private void getTeamMembers()
        {
            this.teamMembers = new List<User>();
            User user1 = new User();
            user1.firstName = "John";
            user1.lastName = "Doe";
            user1.userType = 1;
            user1.userId = 15;
            user1.managerId = 1;

            User user2 = new User();
            user2.firstName = "Jane";
            user2.lastName = "Doe";
            user2.userType = 1;
            user2.userId = 16;
            user2.managerId = 1;

            this.teamMembers.Add(user1);
            this.teamMembers.Add(user2);
        }

        private void AddTeamEventNextButton_Click(object sender, EventArgs e)
        {
            //this.allSlots = new List<DateTime>();
            if(this.allSlots.Count > 0)
            {
                AddTeamEventAvailableSlotsTableLayoutPanel.Visible = true;
            } else
            {
                AddTeamEventErrorTableLayoutPanel.Visible = true;
            }
            
        }

        private void AddTeamEventConfirmButton_Click(object sender, EventArgs e)
        {

            // will add a list of user Ids to the AddEventForm constructor. Add event will then push event to each ID in its instance
            new AddEventForm().Show();
        }

        private void findAllSlots()
        {
            this.allSlots = new List<DateTime>();
            this.allSlots.Add(DateTime.Now);
            this.allSlots.Add(DateTime.Now.AddDays(1));



            AddTeamEventPreferredDateListBox.DataSource = this.onPreferredDate();
            AddTeamEventAfterPreferredDateListBox.DataSource = this.afterPreferredDate();

            AddTeamEventPreferredDateListBox.ClearSelected();
            AddTeamEventAfterPreferredDateListBox.ClearSelected();
        }
        private List<DateTime> onPreferredDate()
        {
            List<DateTime> slots = new List<DateTime>();
            foreach (DateTime d in this.allSlots)
            {
                if (d.Date == this.preferredDate.Date)
                {
                    slots.Add(d);
                }
            }
            return slots;
        }
        private List<DateTime> afterPreferredDate()
        {
            List<DateTime> slots = new List<DateTime>();
            foreach (DateTime d in this.allSlots)
            {
                if (d.Date != this.preferredDate.Date)
                {
                    slots.Add(d);
                }
            }
            return slots;
        }

        private void AddTeamEventNoAvailableErrorButton_Click(object sender, EventArgs e)
        {
            AddTeamEventErrorTableLayoutPanel.Visible = false;
            AddTeamEventAvailableSlotsTableLayoutPanel.Visible = false;
        }
    }
}
