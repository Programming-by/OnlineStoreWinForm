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

namespace OnlineStoreWinform.ProductCategory
{
    public partial class ctrlCategoryDetailsWithFilter : UserControl
    {
        public ctrlCategoryDetailsWithFilter()
        {
            InitializeComponent();
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set { _FilterEnabled = value;
            groupBox1.Enabled = _FilterEnabled;

            }

        }

        private int? _CategoryID = -1;

        public int? CategoryID
        {
            get { return _CategoryID; }
            set {
                _CategoryID = value; 
            }
        }

        public void LoadCategoryInfo(int? CategoryID)
        {
            clsProductCategory _Category = clsProductCategory.Find(CategoryID);

            if (_Category != null)
            {

                _CategoryID = _Category.CategoryID;
                txtCategoryID.Text = _Category.CategoryID.ToString();
                lblCategoryID.Text = _Category.CategoryID.ToString();
                lblCategoryName.Text = _Category.CategoryName;
            }
        }

        private void frm_Databack(object sender , int? CategoryID)
        {
            txtCategoryID.Text = CategoryID.ToString();

            clsProductCategory _Category = clsProductCategory.Find(CategoryID);

            if (_Category != null)
            {
                _CategoryID = _Category.CategoryID;
                lblCategoryID.Text = _Category.CategoryID.ToString();
                lblCategoryName.Text = _Category.CategoryName;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProductCategory frm = new frmAddEditProductCategory();

            frm.DataBack += frm_Databack;
            frm.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int CategoryID = int.Parse(txtCategoryID.Text);
            clsProductCategory _Category = clsProductCategory.Find(CategoryID);

            if (_Category != null)
            {
                _CategoryID = _Category.CategoryID;
                lblCategoryID.Text = _Category.CategoryID.ToString();
                lblCategoryName.Text = _Category.CategoryName;
            }
        }

        private void txtCategoryID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCategoryID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCategoryID,"this field is required");
            } else
                errorProvider1.SetError(txtCategoryID, "");

        }
    }
}
