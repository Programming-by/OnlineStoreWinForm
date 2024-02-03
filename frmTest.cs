using OnlineStoreBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineStoreWinform
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get all
            // dataGridView1.DataSource = clsCustomer.GetAllCustomer();

            //find
            //clsCustomer customer = clsCustomer.Find(1);

            //MessageBox.Show(customer.Email);

            //add new
            //clsCustomer customer = new clsCustomer();

            //customer.Name = "Mahmoud";
            //customer.Email = "Mahmoud@gmail.com";
            //customer.Phone = "55714";
            //customer.Address = "Amman";
            //customer.Username = "MahmoudN";
            //customer.Password = "1234";

            //if (customer.Save())
            //{
            //    MessageBox.Show(customer.CustomerID.ToString());

            //} else
            //{
            //MessageBox.Show("dd");
            //}

            // update

            //clsCustomer customer = clsCustomer.Find(1);

            //if (customer != null)
            //{
            //    customer.Name = "AnasNaa";
            //    customer.Email = "anasnaamneh@gmail.com";
            //    customer.Phone = "5452";
            //    customer.Address = "Madrid";
            //    customer.Username = "AnasNaamneh";
            //    customer.Password = "12345";
            //    if (customer.Save())
            //    {
            //        MessageBox.Show("Updated");

            //    }
            //    else
            //    {
            //        MessageBox.Show("failed");
            //    }

            bool IsDeleted =  clsCustomer.DeleteCustomer(4);

            if (IsDeleted)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");

        



    }
    }
}
