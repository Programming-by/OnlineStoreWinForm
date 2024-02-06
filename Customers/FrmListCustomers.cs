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

            if (_dtCustomers.Rows.Count > 0 )
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
            frmAddNewCustomer frm = new frmAddNewCustomer();

            frm.ShowDialog();
        }

        private void showCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
