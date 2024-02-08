namespace OnlineStoreWinform.Payments
{
    partial class frmAddEditPayment
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
            this.tbPaymentInfo = new System.Windows.Forms.TabControl();
            this.tpOrderInfo = new System.Windows.Forms.TabPage();
            this.ctrlShowOrderDetailsWithFilter1 = new OnlineStoreWinform.Orders.Controls.ctrlShowOrderDetailsWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpPaymentInfo = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbPaymentInfo.SuspendLayout();
            this.tpOrderInfo.SuspendLayout();
            this.tpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPaymentInfo
            // 
            this.tbPaymentInfo.Controls.Add(this.tpOrderInfo);
            this.tbPaymentInfo.Controls.Add(this.tpPaymentInfo);
            this.tbPaymentInfo.Location = new System.Drawing.Point(12, 36);
            this.tbPaymentInfo.Name = "tbPaymentInfo";
            this.tbPaymentInfo.SelectedIndex = 0;
            this.tbPaymentInfo.Size = new System.Drawing.Size(739, 456);
            this.tbPaymentInfo.TabIndex = 4;
            // 
            // tpOrderInfo
            // 
            this.tpOrderInfo.Controls.Add(this.ctrlShowOrderDetailsWithFilter1);
            this.tpOrderInfo.Controls.Add(this.btnNext);
            this.tpOrderInfo.Location = new System.Drawing.Point(4, 25);
            this.tpOrderInfo.Name = "tpOrderInfo";
            this.tpOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderInfo.Size = new System.Drawing.Size(731, 427);
            this.tpOrderInfo.TabIndex = 0;
            this.tpOrderInfo.Text = "OrderInfo";
            this.tpOrderInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlShowOrderDetailsWithFilter1
            // 
            this.ctrlShowOrderDetailsWithFilter1.FilterEnabled = true;
            this.ctrlShowOrderDetailsWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowOrderDetailsWithFilter1.Name = "ctrlShowOrderDetailsWithFilter1";
            this.ctrlShowOrderDetailsWithFilter1.Size = new System.Drawing.Size(616, 394);
            this.ctrlShowOrderDetailsWithFilter1.TabIndex = 22;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(621, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 77);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpPaymentInfo
            // 
            this.tpPaymentInfo.Controls.Add(this.dateTimePicker1);
            this.tpPaymentInfo.Controls.Add(this.cbPaymentMethod);
            this.tpPaymentInfo.Controls.Add(this.txtAmount);
            this.tpPaymentInfo.Controls.Add(this.lblPaymentID);
            this.tpPaymentInfo.Controls.Add(this.label1);
            this.tpPaymentInfo.Controls.Add(this.label5);
            this.tpPaymentInfo.Controls.Add(this.label3);
            this.tpPaymentInfo.Controls.Add(this.label2);
            this.tpPaymentInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPaymentInfo.Name = "tpPaymentInfo";
            this.tpPaymentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaymentInfo.Size = new System.Drawing.Size(731, 427);
            this.tpPaymentInfo.TabIndex = 1;
            this.tpPaymentInfo.Text = "PaymentInfo";
            this.tpPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Visa",
            "Master Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(250, 207);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(200, 24);
            this.cbPaymentMethod.TabIndex = 16;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(250, 159);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.ForeColor = System.Drawing.Color.Navy;
            this.lblPaymentID.Location = new System.Drawing.Point(262, 94);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(36, 20);
            this.lblPaymentID.TabIndex = 11;
            this.lblPaymentID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(82, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transactions Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(82, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment Method:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(82, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "PaymentID:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(620, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(396, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(253, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 25);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Add New Payment";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbPaymentInfo);
            this.Name = "frmAddEditPayment";
            this.Text = "frmAddEditPayment";
            this.Load += new System.EventHandler(this.frmAddEditPayment_Load);
            this.tbPaymentInfo.ResumeLayout(false);
            this.tpOrderInfo.ResumeLayout(false);
            this.tpPaymentInfo.ResumeLayout(false);
            this.tpPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbPaymentInfo;
        private System.Windows.Forms.TabPage tpOrderInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpPaymentInfo;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Orders.Controls.ctrlShowOrderDetailsWithFilter ctrlShowOrderDetailsWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}