using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Shall return back to the Login page
            //For testing purpose, we stop the application
            Application.Exit();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel3.Visible = true;
        }

       

        private void Button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel1.Visible = true;
            groupBox1.Text = "Welcome to ZZZ Bank.  Please select one of the following services:";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("                            " + "123456789");
            listBox1.Items.Add("                            " + "135792468");
            listBox1.Items.Add("                            " + "246813579");
            listBox1.Items.Add("                            " + "987654321");
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel2.Visible = true;
            groupBox1.Text = "You are in the process of Withdrawal.";
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel1.Visible = true;
            groupBox1.Text = "Welcome to ZZZ Bank.  Please select one of the following services:";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel2.Visible = true;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1)
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "0";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "9";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "8";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "7";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "6";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "5";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "4";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "3";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "2";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else if (textBox1.TextLength <= 3)
                textBox1.Text = textBox1.Text + "1";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel7.Visible = true;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            tableLayoutPanel7.Visible = false;
            tableLayoutPanel1.Visible = true;
        }
    }
}
