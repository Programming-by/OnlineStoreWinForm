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
            // dataGridView1.DataSource = clsProductImages.GetAllProductImages();

            //find
            //clsProductImages productimages = clsProductImages.Find(1);

            //MessageBox.Show(productimages.ProductID.ToString());

            //add new
            //clsProductImages productimages = new clsProductImages();

            //productimages.ImageURL = "f:\\ ";
            //productimages.ImageOrder = 1;
            //productimages.ProductID = 2;

            //if (productimages.Save())
            //{
            //    MessageBox.Show(productimages.ID.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("failed");
            //}

            // update

            //clsProductImages productimages = clsProductImages.Find(1);

            //if (productimages != null)
            //{
            //    productimages.ImageURL = "E:\\";
            //    productimages.ImageOrder = 1;
            //    productimages.ProductID = 1;

            //    if (productimages.Save())
            //    {
            //        MessageBox.Show("Updated");
            //    }
            //    else
            //    {
            //        MessageBox.Show("failed");
            //    }
            //}

            // delete

            bool IsDeleted = clsProductImages.DeleteProductImages(3);

            if (IsDeleted)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");
        }
    }

}
