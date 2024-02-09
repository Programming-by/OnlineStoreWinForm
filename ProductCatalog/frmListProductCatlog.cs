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

namespace OnlineStoreWinform.ProductCatalog
{
    public partial class frmListProductCatlog : Form
    {
        public frmListProductCatlog()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable _dtProductCatalog = clsProductCatalog.GetAllProductCatalogs();
        private void frmListProductCatlog_Load(object sender, EventArgs e)
        {
            _dtProductCatalog = clsProductCatalog.GetAllProductCatalogs();
            dgvProductCatalog.DataSource = _dtProductCatalog;
            lblProductCatalogCount.Text = _dtProductCatalog.Rows.Count.ToString();

            if (_dtProductCatalog.Rows.Count > 0)
            {
                dgvProductCatalog.Columns[0].HeaderText = "ProductID";
                dgvProductCatalog.Columns[0].Width = 80;

                dgvProductCatalog.Columns[1].HeaderText = "Product Name";
                dgvProductCatalog.Columns[1].Width = 150;

                dgvProductCatalog.Columns[2].HeaderText = "Description";
                dgvProductCatalog.Columns[2].Width = 160;

                dgvProductCatalog.Columns[3].HeaderText = "Price";
                dgvProductCatalog.Columns[3].Width = 140;

                dgvProductCatalog.Columns[4].HeaderText = "Quantity In Stock";
                dgvProductCatalog.Columns[4].Width = 140;

                dgvProductCatalog.Columns[5].HeaderText = "ImageURL";
                dgvProductCatalog.Columns[5].Width = 150;

                dgvProductCatalog.Columns[6].HeaderText = "CategoryID";
                dgvProductCatalog.Columns[6].Width = 150;

                dgvProductCatalog.Columns[7].HeaderText = "Category Name";
                dgvProductCatalog.Columns[7].Width = 150;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Product Catalog " + ((int)dgvProductCatalog.CurrentRow.Cells[0].Value), "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsProductCatalog.DeleteProductCatalog((int)dgvProductCatalog.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Product Catalog Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListProductCatlog_Load(null, null);

            }
            else
                MessageBox.Show("Product Catalog Failed to Delete");
        }
    }
}
