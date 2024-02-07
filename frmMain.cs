﻿using OnlineStoreWinform.Customers;
using OnlineStoreWinform.ProductCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreWinform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListCustomers frm = new FrmListCustomers();

            frm.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListProductCategory frm = new frmListProductCategory();

            frm.ShowDialog();
        }
    }
}
