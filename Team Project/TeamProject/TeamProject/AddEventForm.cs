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
        public AddEventForm()
        {
            this.pageNumber = 1;
            InitializeComponent();
        }
    }
}
