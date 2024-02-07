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
    public partial class ctrlShowCustomersDetails : UserControl
    {
        public ctrlShowCustomersDetails()
        {
            InitializeComponent();
        }

      private  clsCustomer _Customer;

       public clsCustomer SelectedCustomerInfo { get { return _Customer; } }

        private int? _CustomerID;

        public int? CustomerID { 
            
            get { return _CustomerID; }
        
          set { _CustomerID = value; }
        }
        private void _FillCustomerInfo()
        {
            _CustomerID = _Customer.CustomerID;
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            lblName.Text = _Customer.Name;
            lblEmail.Text = _Customer.Email;
            lblPhone.Text = _Customer.Phone;
            lblAddress.Text = _Customer.Address;
            lblUsername.Text = _Customer.Username;
        }
        public void LoadCustomerInfo(int? CustomerID)
        {
            _Customer = clsCustomer.Find(CustomerID);

            if (_Customer == null )
            {
            MessageBox.Show("Customer is not found", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _FillCustomerInfo();
        }

    }
}
