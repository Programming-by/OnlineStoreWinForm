namespace OnlineStoreWinform.Customers
{
    partial class frmShowCustomerDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlShowCustomersDetails1 = new OnlineStoreWinform.Customers.Controls.ctrlShowCustomersDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlShowCustomersDetails1
            // 
            this.ctrlShowCustomersDetails1.Location = new System.Drawing.Point(12, 12);
            this.ctrlShowCustomersDetails1.Name = "ctrlShowCustomersDetails1";
            this.ctrlShowCustomersDetails1.Size = new System.Drawing.Size(606, 308);
            this.ctrlShowCustomersDetails1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(463, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 409);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlShowCustomersDetails1);
            this.Name = "frmShowCustomerDetails";
            this.Text = "frmShowCustomerDetails";
            this.Load += new System.EventHandler(this.frmShowCustomerDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlShowCustomersDetails ctrlShowCustomersDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}