namespace OnlineStoreWinform.ProductCatalog
{
    partial class frmAddEditProductCatalog
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
            this.components = new System.ComponentModel.Container();
            this.tbProductCatalog = new System.Windows.Forms.TabControl();
            this.tpCategoryInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpProductCatalog = new System.Windows.Forms.TabPage();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlCategoryDetailsWithFilter1 = new OnlineStoreWinform.ProductCategory.ctrlCategoryDetailsWithFilter();
            this.tbProductCatalog.SuspendLayout();
            this.tpCategoryInfo.SuspendLayout();
            this.tpProductCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductCatalog
            // 
            this.tbProductCatalog.Controls.Add(this.tpCategoryInfo);
            this.tbProductCatalog.Controls.Add(this.tpProductCatalog);
            this.tbProductCatalog.Location = new System.Drawing.Point(12, 40);
            this.tbProductCatalog.Name = "tbProductCatalog";
            this.tbProductCatalog.SelectedIndex = 0;
            this.tbProductCatalog.Size = new System.Drawing.Size(739, 456);
            this.tbProductCatalog.TabIndex = 5;
            // 
            // tpCategoryInfo
            // 
            this.tpCategoryInfo.Controls.Add(this.ctrlCategoryDetailsWithFilter1);
            this.tpCategoryInfo.Controls.Add(this.btnNext);
            this.tpCategoryInfo.Location = new System.Drawing.Point(4, 25);
            this.tpCategoryInfo.Name = "tpCategoryInfo";
            this.tpCategoryInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategoryInfo.Size = new System.Drawing.Size(731, 427);
            this.tpCategoryInfo.TabIndex = 0;
            this.tpCategoryInfo.Text = "CategoryInfo";
            this.tpCategoryInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(599, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 77);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpProductCatalog
            // 
            this.tpProductCatalog.Controls.Add(this.txtImageURL);
            this.tpProductCatalog.Controls.Add(this.txtQuantityInStock);
            this.tpProductCatalog.Controls.Add(this.txtPrice);
            this.tpProductCatalog.Controls.Add(this.txtDescription);
            this.tpProductCatalog.Controls.Add(this.label7);
            this.tpProductCatalog.Controls.Add(this.label6);
            this.tpProductCatalog.Controls.Add(this.txtProductName);
            this.tpProductCatalog.Controls.Add(this.lblProductID);
            this.tpProductCatalog.Controls.Add(this.label1);
            this.tpProductCatalog.Controls.Add(this.label5);
            this.tpProductCatalog.Controls.Add(this.label3);
            this.tpProductCatalog.Controls.Add(this.label2);
            this.tpProductCatalog.Location = new System.Drawing.Point(4, 25);
            this.tpProductCatalog.Name = "tpProductCatalog";
            this.tpProductCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductCatalog.Size = new System.Drawing.Size(731, 427);
            this.tpProductCatalog.TabIndex = 1;
            this.tpProductCatalog.Text = "ProductInfo";
            this.tpProductCatalog.UseVisualStyleBackColor = true;
            // 
            // txtImageURL
            // 
            this.txtImageURL.Location = new System.Drawing.Point(250, 314);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(200, 22);
            this.txtImageURL.TabIndex = 23;
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Location = new System.Drawing.Point(250, 269);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(200, 22);
            this.txtQuantityInStock.TabIndex = 22;
            this.txtQuantityInStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterNumberOnly);
            this.txtQuantityInStock.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(250, 227);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterNumberOnly);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(250, 181);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(82, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "ImageURL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(82, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity In Stock:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(250, 138);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.txtProductName.TabIndex = 15;
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.Navy;
            this.lblProductID.Location = new System.Drawing.Point(262, 94);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(36, 20);
            this.lblProductID.TabIndex = 11;
            this.lblProductID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(82, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(82, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(82, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ProductName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProductID:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(615, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(391, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(241, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 25);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Add New Product Catalog";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlCategoryDetailsWithFilter1
            // 
            this.ctrlCategoryDetailsWithFilter1.CategoryID = -1;
            this.ctrlCategoryDetailsWithFilter1.FilterEnabled = true;
            this.ctrlCategoryDetailsWithFilter1.Location = new System.Drawing.Point(40, 87);
            this.ctrlCategoryDetailsWithFilter1.Name = "ctrlCategoryDetailsWithFilter1";
            this.ctrlCategoryDetailsWithFilter1.Size = new System.Drawing.Size(540, 170);
            this.ctrlCategoryDetailsWithFilter1.TabIndex = 22;
            // 
            // frmAddEditProductCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbProductCatalog);
            this.Name = "frmAddEditProductCatalog";
            this.Text = "frmAddEditProductCatalog";
            this.Load += new System.EventHandler(this.frmAddEditProductCatalog_Load);
            this.tbProductCatalog.ResumeLayout(false);
            this.tpCategoryInfo.ResumeLayout(false);
            this.tpProductCatalog.ResumeLayout(false);
            this.tpProductCatalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbProductCatalog;
        private System.Windows.Forms.TabPage tpCategoryInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpProductCatalog;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ProductCategory.ctrlCategoryDetailsWithFilter ctrlCategoryDetailsWithFilter1;
    }
}