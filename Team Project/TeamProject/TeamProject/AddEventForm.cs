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
            this.eventIsConflicting = false;
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

                    if(!this.eventConflictingAcknowledgement)
                    {
                        // does not save event, returns to form without closing form
                        return;
                    }
                }

                //
            } else
            {
                // prompt regarding invalid input selections, prevents form close
                return;
            }

            // if it makes it to the end, will close the form
            this.Close();
        }
    }
}
