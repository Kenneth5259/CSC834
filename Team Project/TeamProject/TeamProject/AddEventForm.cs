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
        //integer for tracking page flow in the form
        private int pageNumber;

        //integer for teacking the last page in the form
        private int lastPageNumber = 5;
        public AddEventForm()
        {
            // initialize the page number
            this.pageNumber = 1;

            // initialize component
            InitializeComponent();

            // check initial button visibility
            this.updateButtonVisibility();
        }

        // function to update visibility of both buttons
        private void updateButtonVisibility()
        {
            PreviousPageButton.Visible = this.pageNumber > 1;
            NextPageButton.Visible = this.pageNumber < lastPageNumber;
        }

        //previous button clicked
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            //conditional page decrement (safeguard in case of accidental render)
            if(this.pageNumber > 1)
            {
                this.pageNumber--;
            }
            //update button visibility
            this.updateButtonVisibility();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            // conditional page increment (safeguard in case of accidental render)
            if(this.pageNumber < lastPageNumber)
            {
                this.pageNumber++;
            }
            // update button visibility
            this.updateButtonVisibility();
        }
    }
}
