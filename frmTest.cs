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
            //clsReview review = clsReview.Find(1);

            //MessageBox.Show(review.ReviewText.ToString());

            //add new
            //clsReview review = new clsReview();

            //review.ProductID = 2;
            //review.CustomerID = 2;
            //review.ReviewText = "Excellent";
            //review.Rating = 9;
            //review.ReviewDate = DateTime.Parse( "2024-01-15");

            //if (review.Save())
            //{
            //    MessageBox.Show(review.ReviewID.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("failed");
            //}

            // update

            //clsReview review = clsReview.Find(2);

            //review.ProductID = 1;
            //review.CustomerID = 2;
            //review.ReviewText = "Bad";
            //review.Rating = 2;
            //review.ReviewDate = DateTime.Parse("2024-01-04");

            //if (review.Save())
            //{
            //    MessageBox.Show(review.ReviewID.ToString());
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
