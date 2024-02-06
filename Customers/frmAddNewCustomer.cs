using OnlineStoreBusinessLayer;
using OnlineStoreWinform.Global_Classes;
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
    public partial class frmAddNewCustomer : Form
    {
        int _CustomerID;
        public enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;
        clsCustomer _Customer;
        public frmAddNewCustomer()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddNewCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            Mode = enMode.Update;

        }
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                _Customer = new clsCustomer();
                lblTitle.Text = "Add New Customer";
                this.Text = lblTitle.Text;
            } else
            {

            }

        }

        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp =  (TextBox) sender;

            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "this field is required");
            } else
                errorProvider1.SetError(Temp, "");


        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "this field is required");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }


            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "this is wrong Format for Email");
            }
            else
                errorProvider1.SetError(txtEmail, "");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Customer.Name = txtName.Text;
            _Customer.Email = txtEmail.Text;
            _Customer.Phone = txtPhone.Text;
            _Customer.Address = txtAddress.Text;
            _Customer.Username = txtUsername.Text;
            _Customer.Password = txtPassword.Text;

            if (_Customer.Save())
            {
                Mode = enMode.Update;
                lblCustomerID.Text = _Customer.CustomerID.ToString();
                MessageBox.Show("Data Saved Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Failed to Save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
