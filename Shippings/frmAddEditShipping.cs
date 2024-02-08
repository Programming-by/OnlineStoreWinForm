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
    public partial class frmAddEditShipping : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;

        int _ShippingID;

        clsShipping _Shipping;
        public frmAddEditShipping()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddEditShipping(int ShippingID)
        {
            InitializeComponent();
            _ShippingID = ShippingID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Shipping";
                this.Text = lblTitle.Text;
                _Shipping = new clsShipping();
            }
            else
            {
                lblTitle.Text = "Update Shipping";
                this.Text = lblTitle.Text;
            }
            dateTimePickerEstimated.MinDate = DateTime.Now.AddDays(15);
            dateTimePickerActual.MinDate = DateTime.Now.AddDays(20);
            btnSave.Enabled = false;
            tpShippingInfo.Enabled = false;
            lblStatus.Text = clsShipping.enShippingStatus.Processing.ToString();
        }



        private void txtTrackingNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtCarrierName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarrierName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCarrierName, "this field is required");
            }
            else
                errorProvider1.SetError(txtCarrierName, "");

        }

        private void txtTrackingNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTrackingNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTrackingNumber, "this field is required");
            }
            else
                errorProvider1.SetError(txtTrackingNumber, "");
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
                tpShippingInfo.Enabled = true;
                tbShippingInfo.SelectedTab = tbShippingInfo.TabPages["tpShippingInfo"];
            }
            else
            {
                MessageBox.Show("Please Select Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Shipping.OrderID = (int)ctrlShowOrderDetailsWithFilter1.OrderID;
            _Shipping.CarrierName = txtCarrierName.Text;
            _Shipping.TrackingNumber = txtTrackingNumber.Text;
            if (Enum.TryParse(lblStatus.Text,out clsShipping.enShippingStatus Status))
            _Shipping.ShippingStatus = Status;
            _Shipping.EstimatedDeliveryDate = dateTimePickerEstimated.Value;
            _Shipping.ActualDeliveryDate = dateTimePickerActual.Value;

            if (_Shipping.Save())
            {
                Mode = enMode.Update;
                lblShippingID.Text = _Shipping.ShippingID.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddEditShipping_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

        }
    }
    }
