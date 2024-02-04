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
            //dataGridView1.DataSource = clsShipping.GetAllShipping();

            //find
            //clsShipping shipping = clsShipping.Find(1);

            //MessageBox.Show(shipping.CarrierName.ToString());

            //add new
            //clsShipping shipping = new clsShipping();

            //shipping.OrderID = 1;
            //shipping.CarrierName = "Aramex";
            //shipping.TrackingNumber = "248";
            //shipping.ShippingStatus = (clsShipping.enShippingStatus)3;
            //shipping.EstimatedDeliveryDate = DateTime.Parse("2024-03-01");
            //shipping.ActualDeliveryDate = DateTime.Parse("2024-05-02");

            //if (shipping.Save())
            //{
            //    MessageBox.Show(shipping.ShippingID.ToString());

            //}
            //else
            //{
            //    MessageBox.Show("dd");
            //}

            // update

            //clsShipping shipping = clsShipping.Find(1);

            //if (shipping != null)
            //{
            //    shipping.OrderID = 2;
            //    shipping.CarrierName = "Aramex";
            //    shipping.TrackingNumber = "15";
            //    shipping.ShippingStatus = (clsShipping.enShippingStatus) 4;
            //    shipping.EstimatedDeliveryDate = DateTime.Parse("2024-08-20");
            //    shipping.ActualDeliveryDate = null;
            //    if (shipping.Save())
            //    {
            //        MessageBox.Show("Updated");
            //    }
            //    else
            //    {
            //        MessageBox.Show("failed");
            //    }

            // delete

            bool IsDeleted = clsShipping.DeleteShipping(5);

            if (IsDeleted)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");
        }
        }


}
