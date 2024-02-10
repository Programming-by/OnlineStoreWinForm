namespace OnlineStoreWinform.OrderItems
{
    partial class frmAddEditOrderItem
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
            this.tbOrderItemInfo = new System.Windows.Forms.TabControl();
            this.tpProductInfo = new System.Windows.Forms.TabPage();
            this.ctrlProductDetailsWithFilter1 = new OnlineStoreWinform.ProductCatalog.Controls.ctrlProductDetailsWithFilter();
            this.btnNextToOrderItemsInfo = new System.Windows.Forms.Button();
            this.tpOrderInfo = new System.Windows.Forms.TabPage();
            this.btnNextToProductInfo = new System.Windows.Forms.Button();
            this.tpOrderItemInfo = new System.Windows.Forms.TabPage();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblOrderItemID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtTotalItemsPrice = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlShowOrderDetailsWithFilter1 = new OnlineStoreWinform.Orders.Controls.ctrlShowOrderDetailsWithFilter();
            this.tbOrderItemInfo.SuspendLayout();
            this.tpProductInfo.SuspendLayout();
            this.tpOrderInfo.SuspendLayout();
            this.tpOrderItemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOrderItemInfo
            // 
            this.tbOrderItemInfo.Controls.Add(this.tpOrderInfo);
            this.tbOrderItemInfo.Controls.Add(this.tpProductInfo);
            this.tbOrderItemInfo.Controls.Add(this.tpOrderItemInfo);
            this.tbOrderItemInfo.Location = new System.Drawing.Point(24, 41);
            this.tbOrderItemInfo.Name = "tbOrderItemInfo";
            this.tbOrderItemInfo.SelectedIndex = 0;
            this.tbOrderItemInfo.Size = new System.Drawing.Size(739, 456);
            this.tbOrderItemInfo.TabIndex = 9;
            // 
            // tpProductInfo
            // 
            this.tpProductInfo.Controls.Add(this.ctrlProductDetailsWithFilter1);
            this.tpProductInfo.Controls.Add(this.btnNextToOrderItemsInfo);
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
            // btnNextToOrderItemsInfo
            // 
            this.btnNextToOrderItemsInfo.Location = new System.Drawing.Point(608, 310);
            this.btnNextToOrderItemsInfo.Name = "btnNextToOrderItemsInfo";
            this.btnNextToOrderItemsInfo.Size = new System.Drawing.Size(104, 77);
            this.btnNextToOrderItemsInfo.TabIndex = 21;
            this.btnNextToOrderItemsInfo.Text = "Next";
            this.btnNextToOrderItemsInfo.UseVisualStyleBackColor = true;
            this.btnNextToOrderItemsInfo.Click += new System.EventHandler(this.btnNextToOrderItemsInfo_Click);
            // 
            // tpOrderInfo
            // 
            this.tpOrderInfo.Controls.Add(this.ctrlShowOrderDetailsWithFilter1);
            this.tpOrderInfo.Controls.Add(this.btnNextToProductInfo);
            this.tpOrderInfo.Location = new System.Drawing.Point(4, 25);
            this.tpOrderInfo.Name = "tpOrderInfo";
            this.tpOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderInfo.Size = new System.Drawing.Size(731, 427);
            this.tpOrderInfo.TabIndex = 2;
            this.tpOrderInfo.Text = "OrderInfo";
            this.tpOrderInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextToProductInfo
            // 
            this.btnNextToProductInfo.Location = new System.Drawing.Point(621, 326);
            this.btnNextToProductInfo.Name = "btnNextToProductInfo";
            this.btnNextToProductInfo.Size = new System.Drawing.Size(104, 77);
            this.btnNextToProductInfo.TabIndex = 23;
            this.btnNextToProductInfo.Text = "Next";
            this.btnNextToProductInfo.UseVisualStyleBackColor = true;
            this.btnNextToProductInfo.Click += new System.EventHandler(this.btnNextToProductInfo_Click);
            // 
            // tpOrderItemInfo
            // 
            this.tpOrderItemInfo.Controls.Add(this.txtTotalItemsPrice);
            this.tpOrderItemInfo.Controls.Add(this.numericUpDownQuantity);
            this.tpOrderItemInfo.Controls.Add(this.txtPrice);
            this.tpOrderItemInfo.Controls.Add(this.lblOrderItemID);
            this.tpOrderItemInfo.Controls.Add(this.label1);
            this.tpOrderItemInfo.Controls.Add(this.label5);
            this.tpOrderItemInfo.Controls.Add(this.label3);
            this.tpOrderItemInfo.Controls.Add(this.label2);
            this.tpOrderItemInfo.Location = new System.Drawing.Point(4, 25);
            this.tpOrderItemInfo.Name = "tpOrderItemInfo";
            this.tpOrderItemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderItemInfo.Size = new System.Drawing.Size(731, 427);
            this.tpOrderItemInfo.TabIndex = 1;
            this.tpOrderItemInfo.Text = "OrderItemInfo";
            this.tpOrderItemInfo.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(250, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // lblOrderItemID
            // 
            this.lblOrderItemID.AutoSize = true;
            this.lblOrderItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItemID.ForeColor = System.Drawing.Color.Navy;
            this.lblOrderItemID.Location = new System.Drawing.Point(262, 94);
            this.lblOrderItemID.Name = "lblOrderItemID";
            this.lblOrderItemID.Size = new System.Drawing.Size(36, 20);
            this.lblOrderItemID.TabIndex = 11;
            this.lblOrderItemID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(82, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "TotalItemsPrice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(82, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(82, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "OrderItemID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(271, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 25);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Add New OrderItem";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(250, 145);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownQuantity.TabIndex = 19;
            // 
            // txtTotalItemsPrice
            // 
            this.txtTotalItemsPrice.Location = new System.Drawing.Point(248, 245);
            this.txtTotalItemsPrice.Name = "txtTotalItemsPrice";
            this.txtTotalItemsPrice.Size = new System.Drawing.Size(200, 22);
            this.txtTotalItemsPrice.TabIndex = 20;
            this.txtTotalItemsPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalItemsPrice_KeyPress);
            this.txtTotalItemsPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotalItemsPrice_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(621, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(439, 503);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlShowOrderDetailsWithFilter1
            // 
            this.ctrlShowOrderDetailsWithFilter1.FilterEnabled = true;
            this.ctrlShowOrderDetailsWithFilter1.Location = new System.Drawing.Point(3, 0);
            this.ctrlShowOrderDetailsWithFilter1.Name = "ctrlShowOrderDetailsWithFilter1";
            this.ctrlShowOrderDetailsWithFilter1.Size = new System.Drawing.Size(616, 394);
            this.ctrlShowOrderDetailsWithFilter1.TabIndex = 24;
            // 
            // frmAddEditOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbOrderItemInfo);
            this.Name = "frmAddEditOrderItem";
            this.Text = "frmAddEditOrderItem";
            this.Load += new System.EventHandler(this.frmAddEditOrderItem_Load);
            this.tbOrderItemInfo.ResumeLayout(false);
            this.tpProductInfo.ResumeLayout(false);
            this.tpOrderInfo.ResumeLayout(false);
            this.tpOrderItemInfo.ResumeLayout(false);
            this.tpOrderItemInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbOrderItemInfo;
        private System.Windows.Forms.TabPage tpProductInfo;
        private ProductCatalog.Controls.ctrlProductDetailsWithFilter ctrlProductDetailsWithFilter1;
        private System.Windows.Forms.Button btnNextToOrderItemsInfo;
        private System.Windows.Forms.TabPage tpOrderInfo;
        private System.Windows.Forms.Button btnNextToProductInfo;
        private System.Windows.Forms.TabPage tpOrderItemInfo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblOrderItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTotalItemsPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Orders.Controls.ctrlShowOrderDetailsWithFilter ctrlShowOrderDetailsWithFilter1;
    }
}