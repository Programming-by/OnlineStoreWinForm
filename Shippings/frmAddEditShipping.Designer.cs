namespace OnlineStoreWinform.Shippings
{
    partial class frmAddEditShipping
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
            this.tbShippingInfo = new System.Windows.Forms.TabControl();
            this.tpOrderInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpShippingInfo = new System.Windows.Forms.TabPage();
            this.dateTimePickerActual = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShippingID = new System.Windows.Forms.Label();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.txtCarrierName = new System.Windows.Forms.TextBox();
            this.dateTimePickerEstimated = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlShowOrderDetailsWithFilter1 = new OnlineStoreWinform.Orders.Controls.ctrlShowOrderDetailsWithFilter();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbShippingInfo.SuspendLayout();
            this.tpOrderInfo.SuspendLayout();
            this.tpShippingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbShippingInfo
            // 
            this.tbShippingInfo.Controls.Add(this.tpOrderInfo);
            this.tbShippingInfo.Controls.Add(this.tpShippingInfo);
            this.tbShippingInfo.Location = new System.Drawing.Point(12, 28);
            this.tbShippingInfo.Name = "tbShippingInfo";
            this.tbShippingInfo.SelectedIndex = 0;
            this.tbShippingInfo.Size = new System.Drawing.Size(739, 456);
            this.tbShippingInfo.TabIndex = 5;
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
            // tpShippingInfo
            // 
            this.tpShippingInfo.Controls.Add(this.lblStatus);
            this.tpShippingInfo.Controls.Add(this.dateTimePickerEstimated);
            this.tpShippingInfo.Controls.Add(this.txtCarrierName);
            this.tpShippingInfo.Controls.Add(this.txtTrackingNumber);
            this.tpShippingInfo.Controls.Add(this.lblShippingID);
            this.tpShippingInfo.Controls.Add(this.label6);
            this.tpShippingInfo.Controls.Add(this.label4);
            this.tpShippingInfo.Controls.Add(this.dateTimePickerActual);
            this.tpShippingInfo.Controls.Add(this.label1);
            this.tpShippingInfo.Controls.Add(this.label5);
            this.tpShippingInfo.Controls.Add(this.label3);
            this.tpShippingInfo.Controls.Add(this.label2);
            this.tpShippingInfo.Location = new System.Drawing.Point(4, 25);
            this.tpShippingInfo.Name = "tpShippingInfo";
            this.tpShippingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpShippingInfo.Size = new System.Drawing.Size(731, 427);
            this.tpShippingInfo.TabIndex = 1;
            this.tpShippingInfo.Text = "ShippingInfo";
            this.tpShippingInfo.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerActual
            // 
            this.dateTimePickerActual.Location = new System.Drawing.Point(313, 284);
            this.dateTimePickerActual.Name = "dateTimePickerActual";
            this.dateTimePickerActual.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerActual.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(82, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shipping Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(82, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tracking Nunber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(82, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "CarrierName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(82, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ShippingID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(82, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estimated Delivery Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(82, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Actual Delivery Date:";
            // 
            // lblShippingID
            // 
            this.lblShippingID.AutoSize = true;
            this.lblShippingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingID.ForeColor = System.Drawing.Color.Navy;
            this.lblShippingID.Location = new System.Drawing.Point(309, 41);
            this.lblShippingID.Name = "lblShippingID";
            this.lblShippingID.Size = new System.Drawing.Size(36, 20);
            this.lblShippingID.TabIndex = 20;
            this.lblShippingID.Text = "???";
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(313, 141);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(200, 22);
            this.txtTrackingNumber.TabIndex = 21;
            this.txtTrackingNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrackingNumber_KeyPress);
            this.txtTrackingNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrackingNumber_Validating);
            // 
            // txtCarrierName
            // 
            this.txtCarrierName.Location = new System.Drawing.Point(313, 94);
            this.txtCarrierName.Name = "txtCarrierName";
            this.txtCarrierName.Size = new System.Drawing.Size(200, 22);
            this.txtCarrierName.TabIndex = 22;
            this.txtCarrierName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCarrierName_Validating);
            // 
            // dateTimePickerEstimated
            // 
            this.dateTimePickerEstimated.Location = new System.Drawing.Point(313, 238);
            this.dateTimePickerEstimated.Name = "dateTimePickerEstimated";
            this.dateTimePickerEstimated.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEstimated.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(276, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 25);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Add New Shipping";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(613, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(450, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlShowOrderDetailsWithFilter1
            // 
            this.ctrlShowOrderDetailsWithFilter1.FilterEnabled = true;
            this.ctrlShowOrderDetailsWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowOrderDetailsWithFilter1.Name = "ctrlShowOrderDetailsWithFilter1";
            this.ctrlShowOrderDetailsWithFilter1.Size = new System.Drawing.Size(616, 394);
            this.ctrlShowOrderDetailsWithFilter1.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(309, 197);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "???";
            // 
            // frmAddEditShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbShippingInfo);
            this.Name = "frmAddEditShipping";
            this.Text = "frmAddEditShipping";
            this.Load += new System.EventHandler(this.frmAddEditShipping_Load);
            this.tbShippingInfo.ResumeLayout(false);
            this.tpOrderInfo.ResumeLayout(false);
            this.tpShippingInfo.ResumeLayout(false);
            this.tpShippingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbShippingInfo;
        private System.Windows.Forms.TabPage tpOrderInfo;
        private Orders.Controls.ctrlShowOrderDetailsWithFilter ctrlShowOrderDetailsWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpShippingInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEstimated;
        private System.Windows.Forms.TextBox txtCarrierName;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShippingID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
    }
}