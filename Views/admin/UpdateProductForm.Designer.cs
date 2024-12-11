namespace bakery_management_system.Views.admin
{
    partial class UpdateProductForm
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
            btnClose = new components.ButtonComponent2();
            cmbCategory = new ComboBox();
            btnSave = new components.ButtonComponent1();
            picProductImage = new PictureBox();
            btnUpload = new Button();
            label9 = new Label();
            label8 = new Label();
            txtStockLevel = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 96, 191);
            btnClose.BackgroundColor = Color.FromArgb(126, 96, 191);
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 8;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(839, 603);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(15, 8, 15, 8);
            btnClose.Size = new Size(127, 54);
            btnClose.TabIndex = 65;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(520, 545);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(223, 36);
            cmbCategory.TabIndex = 64;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 101, 0);
            btnSave.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 10;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1015, 603);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(15, 8, 15, 8);
            btnSave.Size = new Size(134, 50);
            btnSave.TabIndex = 63;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // picProductImage
            // 
            picProductImage.Image = Properties.Resources.bms;
            picProductImage.Location = new Point(981, 263);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(178, 180);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 62;
            picProductImage.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(981, 183);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(178, 46);
            btnUpload.TabIndex = 61;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUploadImage_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(327, 545);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 60;
            label9.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(871, 188);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 59;
            label8.Text = "Image";
            // 
            // txtStockLevel
            // 
            txtStockLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockLevel.Location = new Point(520, 448);
            txtStockLevel.Name = "txtStockLevel";
            txtStockLevel.Size = new Size(223, 34);
            txtStockLevel.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(327, 448);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 57;
            label5.Text = "Quantity";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(520, 359);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(223, 34);
            txtPrice.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(327, 359);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 55;
            label4.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(520, 274);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(223, 34);
            txtDescription.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 274);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 53;
            label3.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(520, 182);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(223, 34);
            txtProductName.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(327, 182);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 51;
            label2.Text = "Produc Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 101, 0);
            label1.Location = new Point(351, 62);
            label1.Name = "label1";
            label1.Size = new Size(286, 50);
            label1.TabIndex = 50;
            label1.Text = "Update Product";
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 719);
            Controls.Add(btnClose);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Controls.Add(picProductImage);
            Controls.Add(btnUpload);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtStockLevel);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components.ButtonComponent2 btnClose;
        private ComboBox cmbCategory;
        private components.ButtonComponent1 btnSave;
        private PictureBox picProductImage;
        private Button btnUpload;
        private Label label9;
        private Label label8;
        private TextBox txtStockLevel;
        private Label label5;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private Label label1;
    }
}