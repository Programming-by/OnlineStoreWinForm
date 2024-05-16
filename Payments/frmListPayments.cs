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

namespace OnlineStoreWinform.Payments
{
    public partial class frmListPayments : Form
    {
        public frmListPayments()
        {
            InitializeComponent();
        }

        private DataTable _dtPayments = clsPayment.GetAllPayments();
        private void frmListPayments_Load(object sender, EventArgs e)
        {
            cbPages.SelectedIndex = 0;
            int PageNumber = cbPages.SelectedIndex + 1;
            _dtPayments = clsPayment.GetAllPayments(PageNumber);
            dgvPayments.DataSource = _dtPayments;
            lblPaymentCount.Text = _dtPayments.Rows.Count.ToString();

            if (_dtPayments.Rows.Count > 0)
            {
                dgvPayments.Columns[0].HeaderText = "PaymentID";
                dgvPayments.Columns[0].Width = 80;

                dgvPayments.Columns[1].HeaderText = "OrderID";
                dgvPayments.Columns[1].Width = 80;

                dgvPayments.Columns[2].HeaderText = "Amount";
                dgvPayments.Columns[2].Width = 140;

                dgvPayments.Columns[3].HeaderText = "PaymentMethod";
                dgvPayments.Columns[3].Width = 140;

                dgvPayments.Columns[4].HeaderText = "TransactionDate";
                dgvPayments.Columns[4].Width = 160;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Payment " + ((int)dgvPayments.CurrentRow.Cells[0].Value), "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsPayment.DeletePayment((int)dgvPayments.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Payment Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListPayments_Load(null, null);

            }
            else
                MessageBox.Show("Payment Failed to Delete");
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            frmAddEditPayment frm = new frmAddEditPayment();

            frm.ShowDialog();
            frmListPayments_Load(null, null);

        }
        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPayment frm = new frmAddEditPayment();

            frm.ShowDialog();

            frmListPayments_Load(null,null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PaymentID = (int)dgvPayments.CurrentRow.Cells[0].Value;
            frmAddEditPayment frm = new frmAddEditPayment(PaymentID);

            frm.ShowDialog();

            frmListPayments_Load(null, null);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetPaymentsByPage()
        {
            _dtPayments = clsPayment.GetAllPayments(cbPages.SelectedIndex + 1);
            dgvPayments.DataSource = _dtPayments;
            lblPaymentCount.Text = _dtPayments.Rows.Count.ToString();
        }

        private void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPaymentsByPage();
        }
    }
}
