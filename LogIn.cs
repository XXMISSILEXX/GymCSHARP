﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
                MessageBox.Show("Missing information!");
            else if (UidTb.Text == "Admin" && PassTb.Text == "123")
            {
                ProgressBar pgB = new ProgressBar();
                pgB.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong Username or Password !");
        }
    }
}
