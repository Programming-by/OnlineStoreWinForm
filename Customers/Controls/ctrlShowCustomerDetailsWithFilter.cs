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

namespace OnlineStoreWinform.Customers.Controls
{
    public partial class ctrlShowCustomerDetailsWithFilter : UserControl
    {
        public ctrlShowCustomerDetailsWithFilter()
        {
            InitializeComponent();
        }
        public clsCustomer _CustomerInfo
        {
            get { return ctrlShowCustomersDetails1.SelectedCustomerInfo; }
        }

        public int? CustomerID
        {
            get { return ctrlShowCustomersDetails1.CustomerID; } 
        }
        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void frm_DataBack(object sender, int? CustomerID)
        {
            txtCustomerID.Text = CustomerID.ToString();
            ctrlShowCustomersDetails1.LoadCustomerInfo(CustomerID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("fields are not valid");
                return;
            }

            ctrlShowCustomersDetails1.LoadCustomerInfo(int.Parse(txtCustomerID.Text));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer();

            frm.DataBack += frm_DataBack;
            frm.ShowDialog();
        }
    }
}
