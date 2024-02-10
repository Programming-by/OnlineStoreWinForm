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

namespace OnlineStoreWinform.OrderItems
{
    public partial class frmAddEditOrderItem : Form
    {
        int _OrderItemID;

        clsOrderItem _OrderItem;

        public enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;
        public frmAddEditOrderItem()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditOrderItem(int OrderItemID)
        {
            InitializeComponent();
            _OrderItemID = OrderItemID;
            Mode = enMode.Update;
        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New OrderItem";
                this.Text = lblTitle.Text;
                _OrderItem = new clsOrderItem();
            }
            else
            {
                lblTitle.Text = "Update OrderItem";
                this.Text = lblTitle.Text;
            }

            btnSave.Enabled = false;
            tpProductInfo.Enabled = false;
            tpOrderItemInfo.Enabled = false;
            numericUpDownQuantity.Minimum = 1;
            numericUpDownQuantity.Maximum = 250;
        }
        private void _LoadData()
        {
            _OrderItem = clsOrderItem.Find(_OrderItemID);

            if (_OrderItem == null)
            {
                MessageBox.Show("OrderItem is not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlShowOrderDetailsWithFilter1.FilterEnabled = false;
            ctrlProductDetailsWithFilter1.FilterEnabled = false;

            ctrlShowOrderDetailsWithFilter1.LoadOrderInfo(_OrderItem.OrderID);
            ctrlProductDetailsWithFilter1.LoadProductInfo(_OrderItem.ProductID);

            lblOrderItemID.Text = _OrderItem.OrderItemID.ToString();
            numericUpDownQuantity.Value = _OrderItem.Quantity;
            txtPrice.Text = _OrderItem.Price.ToString();
            txtTotalItemsPrice.Text = _OrderItem.TotalItemsPrice.ToString();
        }
        private void frmAddEditOrderItem_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTotalItemsPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "this field is required");
            } else
                errorProvider1.SetError(txtPrice, "");

        }

        private void txtTotalItemsPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalItemsPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTotalItemsPrice, "this field is required");
            }
            else
                errorProvider1.SetError(txtTotalItemsPrice, "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNextToProductInfo_Click(object sender, EventArgs e)
        {
            if (ctrlShowOrderDetailsWithFilter1.OrderID != -1)
            {
                btnSave.Enabled = true;
                tpProductInfo.Enabled = true;
                tbOrderItemInfo.SelectedTab = tbOrderItemInfo.TabPages["tpProductInfo"];
            }
            else
            {
                MessageBox.Show("Please Select Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNextToOrderItemsInfo_Click(object sender, EventArgs e)
        {
            if (ctrlProductDetailsWithFilter1.ProductID != -1)
            {
                btnSave.Enabled = true;
                tpOrderItemInfo.Enabled = true;
                tbOrderItemInfo.SelectedTab = tbOrderItemInfo.TabPages["tpOrderItemInfo"];
            }
            else
            {
                MessageBox.Show("Please Select Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _OrderItem.OrderID = ctrlShowOrderDetailsWithFilter1.OrderID;
            _OrderItem.ProductID = ctrlProductDetailsWithFilter1.ProductID;
            _OrderItem.Quantity = (int) numericUpDownQuantity.Value;
            _OrderItem.Price = decimal.Parse(txtPrice.Text);
            _OrderItem.TotalItemsPrice = decimal.Parse(txtTotalItemsPrice.Text); 
            if (_OrderItem.Save())
            {
                Mode = enMode.Update;
                lblOrderItemID.Text = _OrderItem.OrderItemID.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
