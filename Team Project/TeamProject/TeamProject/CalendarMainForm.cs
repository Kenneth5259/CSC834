﻿using System;
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
        public CalendarBaseForm()
        {
            InitializeComponent();

        }

        private void ShowCalendarOptionsButton_Click(object sender, EventArgs e)
        {
            ShowCalendarOptionsButton.Visible = false;
            UserCalendarOptionsTableLayoutPanel.Visible = true;
        }
    }
}
