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

namespace OnlineStoreWinform.ProductImages
{
    public partial class frmListProductImages : Form
    {
        public frmListProductImages()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable _dtProductImages = clsProductImages.GetAllProductImages();
        private void frmListProductImages_Load(object sender, EventArgs e)
        {
            _dtProductImages = clsProductImages.GetAllProductImages();
            dgvProductImages.DataSource = _dtProductImages;
            lblProductImagesCount.Text = _dtProductImages.Rows.Count.ToString();

            if (_dtProductImages.Rows.Count > 0)
            {
                dgvProductImages.Columns[0].HeaderText = "ID";
                dgvProductImages.Columns[0].Width = 80;

                dgvProductImages.Columns[1].HeaderText = "ImageURL";
                dgvProductImages.Columns[1].Width = 150;

                dgvProductImages.Columns[2].HeaderText = "Image Order";
                dgvProductImages.Columns[2].Width = 160;

                dgvProductImages.Columns[3].HeaderText = "ProductID";
                dgvProductImages.Columns[3].Width = 140;

                dgvProductImages.Columns[3].HeaderText = "Product Name";
                dgvProductImages.Columns[3].Width = 140;
            }
        }
        private void addNewProductCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProductImages frm = new frmAddEditProductImages();

            frm.ShowDialog();

            frmListProductImages_Load(null, null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProductImages frm = new frmAddEditProductImages((int)dgvProductImages.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmListProductImages_Load(null, null);
        }
        private void btnAddNewProductImages_Click(object sender, EventArgs e)
        {
            frmAddEditProductImages frm = new frmAddEditProductImages();

            frm.ShowDialog();

            frmListProductImages_Load(null, null);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Product Images " + ((int)dgvProductImages.CurrentRow.Cells[0].Value), "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsProductImages.DeleteProductImages((int)dgvProductImages.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Product Images Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListProductImages_Load(null, null);

            }
            else
                MessageBox.Show("Product Images Failed to Delete");
        }
    }
}
