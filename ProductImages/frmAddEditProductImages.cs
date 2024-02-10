﻿using OnlineStoreBusinessLayer;
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

namespace OnlineStoreWinform.ProductImages
{
    public partial class frmAddEditProductImages : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode;

        int _ID;
        public frmAddEditProductImages()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
       
        public frmAddEditProductImages(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Mode = enMode.Update;
        }

        clsProductImages _ProductImages;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlProductDetailsWithFilter1.ProductID != -1)
            {
                btnSave.Enabled = true;
                tpProductImages.Enabled = true;
                tbProductImages.SelectedTab = tbProductImages.TabPages["tpProductImages"];
            }
            else
            {
                MessageBox.Show("Please Select Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtProductName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtImageURL.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtImageURL,"this field is required");
            } else
                errorProvider1.SetError(txtImageURL, "");
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Product Images";
                this.Text = lblTitle.Text;
                _ProductImages = new clsProductImages();
            } else
            {
                lblTitle.Text = "Update Product Images";
                this.Text = lblTitle.Text;
            }
            btnSave.Enabled =false;
            tpProductImages.Enabled = false;
            numericUpDown1.Minimum = 1;
        }

        private void _LoadData()
        {
            _ProductImages = clsProductImages.Find(_ID);

            if ( _ProductImages == null )
            {
                MessageBox.Show("ProductName Images is not found");
                return;
            }
         ctrlProductDetailsWithFilter1.LoadProductInfo(_ProductImages.ProductID);
         ctrlProductDetailsWithFilter1.FilterEnabled = false;
         lblID.Text = _ProductImages.ID.ToString();
         txtImageURL.Text = _ProductImages.ImageURL;
         numericUpDown1.Value = _ProductImages.ImageOrder;
        }
        private void frmAddEditProductImages_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _ProductImages.ImageURL = txtImageURL.Text;
            _ProductImages.ImageOrder = (Int16)numericUpDown1.Value;
             _ProductImages.ProductID = ctrlProductDetailsWithFilter1.ProductID;
            if (_ProductImages.Save())
            {
                Mode = enMode.Update;
                lblID.Text = _ProductImages.ProductID.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);       
        }
    }
}
