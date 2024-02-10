namespace OnlineStoreWinform.ProductImages
{
    partial class frmListProductImages
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
            this.dgvProductImages = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewProductCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductImagesCount = new System.Windows.Forms.Label();
            this.btnAddNewProductImages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductImages)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductImages
            // 
            this.dgvProductImages.AllowUserToAddRows = false;
            this.dgvProductImages.AllowUserToDeleteRows = false;
            this.dgvProductImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductImages.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProductImages.Location = new System.Drawing.Point(7, 105);
            this.dgvProductImages.Name = "dgvProductImages";
            this.dgvProductImages.ReadOnly = true;
            this.dgvProductImages.RowHeadersWidth = 51;
            this.dgvProductImages.RowTemplate.Height = 24;
            this.dgvProductImages.Size = new System.Drawing.Size(706, 242);
            this.dgvProductImages.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductCatalogToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 76);
            // 
            // addNewProductCatalogToolStripMenuItem
            // 
            this.addNewProductCatalogToolStripMenuItem.Name = "addNewProductCatalogToolStripMenuItem";
            this.addNewProductCatalogToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.addNewProductCatalogToolStripMenuItem.Text = "Add New Product Images";
            this.addNewProductCatalogToolStripMenuItem.Click += new System.EventHandler(this.addNewProductCatalogToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(596, 363);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 60);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Product Images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(11, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Product Images Count";
            // 
            // lblProductImagesCount
            // 
            this.lblProductImagesCount.AutoSize = true;
            this.lblProductImagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductImagesCount.ForeColor = System.Drawing.Color.Navy;
            this.lblProductImagesCount.Location = new System.Drawing.Point(236, 363);
            this.lblProductImagesCount.Name = "lblProductImagesCount";
            this.lblProductImagesCount.Size = new System.Drawing.Size(45, 25);
            this.lblProductImagesCount.TabIndex = 21;
            this.lblProductImagesCount.Text = "???";
            // 
            // btnAddNewProductImages
            // 
            this.btnAddNewProductImages.Location = new System.Drawing.Point(638, 24);
            this.btnAddNewProductImages.Name = "btnAddNewProductImages";
            this.btnAddNewProductImages.Size = new System.Drawing.Size(75, 60);
            this.btnAddNewProductImages.TabIndex = 20;
            this.btnAddNewProductImages.Text = "Add";
            this.btnAddNewProductImages.UseVisualStyleBackColor = true;
            this.btnAddNewProductImages.Click += new System.EventHandler(this.btnAddNewProductImages_Click);
            // 
            // frmListProductImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.dgvProductImages);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProductImagesCount);
            this.Controls.Add(this.btnAddNewProductImages);
            this.Name = "frmListProductImages";
            this.Text = "frmListProductImages";
            this.Load += new System.EventHandler(this.frmListProductImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductImages)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductImages;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewProductCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductImagesCount;
        private System.Windows.Forms.Button btnAddNewProductImages;
    }
}