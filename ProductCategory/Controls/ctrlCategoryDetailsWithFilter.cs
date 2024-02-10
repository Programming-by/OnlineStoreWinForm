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
            set
            {
                _FilterEnabled = value;
                groupBox1.Enabled = _FilterEnabled;
            }
        }

        private int? _CategoryID = -1;
        public int? CategoryID
        {
            get { return _CategoryID; }
            set
            {
                _CategoryID = value;
            }
        }

        public clsProductCategory SelectedCategoryInfo
        {
            get { return ctrlCategoryDetails1.SelectedCategoryInfo; }
        }


        public void LoadCategoryInfo(int? CategoryID)
        {
            txtCategoryID.Text = CategoryID.ToString();
            ctrlCategoryDetails1.LoadCategoryInfo(CategoryID);
        }

        private void frm_Databack(object sender, int? CategoryID)
        {
            txtCategoryID.Text = CategoryID.ToString();

            ctrlCategoryDetails1.LoadCategoryInfo(CategoryID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            int CategoryID = int.Parse(txtCategoryID.Text);

            ctrlCategoryDetails1.LoadCategoryInfo(CategoryID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProductCategory frm = new frmAddEditProductCategory();

            frm.DataBack += frm_Databack;
            frm.ShowDialog();
        }
    }
}
