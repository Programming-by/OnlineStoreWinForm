namespace OnlineStoreWinform.Reviews
{
    partial class frmAddEditReview
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbReviewInfo = new System.Windows.Forms.TabControl();
            this.tpProductInfo = new System.Windows.Forms.TabPage();
            this.ctrlProductDetailsWithFilter1 = new OnlineStoreWinform.ProductCatalog.Controls.ctrlProductDetailsWithFilter();
            this.btnNextToCustomersInfo = new System.Windows.Forms.Button();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.ctrlShowCustomerDetailsWithFilter1 = new OnlineStoreWinform.Customers.Controls.ctrlShowCustomerDetailsWithFilter();
            this.btnNextToReviewInfo = new System.Windows.Forms.Button();
            this.tpReviewInfo = new System.Windows.Forms.TabPage();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerReviewDate = new System.Windows.Forms.DateTimePicker();
            this.txtReviewText = new System.Windows.Forms.TextBox();
            this.lblReviewID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbReviewInfo.SuspendLayout();
            this.tpProductInfo.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tpReviewInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(277, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Add New Review";
            // 
            // tbReviewInfo
            // 
            this.tbReviewInfo.Controls.Add(this.tpProductInfo);
            this.tbReviewInfo.Controls.Add(this.tpCustomerInfo);
            this.tbReviewInfo.Controls.Add(this.tpReviewInfo);
            this.tbReviewInfo.Location = new System.Drawing.Point(12, 73);
            this.tbReviewInfo.Name = "tbReviewInfo";
            this.tbReviewInfo.SelectedIndex = 0;
            this.tbReviewInfo.Size = new System.Drawing.Size(739, 456);
            this.tbReviewInfo.TabIndex = 8;
            // 
            // tpProductInfo
            // 
            this.tpProductInfo.Controls.Add(this.ctrlProductDetailsWithFilter1);
            this.tpProductInfo.Controls.Add(this.btnNextToCustomersInfo);
            this.tpProductInfo.Location = new System.Drawing.Point(4, 25);
            this.tpProductInfo.Name = "tpProductInfo";
            this.tpProductInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductInfo.Size = new System.Drawing.Size(731, 427);
            this.tpProductInfo.TabIndex = 0;
            this.tpProductInfo.Text = "ProductInfo";
            this.tpProductInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlProductDetailsWithFilter1
            // 
            this.ctrlProductDetailsWithFilter1.FilterEnabled = true;
            this.ctrlProductDetailsWithFilter1.Location = new System.Drawing.Point(-4, 3);
            this.ctrlProductDetailsWithFilter1.Name = "ctrlProductDetailsWithFilter1";
            this.ctrlProductDetailsWithFilter1.Size = new System.Drawing.Size(589, 384);
            this.ctrlProductDetailsWithFilter1.TabIndex = 22;
            // 
            // btnNextToCustomersInfo
            // 
            this.btnNextToCustomersInfo.Location = new System.Drawing.Point(608, 310);
            this.btnNextToCustomersInfo.Name = "btnNextToCustomersInfo";
            this.btnNextToCustomersInfo.Size = new System.Drawing.Size(104, 77);
            this.btnNextToCustomersInfo.TabIndex = 21;
            this.btnNextToCustomersInfo.Text = "Next";
            this.btnNextToCustomersInfo.UseVisualStyleBackColor = true;
            this.btnNextToCustomersInfo.Click += new System.EventHandler(this.btnNextToCustomersInfo_Click);
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.Controls.Add(this.ctrlShowCustomerDetailsWithFilter1);
            this.tpCustomerInfo.Controls.Add(this.btnNextToReviewInfo);
            this.tpCustomerInfo.Location = new System.Drawing.Point(4, 25);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomerInfo.Size = new System.Drawing.Size(731, 427);
            this.tpCustomerInfo.TabIndex = 2;
            this.tpCustomerInfo.Text = "CustomerInfo";
            this.tpCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlShowCustomerDetailsWithFilter1
            // 
            this.ctrlShowCustomerDetailsWithFilter1.FilterEnabled = true;
            this.ctrlShowCustomerDetailsWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlShowCustomerDetailsWithFilter1.Name = "ctrlShowCustomerDetailsWithFilter1";
            this.ctrlShowCustomerDetailsWithFilter1.Size = new System.Drawing.Size(616, 413);
            this.ctrlShowCustomerDetailsWithFilter1.TabIndex = 24;
            // 
            // btnNextToReviewInfo
            // 
            this.btnNextToReviewInfo.Location = new System.Drawing.Point(621, 326);
            this.btnNextToReviewInfo.Name = "btnNextToReviewInfo";
            this.btnNextToReviewInfo.Size = new System.Drawing.Size(104, 77);
            this.btnNextToReviewInfo.TabIndex = 23;
            this.btnNextToReviewInfo.Text = "Next";
            this.btnNextToReviewInfo.UseVisualStyleBackColor = true;
            this.btnNextToReviewInfo.Click += new System.EventHandler(this.btnNextToReviewInfo_Click);
            // 
            // tpReviewInfo
            // 
            this.tpReviewInfo.Controls.Add(this.numericUpDownRating);
            this.tpReviewInfo.Controls.Add(this.dateTimePickerReviewDate);
            this.tpReviewInfo.Controls.Add(this.txtReviewText);
            this.tpReviewInfo.Controls.Add(this.lblReviewID);
            this.tpReviewInfo.Controls.Add(this.label1);
            this.tpReviewInfo.Controls.Add(this.label5);
            this.tpReviewInfo.Controls.Add(this.label3);
            this.tpReviewInfo.Controls.Add(this.label2);
            this.tpReviewInfo.Location = new System.Drawing.Point(4, 25);
            this.tpReviewInfo.Name = "tpReviewInfo";
            this.tpReviewInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReviewInfo.Size = new System.Drawing.Size(731, 427);
            this.tpReviewInfo.TabIndex = 1;
            this.tpReviewInfo.Text = "ReviewInfo";
            this.tpReviewInfo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(250, 198);
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownRating.TabIndex = 18;
            // 
            // dateTimePickerReviewDate
            // 
            this.dateTimePickerReviewDate.Location = new System.Drawing.Point(250, 247);
            this.dateTimePickerReviewDate.Name = "dateTimePickerReviewDate";
            this.dateTimePickerReviewDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerReviewDate.TabIndex = 17;
            // 
            // txtReviewText
            // 
            this.txtReviewText.Location = new System.Drawing.Point(250, 147);
            this.txtReviewText.Name = "txtReviewText";
            this.txtReviewText.Size = new System.Drawing.Size(200, 22);
            this.txtReviewText.TabIndex = 15;
            // 
            // lblReviewID
            // 
            this.lblReviewID.AutoSize = true;
            this.lblReviewID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewID.ForeColor = System.Drawing.Color.Navy;
            this.lblReviewID.Location = new System.Drawing.Point(262, 94);
            this.lblReviewID.Name = "lblReviewID";
            this.lblReviewID.Size = new System.Drawing.Size(36, 20);
            this.lblReviewID.TabIndex = 11;
            this.lblReviewID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(82, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Review Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(82, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rating:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(82, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ReviewText:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ReviewID:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(613, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(389, 535);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbReviewInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditReview";
            this.Text = "frmAddEditReview";
            this.Load += new System.EventHandler(this.frmAddEditReview_Load);
            this.tbReviewInfo.ResumeLayout(false);
            this.tpProductInfo.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpReviewInfo.ResumeLayout(false);
            this.tpReviewInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbReviewInfo;
        private System.Windows.Forms.TabPage tpProductInfo;
        private System.Windows.Forms.Button btnNextToCustomersInfo;
        private System.Windows.Forms.TabPage tpReviewInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerReviewDate;
        private System.Windows.Forms.TextBox txtReviewText;
        private System.Windows.Forms.Label lblReviewID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private ProductCatalog.Controls.ctrlProductDetailsWithFilter ctrlProductDetailsWithFilter1;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private Customers.Controls.ctrlShowCustomerDetailsWithFilter ctrlShowCustomerDetailsWithFilter1;
        private System.Windows.Forms.Button btnNextToReviewInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
    }
}