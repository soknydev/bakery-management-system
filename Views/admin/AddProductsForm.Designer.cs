namespace bakery_management_system.Views.admin
{
    partial class AddProductsForm
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
            btnSave = new components.ButtonComponent1();
            picProductImage = new PictureBox();
            btnUpload = new Button();
            label9 = new Label();
            label8 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbCategories = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            SuspendLayout();
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
            btnSave.Location = new Point(735, 515);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(15, 8, 15, 8);
            btnSave.Size = new Size(134, 50);
            btnSave.TabIndex = 46;
            btnSave.Text = "Add";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSaveProduct_Click;
            // 
            // picProductImage
            // 
            picProductImage.Image = Properties.Resources.bms;
            picProductImage.Location = new Point(817, 234);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(178, 180);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 42;
            picProductImage.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(817, 154);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(178, 46);
            btnUpload.TabIndex = 41;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUploadImage_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(134, 515);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 40;
            label9.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(678, 158);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 39;
            label8.Text = "Image";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(327, 418);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(223, 34);
            txtStock.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 418);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 35;
            label5.Text = "Stock";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(327, 329);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(223, 34);
            txtPrice.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 329);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 33;
            label4.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(327, 244);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(223, 34);
            txtDescription.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 244);
            label3.Name = "label3";
            label3.Size = new Size(44, 28);
            label3.TabIndex = 31;
            label3.Text = "Des";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(327, 152);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(223, 34);
            txtProductName.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 152);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 29;
            label2.Text = "Produc Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 101, 0);
            label1.Location = new Point(158, 32);
            label1.Name = "label1";
            label1.Size = new Size(392, 50);
            label1.TabIndex = 28;
            label1.Text = "Create New Employee";
            // 
            // cmbCategories
            // 
            cmbCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(327, 515);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(223, 36);
            cmbCategories.TabIndex = 47;
            // 
            // AddProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 775);
            Controls.Add(cmbCategories);
            Controls.Add(btnSave);
            Controls.Add(picProductImage);
            Controls.Add(btnUpload);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductsForm";
            Text = "AddProductsForm";
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components.ButtonComponent1 btnSave;
        private PictureBox picProductImage;
        private Button btnUpload;
        private Label label9;
        private Label label8;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategories;
    }
}