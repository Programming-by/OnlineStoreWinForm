namespace OnlineStoreWinform.Orders
{
    partial class frmListOrders
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOrders.Location = new System.Drawing.Point(12, 135);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(706, 242);
            this.dgvOrders.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOrderDetailsToolStripMenuItem,
            this.addNewOrderToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // showOrderDetailsToolStripMenuItem
            // 
            this.showOrderDetailsToolStripMenuItem.Name = "showOrderDetailsToolStripMenuItem";
            this.showOrderDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showOrderDetailsToolStripMenuItem.Text = "Show Order Details";
            this.showOrderDetailsToolStripMenuItem.Click += new System.EventHandler(this.showOrderDetailsToolStripMenuItem_Click);
            // 
            // addNewOrderToolStripMenuItem
            // 
            this.addNewOrderToolStripMenuItem.Name = "addNewOrderToolStripMenuItem";
            this.addNewOrderToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewOrderToolStripMenuItem.Text = "Add New Order";
            this.addNewOrderToolStripMenuItem.Click += new System.EventHandler(this.addNewOrderToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(235, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(16, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Orders Count";
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersCount.ForeColor = System.Drawing.Color.Navy;
            this.lblOrdersCount.Location = new System.Drawing.Point(197, 393);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(45, 25);
            this.lblOrdersCount.TabIndex = 9;
            this.lblOrdersCount.Text = "???";
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Location = new System.Drawing.Point(643, 54);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(75, 60);
            this.btnAddNewOrder.TabIndex = 8;
            this.btnAddNewOrder.Text = "Add";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // frmListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrdersCount);
            this.Controls.Add(this.btnAddNewOrder);
            this.Name = "frmListOrders";
            this.Text = "frmListOrders";
            this.Load += new System.EventHandler(this.frmListOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showOrderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrdersCount;
        private System.Windows.Forms.Button btnAddNewOrder;
    }
}