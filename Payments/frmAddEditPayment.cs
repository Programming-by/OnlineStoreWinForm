using OnlineStoreBusinessLayer;
using OnlineStoreWinform.Customers.Controls;
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
    public partial class frmAddEditPayment : Form
    {
        int _PaymentID;

        clsPayment _Payment;
        public enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;
        public frmAddEditPayment()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddEditPayment(int PaymentID)
        {
            InitializeComponent();
            _PaymentID = PaymentID;
            Mode = enMode.Update;
        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Payment";
                this.Text = lblTitle.Text;
                _Payment = new clsPayment();
            }
            else
            {
                lblTitle.Text = "Update Payment";
                this.Text = lblTitle.Text;
            }
            dateTimePicker1.MinDate = DateTime.Now;
            btnSave.Enabled = false;
            cbPaymentMethod.SelectedIndex = 0;
            tpPaymentInfo.Enabled = false;
        }

        private void _LoadData()
        {
            _Payment = clsPayment.Find(_PaymentID);

            if (_Payment == null)
            {
                MessageBox.Show("Payment is not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlShowOrderDetailsWithFilter1.FilterEnabled = false;
            lblPaymentID.Text = _Payment.PaymentID.ToString();
            ctrlShowOrderDetailsWithFilter1.LoadOrderInfo(_Payment.OrderID);
            txtAmount.Text = _Payment.Amount.ToString();
            cbPaymentMethod.Text = _Payment.PaymentMethod.ToString();
            if (_Payment.TransactionDate > DateTime.Now)
                dateTimePicker1.Value = (DateTime)_Payment.TransactionDate;
            else
                dateTimePicker1.Value = DateTime.Now;
        }

        private void frmAddEditPayment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlShowOrderDetailsWithFilter1.OrderID != -1)
            {
                btnSave.Enabled = true;
                tpPaymentInfo.Enabled = true;
                tbPaymentInfo.SelectedTab = tbPaymentInfo.TabPages["tpPaymentInfo"];
            }
            else
            {
                MessageBox.Show("Please Select Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Payment.OrderID = (int) ctrlShowOrderDetailsWithFilter1.OrderID;
            _Payment.Amount = decimal.Parse(txtAmount.Text);
            _Payment.PaymentMethod = cbPaymentMethod.Text;
            _Payment.TransactionDate = dateTimePicker1.Value;

            if (_Payment.Save())
            {
                Mode = enMode.Update;
                lblPaymentID.Text = _Payment.PaymentID.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAmount, "this field is required");
            } else
                errorProvider1.SetError(txtAmount, "");

        }
    }
}
