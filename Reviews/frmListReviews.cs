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

namespace OnlineStoreWinform.Reviews
{
    public partial class frmListReviews : Form
    {
        public frmListReviews()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable _dtReviews = clsReview.GetAllReviews();
        private void frmListReviews_Load(object sender, EventArgs e)
        {

            cbPages.SelectedIndex = 0;
            _dtReviews = clsReview.GetAllReviews();
            dgvReviews.DataSource = _dtReviews;
            lblReviewsCount.Text = _dtReviews.Rows.Count.ToString();

            if (_dtReviews.Rows.Count > 0)
            {
                dgvReviews.Columns[0].HeaderText = "ReviewID";
                dgvReviews.Columns[0].Width = 80;

                dgvReviews.Columns[1].HeaderText = "Product Name";
                dgvReviews.Columns[1].Width = 150;

                dgvReviews.Columns[2].HeaderText = "Customer Name";
                dgvReviews.Columns[2].Width = 150;

                dgvReviews.Columns[3].HeaderText = "ReviewText";
                dgvReviews.Columns[3].Width = 140;

                dgvReviews.Columns[4].HeaderText = "Rating";
                dgvReviews.Columns[4].Width = 130;

                dgvReviews.Columns[5].HeaderText = "Review Date";
                dgvReviews.Columns[5].Width = 140;
            }
        }

        private void addNewReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditReview frm = new frmAddEditReview();

            frm.ShowDialog();

            frmListReviews_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditReview frm = new frmAddEditReview((int)dgvReviews.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmListReviews_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Review " + ((int)dgvReviews.CurrentRow.Cells[0].Value), "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (clsReview.DeleteReview((int)dgvReviews.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Review Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListReviews_Load(null, null);

            }
            else
                MessageBox.Show("Review Failed to Delete");
        }

        private void btnAddNewReviews_Click(object sender, EventArgs e)
        {
            frmAddEditReview frm = new frmAddEditReview();

            frm.ShowDialog();

            frmListReviews_Load(null, null);
        }

        private void GetReviewsByPage()
        {
            _dtReviews = clsReview.GetAllReviews(cbPages.SelectedIndex + 1);
            dgvReviews.DataSource = _dtReviews;
            lblReviewsCount.Text = _dtReviews.Rows.Count.ToString();
        }

        private void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetReviewsByPage();
        }
    }
}
