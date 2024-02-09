﻿namespace OnlineStoreWinform.ProductCatalog
{
    partial class frmListProductCatlog
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
            this.dgvProductCatalog = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductCatalogCount = new System.Windows.Forms.Label();
            this.btnAddNewProductCatalog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCatalog)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductCatalog
            // 
            this.dgvProductCatalog.AllowUserToAddRows = false;
            this.dgvProductCatalog.AllowUserToDeleteRows = false;
            this.dgvProductCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductCatalog.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProductCatalog.Location = new System.Drawing.Point(18, 114);
            this.dgvProductCatalog.Name = "dgvProductCatalog";
            this.dgvProductCatalog.ReadOnly = true;
            this.dgvProductCatalog.RowHeadersWidth = 51;
            this.dgvProductCatalog.RowTemplate.Height = 24;
            this.dgvProductCatalog.Size = new System.Drawing.Size(706, 242);
            this.dgvProductCatalog.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCustomerDetailsToolStripMenuItem,
            this.addNewPaymentToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 128);
            // 
            // showCustomerDetailsToolStripMenuItem
            // 
            this.showCustomerDetailsToolStripMenuItem.Name = "showCustomerDetailsToolStripMenuItem";
            this.showCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.showCustomerDetailsToolStripMenuItem.Text = "Show Payment Details";
            // 
            // addNewPaymentToolStripMenuItem
            // 
            this.addNewPaymentToolStripMenuItem.Name = "addNewPaymentToolStripMenuItem";
            this.addNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.addNewPaymentToolStripMenuItem.Text = "Add New Payment";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 60);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(235, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Product Catalog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(22, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Catalog Count";
            // 
            // lblProductCatalogCount
            // 
            this.lblProductCatalogCount.AutoSize = true;
            this.lblProductCatalogCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCatalogCount.ForeColor = System.Drawing.Color.Navy;
            this.lblProductCatalogCount.Location = new System.Drawing.Point(247, 372);
            this.lblProductCatalogCount.Name = "lblProductCatalogCount";
            this.lblProductCatalogCount.Size = new System.Drawing.Size(45, 25);
            this.lblProductCatalogCount.TabIndex = 15;
            this.lblProductCatalogCount.Text = "???";
            // 
            // btnAddNewProductCatalog
            // 
            this.btnAddNewProductCatalog.Location = new System.Drawing.Point(649, 33);
            this.btnAddNewProductCatalog.Name = "btnAddNewProductCatalog";
            this.btnAddNewProductCatalog.Size = new System.Drawing.Size(75, 60);
            this.btnAddNewProductCatalog.TabIndex = 14;
            this.btnAddNewProductCatalog.Text = "Add";
            this.btnAddNewProductCatalog.UseVisualStyleBackColor = true;
            // 
            // frmListProductCatlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductCatalog);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProductCatalogCount);
            this.Controls.Add(this.btnAddNewProductCatalog);
            this.Name = "frmListProductCatlog";
            this.Text = "frmListProductCatlog";
            this.Load += new System.EventHandler(this.frmListProductCatlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCatalog)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductCatalog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductCatalogCount;
        private System.Windows.Forms.Button btnAddNewProductCatalog;
    }
}