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
            //dataGridView1.DataSource = clsOrderItem.GetAllOrderItems();

            //find
            //clsOrderItem item = clsOrderItem.Find(1);

            // MessageBox.Show(item.TotalItemsPrice.ToString());

            //add new
            //clsOrderItem item = new clsOrderItem();

            //item.OrderID = 1;
            //item.ProductID = 1;
            //item.Quantity = 1;
            //item.Price = 552;
            //item.TotalItemsPrice = 552;

            //if (item.Save())
            //{
            //    MessageBox.Show(item.OrderID.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("failed");
            //}

            // update

            //clsOrderItem item = clsOrderItem.Find(5);

            //item.OrderID = 2;
            //item.ProductID = 2;
            //item.Quantity = 2;
            //item.Price = 552;
            //item.TotalItemsPrice = 1104;

            //if (item.Save())
            //{
            //    MessageBox.Show(item.OrderID.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("failed");
            //}

            // delete

            //bool IsDeleted = clsOrderItem.DeleteOrderItem(2);

            //if (IsDeleted)
            //    MessageBox.Show("Deleted");
            //else
            //    MessageBox.Show("Not Deleted");
        }
    }

}
