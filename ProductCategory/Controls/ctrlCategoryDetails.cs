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

namespace OnlineStoreWinform.ProductCategory.Controls
{
    public partial class ctrlCategoryDetails : UserControl
    {
        public ctrlCategoryDetails()
        {
            InitializeComponent();
        }

        private clsProductCategory _Category;

        public clsProductCategory SelectedCategoryInfo
        {
            get { return _Category; }
        }

        private int? _CategoryID = -1;

        public int? CategoryID
        {
            get { return _CategoryID; }
        }


        public void LoadCategoryInfo(int? CategoryID)
        {
            _Category = clsProductCategory.Find(CategoryID);

            if (_Category != null)
            {
                _CategoryID = _Category.CategoryID;
                lblCategoryID.Text = _Category.CategoryID.ToString();
                lblCategoryName.Text = _Category.CategoryName;
            }
        }
    }
}
