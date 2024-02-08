namespace OnlineStoreWinform.Orders
{
    partial class frmAddEditOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbOrderInfo = new System.Windows.Forms.TabControl();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlShowCustomerDetailsWithFilter1 = new OnlineStoreWinform.Customers.Controls.ctrlShowCustomerDetailsWithFilter();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbOrderInfo.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(261, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add Edit Order";
            // 
            // tbOrderInfo
            // 
            this.tbOrderInfo.Controls.Add(this.tpCustomerInfo);
            this.tbOrderInfo.Controls.Add(this.tpOrder);
            this.tbOrderInfo.Location = new System.Drawing.Point(12, 65);
            this.tbOrderInfo.Name = "tbOrderInfo";
            this.tbOrderInfo.SelectedIndex = 0;
            this.tbOrderInfo.Size = new System.Drawing.Size(739, 456);
            this.tbOrderInfo.TabIndex = 3;
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.Controls.Add(this.btnNext);
            this.tpCustomerInfo.Controls.Add(this.ctrlShowCustomerDetailsWithFilter1);
            this.tpCustomerInfo.Location = new System.Drawing.Point(4, 25);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomerInfo.Size = new System.Drawing.Size(731, 427);
            this.tpCustomerInfo.TabIndex = 0;
            this.tpCustomerInfo.Text = "CustomerInfo";
            this.tpCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(608, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 77);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlShowCustomerDetailsWithFilter1
            // 
            this.ctrlShowCustomerDetailsWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowCustomerDetailsWithFilter1.Name = "ctrlShowCustomerDetailsWithFilter1";
            this.ctrlShowCustomerDetailsWithFilter1.Size = new System.Drawing.Size(616, 393);
            this.ctrlShowCustomerDetailsWithFilter1.TabIndex = 0;
            // 
            // tpOrder
            // 
            this.tpOrder.Controls.Add(this.lblStatus);
            this.tpOrder.Controls.Add(this.txtTotalAmount);
            this.tpOrder.Controls.Add(this.dateTimePicker1);
            this.tpOrder.Controls.Add(this.lblOrderID);
            this.tpOrder.Controls.Add(this.label1);
            this.tpOrder.Controls.Add(this.label5);
            this.tpOrder.Controls.Add(this.label3);
            this.tpOrder.Controls.Add(this.label2);
            this.tpOrder.Location = new System.Drawing.Point(4, 25);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrder.Size = new System.Drawing.Size(731, 427);
            this.tpOrder.TabIndex = 1;
            this.tpOrder.Text = "OrderInfo";
            this.tpOrder.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(246, 261);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "???";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(250, 209);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 22);
            this.txtTotalAmount.TabIndex = 13;
            this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
            this.txtTotalAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotalAmount_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.Navy;
            this.lblOrderID.Location = new System.Drawing.Point(262, 94);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(36, 20);
            this.lblOrderID.TabIndex = 11;
            this.lblOrderID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(82, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(82, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(82, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "OrderID:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(590, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbOrderInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditOrder";
            this.Text = "frmAddEditOrder";
            this.Load += new System.EventHandler(this.frmAddEditOrder_Load);
            this.tbOrderInfo.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpOrder.ResumeLayout(false);
            this.tpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbOrderInfo;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.Button btnNext;
        private Customers.Controls.ctrlShowCustomerDetailsWithFilter ctrlShowCustomerDetailsWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}