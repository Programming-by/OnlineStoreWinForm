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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineStoreWinform.Orders.Controls
{
    public partial class ctrlShowOrderDetails : UserControl
    {
        private clsOrder _Order;

        public clsOrder SelectedOrderInfo { get { return _Order; } }

        private int? _OrderID;

        public int? OrderID
        {

            get { return _OrderID; }

            set { _OrderID = value; }
        }
        public ctrlShowOrderDetails()
        {
            InitializeComponent();
        }

        private void _FillOrderInfo()
        {
            _OrderID = _Order.OrderID;
            lblOrderID.Text = _Order.OrderID.ToString();
            lblCustomerID.Text = _Order.CustomerID.ToString();
            lblCustomerName.Text = _Order.CustomerInfo.Name;
            lblOrderDate.Text = _Order.OrderDate.ToString();
            lblTotalAmount.Text = _Order.TotalAmount.ToString();
            lblStatus.Text = _Order.Status.ToString();
        } 
        public void LoadOrderInfo(int? OrderID)
        {
            _Order = clsOrder.Find(OrderID);

            if (_Order == null)
            {
                MessageBox.Show("Order is not found", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _FillOrderInfo();
        }

    }
}
