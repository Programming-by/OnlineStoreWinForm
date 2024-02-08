using OnlineStoreBusinessLayer;
using OnlineStoreWinform.Customers;
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

namespace OnlineStoreWinform.Orders.Controls
{
    public partial class ctrlShowOrderDetailsWithFilter : UserControl
    {
        public ctrlShowOrderDetailsWithFilter()
        {
            InitializeComponent();
        }

        public clsOrder _OrderInfo
        {
            get { return ctrlShowOrderDetails1.SelectedOrderInfo; }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;

            }
        }

        public int? OrderID
        {
            get { return ctrlShowOrderDetails1.OrderID; }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("fields are not valid");
                return;
            }

            ctrlShowOrderDetails1.LoadOrderInfo(int.Parse(txtOrderID.Text));
        }
        
        private void frm_DataBack(object sender,int? OrderID)
        {
            txtOrderID.Text = OrderID.ToString();
            ctrlShowOrderDetails1.LoadOrderInfo(OrderID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditOrder frm = new frmAddEditOrder();

            frm.DataBack += frm_DataBack;
            frm.ShowDialog();
        }

        public void LoadOrderInfo(int? OrderID)
        {
            txtOrderID.Text = OrderID.ToString();
            ctrlShowOrderDetails1.LoadOrderInfo(OrderID);
        }
    }
}
