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
            // dataGridView1.DataSource = clsProductCatalog.GetAllProductCatalogs();

            //find
            //clsProductCatalog productcatalog = clsProductCatalog.Find(1);

            //MessageBox.Show(productcatalog.ProductName.ToString());

            //add new
            //clsProductCatalog productcatalog = new clsProductCatalog();

            //productcatalog.ProductName = "Pride and Prejudice ";
            //productcatalog.Description = "book";
            //productcatalog.Price = 15;
            //productcatalog.QuantityInStock = 1;
            //productcatalog.ImageURL = "c:\\";
            //productcatalog.CategoryID = 2;

            //if (productcatalog.Save())
            //{
            //    MessageBox.Show(productcatalog.ProductID.ToString());

            //}
            //else
            //{
            //    MessageBox.Show("failed");
            //}

            // update

            //clsProductCatalog productcatalog = clsProductCatalog.Find(1);

            //if (productcatalog != null)
            //{
            //    productcatalog.ProductName = "Laptop Inspiron";
            //    productcatalog.Description = "Laptop";
            //    productcatalog.Price = 320;
            //    productcatalog.QuantityInStock = 1;
            //    productcatalog.ImageURL = "d:\\";
            //    productcatalog.CategoryID = 1;

            //    if (productcatalog.Save())
            //    {
            //        MessageBox.Show("Updated");
            //    }
            //    else
            //    {
            //        MessageBox.Show("failed");
            //    }
            //}

            // delete

            bool IsDeleted = clsProductCatalog.DeleteProductCatalog(3);

            if (IsDeleted)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");
        }
    }

}
