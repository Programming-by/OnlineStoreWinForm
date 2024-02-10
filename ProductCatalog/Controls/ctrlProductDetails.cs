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

namespace OnlineStoreWinform.ProductCatalog.Controls
{
    public partial class ctrlProductDetails : UserControl
    {
        public ctrlProductDetails()
        {
            InitializeComponent();
        }
        private clsProductCatalog _Product;

        public clsProductCatalog SelectedProductInfo { get { return _Product; } }

        private int? _ProductID;

        public int? ProductID
        {

            get { return _ProductID; }

            set { _ProductID = value; }
        }
        private void _FillProductInfo()
        {
            _ProductID = _Product.ProductID;
            lblProductID.Text = _Product.ProductID.ToString();
            lblProductName.Text = _Product.ProductName;
            lblDescription.Text = _Product.Description;
            lblPrice.Text = _Product.Price.ToString();
            lblQuantityInStock.Text = _Product.QuantityInStock.ToString();
            lblImageURL.Text = _Product.ImageURL;
            lblCategoryID.Text = _Product.CategoryID.ToString();
            lblCategoryName.Text = _Product.CategoryInfo.CategoryName;
        }
        public void LoadProductInfo(int? ProductID)
        {
            _Product = clsProductCatalog.Find(ProductID);

            if (_Product == null)
            {
                MessageBox.Show("Product is not found", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _FillProductInfo();
        }

    }
}
