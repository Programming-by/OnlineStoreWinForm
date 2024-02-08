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
    public partial class frmAddEditOrder : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;

        clsOrder _Order;
        public frmAddEditOrder()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        int _OrderID;

        public frmAddEditOrder(int OrderID)
        {
            InitializeComponent();
            _OrderID = OrderID;
            Mode = enMode.Update;

        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Order";
                this.Text = lblTitle.Text;
                _Order = new clsOrder();
            }
            else
            {
                lblTitle.Text = "Update Order";
                this.Text = lblTitle.Text;
            }
            dateTimePicker1.MinDate = DateTime.Now;
            lblStatus.Text = clsOrder.enStatus.Pending.ToString();
            btnSave.Enabled = false;
            tpOrder.Enabled = false;
        }

        private void _LoadData()
        {

        }
        private void frmAddEditOrder_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlShowCustomerDetailsWithFilter1.CustomerID != -1)
            {
                btnSave.Enabled = true;
                tpOrder.Enabled = true;
                tbOrderInfo.SelectedTab = tbOrderInfo.TabPages["tpOrder"];
            } else
            {
                MessageBox.Show("Please Select Customer","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Order.CustomerID = ctrlShowCustomerDetailsWithFilter1.CustomerID;
            _Order.OrderDate = dateTimePicker1.Value;
            _Order.TotalAmount = decimal.Parse(txtTotalAmount.Text);
            if (Enum.TryParse(lblStatus.Text,out clsOrder.enStatus StatusLabel))
            _Order.Status = StatusLabel;

            if (_Order.Save())
            {
                Mode = enMode.Update;
                lblOrderID.Text = _Order.OrderID.ToString();
                MessageBox.Show("Data Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void txtTotalAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalAmount.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTotalAmount, "this field iss required");
            } else
                errorProvider1.SetError(txtTotalAmount, "");
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
