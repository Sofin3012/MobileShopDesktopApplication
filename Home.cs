﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MobilePhone phone = new MobilePhone();
            phone.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

 
        private void button4_Click_1(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
