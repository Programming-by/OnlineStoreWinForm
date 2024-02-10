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

namespace OnlineStoreWinform.Reviews
{
    public partial class frmAddEditReview : Form
    {
        public enum enMode { AddNew = 0,Update = 1 }

        enMode Mode = enMode.AddNew;

        int _ReviewID;

        clsReview _Review;
        public frmAddEditReview()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditReview(int ReviewID)
        {
            InitializeComponent();
            _ReviewID = ReviewID;
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
                lblTitle.Text = "Add New Review";
                this.Text = lblTitle.Text;
                _Review = new clsReview();
            }
            else
            {
                lblTitle.Text = "Update Review";
                this.Text = lblTitle.Text;
            }

            btnSave.Enabled = false;    
            tpCustomerInfo.Enabled = false;
            tpReviewInfo.Enabled = false;
            numericUpDownRating.Minimum = 1;
            numericUpDownRating.Maximum = 10;
            dateTimePickerReviewDate.MinDate = DateTime.Now;
        }

        private void _LoadData()
        {
            _Review = clsReview.Find(_ReviewID);

            if (_Review == null)
            {
                MessageBox.Show("Review is not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlProductDetailsWithFilter1.FilterEnabled = false;
            ctrlShowCustomerDetailsWithFilter1.FilterEnabled = false;

            ctrlProductDetailsWithFilter1.LoadProductInfo(_Review.ProductID);
            ctrlShowCustomerDetailsWithFilter1.LoadCustomerInfo(_Review.CustomerID);

            lblReviewID.Text = _Review.ReviewID.ToString();
            txtReviewText.Text = _Review.ReviewText;
            numericUpDownRating.Value = _Review.Rating;
            if (_Review.ReviewDate > DateTime.Now)
                dateTimePickerReviewDate.Value = (DateTime)_Review.ReviewDate;
            else
                dateTimePickerReviewDate.Value = DateTime.Now;
        }
        private void frmAddEditReview_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }

        private void btnNextToCustomersInfo_Click(object sender, EventArgs e)
        {
            if (ctrlProductDetailsWithFilter1.ProductID != -1)
            {
                btnSave.Enabled = true;
                tpCustomerInfo.Enabled = true;
                tbReviewInfo.SelectedTab = tbReviewInfo.TabPages["tpCustomerInfo"];
            }
            else
            {
                MessageBox.Show("Please Select Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextToReviewInfo_Click(object sender, EventArgs e)
        {
            if (ctrlShowCustomerDetailsWithFilter1.CustomerID != -1)
            {
                btnSave.Enabled = true;
                tpReviewInfo.Enabled = true;
                tbReviewInfo.SelectedTab = tbReviewInfo.TabPages["tpReviewInfo"];
            }
            else
            {
                MessageBox.Show("Please Select Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Review.ProductID = ctrlProductDetailsWithFilter1.ProductID;
            _Review.CustomerID = ctrlShowCustomerDetailsWithFilter1.CustomerID;
            _Review.ReviewText = txtReviewText.Text;
            _Review.Rating =  numericUpDownRating.Value;
            _Review.ReviewDate = (DateTime?)  dateTimePickerReviewDate.Value;
            if (_Review.Save())
            {
                Mode = enMode.Update;
                lblReviewID.Text = _Review.ReviewID.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
