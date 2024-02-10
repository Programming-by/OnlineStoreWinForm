using OnlineStoreBusinessLayer;
using OnlineStoreWinform.Orders;
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

namespace OnlineStoreWinform.ProductCatalog.Controls
{
    public partial class ctrlProductDetailsWithFilter : UserControl
    {
        public ctrlProductDetailsWithFilter()
        {
            InitializeComponent();
        }

        public clsProductCatalog _ProductInfo
        {
            get { return ctrlProductDetails1.SelectedProductInfo; }
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

        public int? ProductID
        {
            get { return ctrlProductDetails1.ProductID; }
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("fields are not valid");
                return;
            }

            ctrlProductDetails1.LoadProductInfo(int.Parse(txtProductID.Text));
        }

        private void frm_DataBack(object sender, int? OrderID)
        {
            txtProductID.Text = OrderID.ToString();
            ctrlProductDetails1.LoadProductInfo(OrderID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProductCatalog frm = new frmAddEditProductCatalog();

            frm.DataBack += frm_DataBack;
            frm.ShowDialog();
        }

        public void LoadProductInfo(int? ProductID)
        {
            txtProductID.Text = ProductID.ToString();
            ctrlProductDetails1.LoadProductInfo(ProductID);
        }
    }
}
