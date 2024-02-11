namespace OnlineStoreWinform.ProductImages
{
    partial class frmAddEditProductImages
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
            this.tbProductImages = new System.Windows.Forms.TabControl();
            this.tpProductInfo = new System.Windows.Forms.TabPage();
            this.ctrlProductDetailsWithFilter1 = new OnlineStoreWinform.ProductCatalog.Controls.ctrlProductDetailsWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpProductImages = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbImageURL = new System.Windows.Forms.PictureBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbProductImages.SuspendLayout();
            this.tpProductInfo.SuspendLayout();
            this.tpProductImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageURL)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductImages
            // 
            this.tbProductImages.Controls.Add(this.tpProductInfo);
            this.tbProductImages.Controls.Add(this.tpProductImages);
            this.tbProductImages.Location = new System.Drawing.Point(12, 43);
            this.tbProductImages.Name = "tbProductImages";
            this.tbProductImages.SelectedIndex = 0;
            this.tbProductImages.Size = new System.Drawing.Size(739, 456);
            this.tbProductImages.TabIndex = 6;
            // 
            // tpProductInfo
            // 
            this.tpProductInfo.Controls.Add(this.ctrlProductDetailsWithFilter1);
            this.tpProductInfo.Controls.Add(this.btnNext);
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
            this.ctrlProductDetailsWithFilter1.Location = new System.Drawing.Point(17, 15);
            this.ctrlProductDetailsWithFilter1.Name = "ctrlProductDetailsWithFilter1";
            this.ctrlProductDetailsWithFilter1.Size = new System.Drawing.Size(589, 442);
            this.ctrlProductDetailsWithFilter1.TabIndex = 22;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(612, 305);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 77);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpProductImages
            // 
            this.tpProductImages.Controls.Add(this.llRemoveImage);
            this.tpProductImages.Controls.Add(this.llSetImage);
            this.tpProductImages.Controls.Add(this.pbImageURL);
            this.tpProductImages.Controls.Add(this.numericUpDown1);
            this.tpProductImages.Controls.Add(this.lblID);
            this.tpProductImages.Controls.Add(this.label5);
            this.tpProductImages.Controls.Add(this.label2);
            this.tpProductImages.Location = new System.Drawing.Point(4, 25);
            this.tpProductImages.Name = "tpProductImages";
            this.tpProductImages.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductImages.Size = new System.Drawing.Size(731, 427);
            this.tpProductImages.TabIndex = 1;
            this.tpProductImages.Text = "ProductInfo";
            this.tpProductImages.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(250, 257);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Navy;
            this.lblID.Location = new System.Drawing.Point(259, 150);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 20);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(92, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ImageOrder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(92, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(613, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 77);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(389, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.lblTitle.Location = new System.Drawing.Point(229, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 25);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Add New Product Images";
            // 
            // pbImageURL
            // 
            this.pbImageURL.Image = global::OnlineStoreWinform.Properties.Resources.Male_512;
            this.pbImageURL.Location = new System.Drawing.Point(528, 51);
            this.pbImageURL.Name = "pbImageURL";
            this.pbImageURL.Size = new System.Drawing.Size(152, 142);
            this.pbImageURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageURL.TabIndex = 25;
            this.pbImageURL.TabStop = false;
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(534, 232);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(65, 16);
            this.llSetImage.TabIndex = 26;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "SetImage";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked_1);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Location = new System.Drawing.Point(621, 232);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(59, 16);
            this.llRemoveImage.TabIndex = 27;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditProductImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbProductImages);
            this.Name = "frmAddEditProductImages";
            this.Text = "frmAddEditProductImages";
            this.Load += new System.EventHandler(this.frmAddEditProductImages_Load);
            this.tbProductImages.ResumeLayout(false);
            this.tpProductInfo.ResumeLayout(false);
            this.tpProductImages.ResumeLayout(false);
            this.tpProductImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageURL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbProductImages;
        private System.Windows.Forms.TabPage tpProductInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpProductImages;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private ProductCatalog.Controls.ctrlProductDetailsWithFilter ctrlProductDetailsWithFilter1;
        private System.Windows.Forms.PictureBox pbImageURL;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}