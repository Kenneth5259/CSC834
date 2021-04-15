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
        public CalendarBaseForm()
        {
            InitializeComponent();

        }

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
        }
    }
}
