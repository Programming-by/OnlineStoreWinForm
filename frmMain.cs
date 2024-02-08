using OnlineStoreWinform.Customers;
using OnlineStoreWinform.Orders;
using OnlineStoreWinform.Payments;
using OnlineStoreWinform.ProductCategory;
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
        public frmMain()
        {
            InitializeComponent();
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
    }
}
