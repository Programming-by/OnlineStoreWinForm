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
    public partial class frmListProductCategory : Form
    {
        public frmListProductCategory()
        {
            InitializeComponent();
        }

        private DataTable _dtProductCategory = clsProductCategory.GetAllProductCategory();
        private void frmListProductCategory_Load(object sender, EventArgs e)
        {
            _dtProductCategory = clsProductCategory.GetAllProductCategory();
            dgvProductCategory.DataSource = _dtProductCategory;
            lblCustomersCount.Text = _dtProductCategory.Rows.Count.ToString();

            if (_dtProductCategory.Rows.Count > 0)
            {
                dgvProductCategory.Columns[0].HeaderText = "CategoryID";
                dgvProductCategory.Columns[0].Width = 80;

                dgvProductCategory.Columns[1].HeaderText = "CategoryName";
                dgvProductCategory.Columns[1].Width = 160;
            }
        }

        private void btnAddNewProductCategory_Click(object sender, EventArgs e)
        {
            frmAddEditProductCategory frm = new frmAddEditProductCategory();

            frm.ShowDialog();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProductCategory frm = new frmAddEditProductCategory();

            frm.ShowDialog();

            frmListProductCategory_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProductCategory frm =  new frmAddEditProductCategory((int)dgvProductCategory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListProductCategory_Load(null, null);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
