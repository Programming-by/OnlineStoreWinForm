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
            //dataGridView1.DataSource = clsProductCategory.GetAllProductCategory();

            //find
            //clsProductCategory productcategory = clsProductCategory.Find(1);

            //MessageBox.Show(productcategory.CategoryName.ToString());

            //add new
            //clsProductCategory productcategory = new clsProductCategory();

            //productcategory.CategoryName = "Books";

            //if (productcategory.Save())
            //{
            //    MessageBox.Show(productcategory.CategoryID.ToString());

            //}
            //else
            //{
            //    MessageBox.Show("dd");
            //}

            // update

            clsProductCategory productcategory = clsProductCategory.Find(1);

            //if (productcategory != null)
            //{
            //    productcategory.CategoryName = "Electronics";
            //    if (productcategory.Save())
            //    {
            //        MessageBox.Show("Updated");
            //    }
            //    else
            //    {
            //        MessageBox.Show("failed");
            //    }
            //}

            // delete

            bool IsDeleted = clsProductCategory.DeleteProductCategory(3);

            if (IsDeleted)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");
        }
    }

}
