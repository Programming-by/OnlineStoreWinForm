using OnlineStoreWinform.Customers;
using OnlineStoreWinform.OrderItems;
using OnlineStoreWinform.Orders;
using OnlineStoreWinform.Payments;
using OnlineStoreWinform.ProductCatalog;
using OnlineStoreWinform.ProductCategory;
using OnlineStoreWinform.ProductImages;
using OnlineStoreWinform.Reviews;
using OnlineStoreWinform.Shippings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreWinform
{
    public partial class frmMain : Form
    {
        Form _frmLogin;
        public frmMain(Form frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListCustomers frm = new FrmListCustomers();

            frm.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListProductCategory frm = new frmListProductCategory();

            frm.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOrders frm = new frmListOrders();

            frm.ShowDialog();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPayments frm = new frmListPayments();

            frm.ShowDialog();
        }

        private void shippingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListShippings frm = new frmListShippings();

            frm.ShowDialog();
        }

        private void productCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProductCatlog frm = new frmListProductCatlog();

            frm.ShowDialog();
        }

        private void productImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProductImages frm = new frmListProductImages();

            frm.ShowDialog();
        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListReviews frm = new frmListReviews();

            frm.ShowDialog();
        }

        private void orderItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOrderItems frm = new frmListOrderItems();

            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            this.Close();
        }
    }
}
