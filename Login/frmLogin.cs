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

namespace OnlineStoreWinform.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool IsLoggedInInfoValid = false;
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "this field is required");

            } else
                errorProvider1.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "this field is required");

            }
            else
                errorProvider1.SetError(txtPassword, "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsLoggedInInfoValid = clsCustomer.FindUserNameAndPassword(txtUsername.Text,txtPassword.Text);
            if (!IsLoggedInInfoValid)
            {
                MessageBox.Show("Invalid Username or Password");
                return;
            }
            this.Hide();
            frmMain frm = new frmMain(this);
            frm.ShowDialog();
        }
    }
}
