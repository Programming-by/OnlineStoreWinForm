using OnlineStoreBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreWinform.Customers
{
    public partial class FrmListCustomers : Form
    {
        public FrmListCustomers()
        {
            InitializeComponent();
        }
        private DataTable _dtCustomers = clsCustomer.GetAllCustomer();
        private void FrmListCustomers_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = _dtCustomers;
            lblCustomersCount.Text = _dtCustomers.Rows.Count.ToString();

            if (_dtCustomers.Rows.Count > 0)
            {
                dgvCustomers.Columns[0].HeaderText = "CustomerID";
                dgvCustomers.Columns[0].Width = 80;

                dgvCustomers.Columns[1].HeaderText = "Name";
                dgvCustomers.Columns[1].Width = 160;

                dgvCustomers.Columns[2].HeaderText = "Email";
                dgvCustomers.Columns[2].Width = 160;

                dgvCustomers.Columns[3].HeaderText = "Phone";
                dgvCustomers.Columns[3].Width = 150;

                dgvCustomers.Columns[4].HeaderText = "Address";
                dgvCustomers.Columns[4].Width = 140;

                dgvCustomers.Columns[5].HeaderText = "Username";
                dgvCustomers.Columns[5].Width = 150;

                dgvCustomers.Columns[6].HeaderText = "Password";
                dgvCustomers.Columns[6].Width = 150;
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer();

            frm.ShowDialog();
        }

        private void showCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCustomerDetails frm = new frmShowCustomerDetails(((int)dgvCustomers.CurrentRow.Cells[0].Value));

            frm.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer();

            frm.ShowDialog();

            FrmListCustomers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer((int)dgvCustomers.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            FrmListCustomers_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer " + ((int)dgvCustomers.CurrentRow.Cells[0].Value), "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsCustomer.DeleteCustomer((int)dgvCustomers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Customer Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmListCustomers_Load(null, null);

            }
            else
                MessageBox.Show("Customer Failed to Delete");


        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowCustomerDetails frm = new frmShowCustomerDetails(((int)dgvCustomers.CurrentRow.Cells[0].Value));

            frm.ShowDialog();
        }
    }
}
