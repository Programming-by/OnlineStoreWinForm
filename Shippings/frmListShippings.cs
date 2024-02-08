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

namespace OnlineStoreWinform.Shippings
{
    public partial class frmListShippings : Form
    {
        public frmListShippings()
        {
            InitializeComponent();
        }
        private DataTable _dtShipping = clsShipping.GetAllShipping();

        private void frmListShippings_Load(object sender, EventArgs e)
        {
            _dtShipping = clsShipping.GetAllShipping();
            dgvShipping.DataSource = _dtShipping;
            lblShippingCount.Text = _dtShipping.Rows.Count.ToString();

            if (_dtShipping.Rows.Count > 0)
            {
                dgvShipping.Columns[0].HeaderText = "ShippingID";
                dgvShipping.Columns[0].Width = 80;

                dgvShipping.Columns[1].HeaderText = "OrderID";
                dgvShipping.Columns[1].Width = 80;

                dgvShipping.Columns[2].HeaderText = "Carrier Name";
                dgvShipping.Columns[2].Width = 140;

                dgvShipping.Columns[3].HeaderText = "Tracking Number";
                dgvShipping.Columns[3].Width = 140;

                dgvShipping.Columns[4].HeaderText = "Shipping Status";
                dgvShipping.Columns[4].Width = 140;

                dgvShipping.Columns[5].HeaderText = "Estimated Delivery Date";
                dgvShipping.Columns[5].Width = 150;

                dgvShipping.Columns[6].HeaderText = "Actual Delivery Date";
                dgvShipping.Columns[6].Width = 150;
            }
        }
        private void btnAddNewShipping_Click(object sender, EventArgs e)
        {
            frmAddEditShipping frm = new frmAddEditShipping();

            frm.ShowDialog();
            frmListShippings_Load(null,null);
        }

        private void addNewShippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditShipping frm = new frmAddEditShipping();

            frm.ShowDialog();

            frmListShippings_Load(null,null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditShipping frm = new frmAddEditShipping((int)dgvShipping.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmListShippings_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Shipping " + ((int)dgvShipping.CurrentRow.Cells[0].Value), "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsShipping.DeleteShipping((int)dgvShipping.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Shipping Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListShippings_Load(null, null);

            }
            else
                MessageBox.Show("Shipping Failed to Delete");
        }

    }
}
