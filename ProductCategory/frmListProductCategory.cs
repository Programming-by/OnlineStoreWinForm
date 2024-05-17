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
            cbPages.SelectedIndex = 0;
            _dtProductCategory = clsProductCategory.GetAllProductCategory();
            dgvProductCategory.DataSource = _dtProductCategory;
            lblProductCategoryCount.Text = _dtProductCategory.Rows.Count.ToString();

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

            frmListProductCategory_Load(null, null);

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
            if (MessageBox.Show("Are you sure you want to delete this Category " + (int)dgvProductCategory.CurrentRow.Cells[0].Value,"",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int CategoryID = (int)dgvProductCategory.CurrentRow.Cells[0].Value;
            if (clsProductCategory.DeleteProductCategory(CategoryID))
            {
                MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListProductCategory_Load(null,null);
            } else
            {
                MessageBox.Show("Failed to Delete");
            }
        }

        private void GetProductCategoryByPage()
        {
            _dtProductCategory = clsProductCategory.GetAllProductCategory(cbPages.SelectedIndex + 1);
            dgvProductCategory.DataSource = _dtProductCategory;
            lblProductCategoryCount.Text = _dtProductCategory.Rows.Count.ToString();
        }


        private void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductCategoryByPage();
        }
    }
}
