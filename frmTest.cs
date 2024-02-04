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
            // dataGridView1.DataSource = clsOrder.GetAllOrders();

            //find
            //clsOrder order = clsOrder.Find(1);

            //MessageBox.Show(order.TotalAmount.ToString());

            //add new
            //clsOrder order = new clsOrder();

            //order.CustomerID = 1;
            //order.OrderDate = DateTime.Parse("2023-08-01");
            //order.TotalAmount = 350;
            //order.Status = (clsOrder.enStatus)3;

            //if (order.Save())
            //{
            //    MessageBox.Show(order.OrderID.ToString());

            //}
            //else
            //{
            //    MessageBox.Show("dd");
            //}

            // update

            //clsOrder order = clsOrder.Find(1);

            //if (order != null)
            //{
            //    order.CustomerID = 2;
            //    order.OrderDate = DateTime.Parse("2023-08-20");
            //    order.TotalAmount = 552;
            //    order.Status = (clsOrder.enStatus)5;
            //    if (order.Save())
            //    {
            //        MessageBox.Show("Updated");

            //    }
            //    else
            //    {
            //        MessageBox.Show("failed");
            //    }

            // delete

            //bool IsDeleted = clsOrder.DeleteOrder(3);

            //if (IsDeleted)
            //    MessageBox.Show("Deleted");
            //else
            //    MessageBox.Show("Not Deleted");



            }
    }
}
