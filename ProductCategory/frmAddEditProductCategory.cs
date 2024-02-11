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

namespace OnlineStoreWinform.ProductCategory
{
    public partial class frmAddEditProductCategory : Form
    {
        public enum enMode { AddNew = 0 , Update = 1 }
        enMode Mode = enMode.AddNew;
        int _CategoryID;

        clsProductCategory _ProductCategory;
        public frmAddEditProductCategory()
        {
            InitializeComponent();
        }

        public delegate void DataBackHandler(object sender, int? CategoryID);

        public event DataBackHandler DataBack;
        public frmAddEditProductCategory(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;
            Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCategoryName,"this field is required");
            } else
                errorProvider1.SetError(txtCategoryName, "");

        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                _ProductCategory = new clsProductCategory();
                lblTitle.Text = "Add New Product Category";
                this.Text = lblTitle.Text;
            }
            else
            {
                lblTitle.Text = "Update Product Category";
                this.Text = lblTitle.Text;
            }
        }

        private void _LoadData()
        {
            _ProductCategory = clsProductCategory.Find(_CategoryID);

            if (_ProductCategory == null) 
            {
                MessageBox.Show("Category is not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblCategoryID.Text = _ProductCategory.CategoryID.ToString();
            txtCategoryName.Text = _ProductCategory.CategoryName;
            }
        private void frmAddEditProductCategory_Load(object sender, EventArgs e)
        {
        _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _ProductCategory.CategoryName = txtCategoryName.Text;

            if (_ProductCategory.Save())
            {
                Mode = enMode.Update;
                DataBack?.Invoke(this,_ProductCategory.CategoryID);
                lblCategoryID.Text = _ProductCategory.CategoryID.ToString();
                MessageBox.Show("Data Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
                MessageBox.Show("Failed To Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
