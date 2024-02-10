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

namespace OnlineStoreWinform.OrderItems
{
    public partial class frmListOrderItems : Form
    {
        public frmListOrderItems()
        {
            InitializeComponent();
        }
        private DataTable _dtOrderItems = clsOrderItem.GetAllOrderItems(); 
        private void frmListOrderItems_Load(object sender, EventArgs e)
        {
            _dtOrderItems = clsOrderItem.GetAllOrderItems();
            dgvOrderItems.DataSource = _dtOrderItems;
            lblReviewsCount.Text = _dtOrderItems.Rows.Count.ToString();

            if (_dtOrderItems.Rows.Count > 0)
            {
                dgvOrderItems.Columns[0].HeaderText = "OrderItemID";
                dgvOrderItems.Columns[0].Width = 80;

                dgvOrderItems.Columns[1].HeaderText = "OrderID";
                dgvOrderItems.Columns[1].Width = 80;

                dgvOrderItems.Columns[2].HeaderText = "Customer Name";
                dgvOrderItems.Columns[2].Width = 150;

                dgvOrderItems.Columns[3].HeaderText = "Order Date";
                dgvOrderItems.Columns[3].Width = 140;

                dgvOrderItems.Columns[4].HeaderText = "Total Amount";
                dgvOrderItems.Columns[4].Width = 130;

                dgvOrderItems.Columns[5].HeaderText = "Status";
                dgvOrderItems.Columns[5].Width = 130;

                dgvOrderItems.Columns[6].HeaderText = "Product Name";
                dgvOrderItems.Columns[6].Width = 140;

                dgvOrderItems.Columns[7].HeaderText = "Quantity";
                dgvOrderItems.Columns[7].Width = 80;

                dgvOrderItems.Columns[8].HeaderText = "Price";
                dgvOrderItems.Columns[8].Width = 130;

                dgvOrderItems.Columns[9].HeaderText = "TotalItemsPrice";
                dgvOrderItems.Columns[9].Width = 130;

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNewOrderItem_Click(object sender, EventArgs e)
        {
            frmAddEditOrderItem frm = new frmAddEditOrderItem();

            frm.ShowDialog();

            frmListOrderItems_Load(null, null); 
        }
        private void addNewOrderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditOrderItem frm = new frmAddEditOrderItem();

            frm.ShowDialog();

            frmListOrderItems_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditOrderItem frm = new frmAddEditOrderItem((int)dgvOrderItems.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmListOrderItems_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this item " + ((int)dgvOrderItems.CurrentRow.Cells[0].Value), "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsOrderItem.DeleteOrderItem((int)dgvOrderItems.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Order Item Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListOrderItems_Load(null, null);

            }
            else
                MessageBox.Show("Order Item Failed to Delete");
        }

    }
}
