namespace OnlineStoreWinform.Customers
{
    partial class FrmListCustomers
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(271, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Customers";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCustomers.Location = new System.Drawing.Point(48, 143);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(706, 242);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCustomerDetailsToolStripMenuItem,
            this.addNewCustomerToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 100);
            // 
            // showCustomerDetailsToolStripMenuItem
            // 
            this.showCustomerDetailsToolStripMenuItem.Name = "showCustomerDetailsToolStripMenuItem";
            this.showCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.showCustomerDetailsToolStripMenuItem.Text = "Show Customer Details";
            this.showCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCustomerDetailsToolStripMenuItem_Click);
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(679, 62);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(75, 60);
            this.btnAddNewCustomer.TabIndex = 3;
            this.btnAddNewCustomer.Text = "Add";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersCount.ForeColor = System.Drawing.Color.Navy;
            this.lblCustomersCount.Location = new System.Drawing.Point(233, 401);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(45, 25);
            this.lblCustomersCount.TabIndex = 4;
            this.lblCustomersCount.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(52, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customers Count";
            // 
            // FrmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomersCount);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.label1);
            this.Name = "FrmListCustomers";
            this.Text = "FrmListCustomers";
            this.Load += new System.EventHandler(this.FrmListCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblCustomersCount;
        private System.Windows.Forms.Label label2;
    }
}