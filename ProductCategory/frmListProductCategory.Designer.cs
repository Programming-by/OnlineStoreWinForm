namespace OnlineStoreWinform.ProductCategory
{
    partial class frmListProductCategory
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
            this.dgvProductCategory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.btnAddNewProductCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductCategory
            // 
            this.dgvProductCategory.AllowUserToAddRows = false;
            this.dgvProductCategory.AllowUserToDeleteRows = false;
            this.dgvProductCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductCategory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProductCategory.Location = new System.Drawing.Point(47, 136);
            this.dgvProductCategory.Name = "dgvProductCategory";
            this.dgvProductCategory.ReadOnly = true;
            this.dgvProductCategory.RowHeadersWidth = 51;
            this.dgvProductCategory.RowTemplate.Height = 24;
            this.dgvProductCategory.Size = new System.Drawing.Size(706, 242);
            this.dgvProductCategory.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Category";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(270, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Product Category";
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersCount.ForeColor = System.Drawing.Color.Navy;
            this.lblCustomersCount.Location = new System.Drawing.Point(270, 394);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(45, 25);
            this.lblCustomersCount.TabIndex = 8;
            this.lblCustomersCount.Text = "???";
            // 
            // btnAddNewProductCategory
            // 
            this.btnAddNewProductCategory.Location = new System.Drawing.Point(678, 55);
            this.btnAddNewProductCategory.Name = "btnAddNewProductCategory";
            this.btnAddNewProductCategory.Size = new System.Drawing.Size(75, 60);
            this.btnAddNewProductCategory.TabIndex = 7;
            this.btnAddNewProductCategory.Text = "Add";
            this.btnAddNewProductCategory.UseVisualStyleBackColor = true;
            this.btnAddNewProductCategory.Click += new System.EventHandler(this.btnAddNewProductCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(42, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Category Count";
            // 
            // frmListProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProductCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomersCount);
            this.Controls.Add(this.btnAddNewProductCategory);
            this.Name = "frmListProductCategory";
            this.Text = "frmListProductCategory";
            this.Load += new System.EventHandler(this.frmListProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomersCount;
        private System.Windows.Forms.Button btnAddNewProductCategory;
        private System.Windows.Forms.Label label2;
    }
}