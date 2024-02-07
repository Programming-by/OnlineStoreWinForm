using OnlineStoreBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreWinform.Orders
{
    public partial class frmListOrders : Form
    {
        public frmListOrders()
        {
            InitializeComponent();
        }
        private DataTable _dtOrders = clsOrder.GetAllOrders();
        private void frmListOrders_Load(object sender, EventArgs e)
        {
            _dtOrders = clsOrder.GetAllOrders();
            dgvOrders.DataSource = _dtOrders;
            lblOrdersCount.Text = _dtOrders.Rows.Count.ToString();

            if (_dtOrders.Rows.Count > 0)
            {
                dgvOrders.Columns[0].HeaderText = "OrderID";
                dgvOrders.Columns[0].Width = 80;

                dgvOrders.Columns[1].HeaderText = "CustomerID";
                dgvOrders.Columns[1].Width = 140;

                dgvOrders.Columns[2].HeaderText = "CustomerName";
                dgvOrders.Columns[2].Width = 140;

                dgvOrders.Columns[3].HeaderText = "OrderDate";
                dgvOrders.Columns[3].Width = 160;

                dgvOrders.Columns[4].HeaderText = "TotalAmount";
                dgvOrders.Columns[4].Width = 140;

                dgvOrders.Columns[5].HeaderText = "Status";
                dgvOrders.Columns[5].Width = 140;

            }
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {

        }

        private void showOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID = (int)dgvOrders.CurrentRow.Cells[0].Value;
            frmShowOrderDetails frm = new frmShowOrderDetails(OrderID);

            frm.ShowDialog();
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
