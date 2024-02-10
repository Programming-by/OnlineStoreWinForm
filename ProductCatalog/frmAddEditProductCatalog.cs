using OnlineStoreBusinessLayer;
using OnlineStoreWinform.Orders.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreWinform.ProductCatalog
{
    public partial class frmAddEditProductCatalog : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;

        public frmAddEditProductCatalog()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        int _ProductID;

        clsProductCatalog _Product;

        public delegate void DatabackHandler(object sender, int? ProductID);

        public event DatabackHandler DataBack;
        public frmAddEditProductCatalog(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
            Mode = enMode.Update;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Payment";
                this.Text = lblTitle.Text;
                _Product = new clsProductCatalog();
            }
            else
            {
                lblTitle.Text = "Update Payment";
                this.Text = lblTitle.Text;
            }
            btnSave.Enabled = false;
            tpProductCatalog.Enabled = false;
        }

        private void _LoadData()
        {
            _Product = clsProductCatalog.Find(_ProductID);

            if (_Product == null)
            {
                MessageBox.Show("Payment is not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlCategoryDetailsWithFilter1.FilterEnabled = false;
            ctrlCategoryDetailsWithFilter1.LoadCategoryInfo(_Product.CategoryID);

            lblProductID.Text = _Product.ProductID.ToString();
            txtProductName.Text = _Product.ProductName;
            txtDescription.Text = _Product.Description;
            txtPrice.Text = _Product.Price.ToString();
            txtQuantityInStock.Text = _Product.QuantityInStock.ToString();
            txtImageURL.Text = _Product.ImageURL;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlCategoryDetailsWithFilter1.CategoryID != -1)
            {
                btnSave.Enabled = true;
                tpProductCatalog.Enabled = true;
                tbProductCatalog.SelectedTab = tbProductCatalog.TabPages["tpProductCatalog"];
            }
            else
            {
                MessageBox.Show("Please Select Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateTextBox(object sender , CancelEventArgs e)
        {
            TextBox Temp = (TextBox) sender;

            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "this field is required");

            }
            else
                errorProvider1.SetError(Temp, "");
        }

        private void frmAddEditProductCatalog_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }

        private void EnterNumberOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Product.ProductName = txtProductName.Text;
            _Product.Description = txtDescription.Text;
            _Product.Price = decimal.Parse(txtPrice.Text);
            _Product.QuantityInStock = int.Parse(txtQuantityInStock.Text);
            _Product.ImageURL = txtImageURL.Text;
            _Product.CategoryID = ctrlCategoryDetailsWithFilter1.CategoryID;

            if (_Product.Save())
            {
                Mode = enMode.Update;
                DataBack?.Invoke(this,_Product.ProductID);
                lblProductID.Text = _Product.ProductID.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
