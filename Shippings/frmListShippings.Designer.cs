﻿namespace OnlineStoreWinform.Shippings
{
    partial class frmListShippings
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
            this.dgvShipping = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewShippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShippingCount = new System.Windows.Forms.Label();
            this.btnAddNewShipping = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPages = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipping)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShipping
            // 
            this.dgvShipping.AllowUserToAddRows = false;
            this.dgvShipping.AllowUserToDeleteRows = false;
            this.dgvShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipping.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvShipping.Location = new System.Drawing.Point(17, 132);
            this.dgvShipping.Name = "dgvShipping";
            this.dgvShipping.ReadOnly = true;
            this.dgvShipping.RowHeadersWidth = 51;
            this.dgvShipping.RowTemplate.Height = 24;
            this.dgvShipping.Size = new System.Drawing.Size(706, 242);
            this.dgvShipping.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewShippingToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 76);
            // 
            // addNewShippingToolStripMenuItem
            // 
            this.addNewShippingToolStripMenuItem.Name = "addNewShippingToolStripMenuItem";
            this.addNewShippingToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.addNewShippingToolStripMenuItem.Text = "Add New Shipping";
            this.addNewShippingToolStripMenuItem.Click += new System.EventHandler(this.addNewShippingToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(240, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Shippings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(21, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Shippings Count";
            // 
            // lblShippingCount
            // 
            this.lblShippingCount.AutoSize = true;
            this.lblShippingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingCount.ForeColor = System.Drawing.Color.Navy;
            this.lblShippingCount.Location = new System.Drawing.Point(202, 390);
            this.lblShippingCount.Name = "lblShippingCount";
            this.lblShippingCount.Size = new System.Drawing.Size(45, 25);
            this.lblShippingCount.TabIndex = 14;
            this.lblShippingCount.Text = "???";
            // 
            // btnAddNewShipping
            // 
            this.btnAddNewShipping.Location = new System.Drawing.Point(648, 51);
            this.btnAddNewShipping.Name = "btnAddNewShipping";
            this.btnAddNewShipping.Size = new System.Drawing.Size(75, 60);
            this.btnAddNewShipping.TabIndex = 13;
            this.btnAddNewShipping.Text = "Add";
            this.btnAddNewShipping.UseVisualStyleBackColor = true;
            this.btnAddNewShipping.Click += new System.EventHandler(this.btnAddNewShipping_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Page:";
            // 
            // cbPages
            // 
            this.cbPages.FormattingEnabled = true;
            this.cbPages.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbPages.Location = new System.Drawing.Point(102, 86);
            this.cbPages.Name = "cbPages";
            this.cbPages.Size = new System.Drawing.Size(121, 24);
            this.cbPages.TabIndex = 16;
            this.cbPages.SelectedIndexChanged += new System.EventHandler(this.cbPages_SelectedIndexChanged);
            // 
            // frmListShippings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPages);
            this.Controls.Add(this.dgvShipping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShippingCount);
            this.Controls.Add(this.btnAddNewShipping);
            this.Name = "frmListShippings";
            this.Text = "frmListShippings";
            this.Load += new System.EventHandler(this.frmListShippings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipping)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShipping;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewShippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShippingCount;
        private System.Windows.Forms.Button btnAddNewShipping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPages;
    }
}