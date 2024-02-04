using OnlineStoreBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineStoreWinform
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get all
            // dataGridView1.DataSource = clsPayment.GetAllPayments();

            //find
            //clsPayment payment = clsPayment.Find(1);

            //MessageBox.Show(payment.PaymentMethod.ToString());

            //add new
            //clsPayment payment = new clsPayment();

            //payment.OrderID = 1;
            //payment.Amount = 350;
            //payment.PaymentMethod = "Cash";
            //payment.TransactionDate = DateTime.Parse("2023-08-01");

            //if (payment.Save())
            //{
            //    MessageBox.Show(payment.PaymentID.ToString());

            //}
            //else
            //{
            //    MessageBox.Show("dd");
            //}

            // update

            //clsPayment payment = clsPayment.Find(1);

            //if (payment != null)
            //{
            //    payment.OrderID = 2;
            //    payment.Amount = 600;
            //    payment.PaymentMethod = "Master Card";
            //    payment.TransactionDate = DateTime.Parse("2023-08-10");
            //    if (payment.Save())
            //    {
            //        MessageBox.Show("Updated");
            //    }
            //    else
            //    {
            //        MessageBox.Show("failed");
            //    }

            // delete

            bool IsDeleted = clsPayment.DeletePayment(3);

            if (IsDeleted)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");



        }
    }
}
