﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingCenterForms
{
    public partial class Form1 : Form
    {        
        scheduleView scheduleView1 = new scheduleView();
        AdminLand adminLand1 = new AdminLand();
        AcctManagePage acctManagePage1 = new AcctManagePage();
        AccountDatabase Accounts;
        public Form1()
        {
            InitializeComponent();
            //this.Controls.Add(scheduleView1);
            this.Controls.Add(adminLand1);
            this.Controls.Add(acctManagePage1);
            Accounts.ImportFromCSV(); //for testing
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            if(Accounts.AuthenticateUser(username.Text,password.Text))
            {
                if(Accounts.IsAdmin(username.Text))
                {
                    adminLand1.Show();
                    adminLand1.BringToFront();
                }
                else 
                {
                    scheduleView1.Show();
                    scheduleView1.BringToFront();
                }
                
            }
            else 
            { 
                //display User not authenticated error
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adminLand1.Hide();
            acctManagePage1.Hide();
            scheduleView1.Hide();
            //this.Location = new Point(0,0);
            //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminLogIn_Click(object sender, EventArgs e)
        {
            adminLand1.Show();
            adminLand1.BringToFront();
        }

        private void acctManagePage1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
