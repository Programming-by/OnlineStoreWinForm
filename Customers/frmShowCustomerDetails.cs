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
    public partial class frmShowCustomerDetails : Form
    {
        int _CustomerID = -1;
        public frmShowCustomerDetails(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowCustomerDetails_Load(object sender, EventArgs e)
        {
            ctrlShowCustomersDetails1.LoadCustomerInfo(_CustomerID);
        }
    }
}
