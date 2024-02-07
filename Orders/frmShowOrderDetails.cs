using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreWinform.Orders
{
    public partial class frmShowOrderDetails : Form
    {
        int _OrderID;
        public frmShowOrderDetails(int OrderID)
        {
            InitializeComponent();
            _OrderID = OrderID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowOrderDetails_Load(object sender, EventArgs e)
        {
            ctrlShowOrderDetails1.LoadOrderInfo(_OrderID);
        }
    }
}
