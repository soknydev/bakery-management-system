namespace bakery_management_system.components.userControl.admin
{
    partial class ProductAdminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdminControl));
            btnDelete = new PictureBox();
            btnUpdate = new PictureBox();
            ptImage = new PictureBox();
            lblProductPrice = new Label();
            lblProductName = new Label();
            btnAddToCart = new ButtonComponent1();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptImage).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(234, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(49, 37);
            btnDelete.SizeMode = PictureBoxSizeMode.Zoom;
            btnDelete.TabIndex = 15;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(179, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(49, 37);
            btnUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdate.TabIndex = 14;
            btnUpdate.TabStop = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ptImage
            // 
            ptImage.Location = new Point(35, 139);
            ptImage.Name = "ptImage";
            ptImage.Size = new Size(220, 145);
            ptImage.SizeMode = PictureBoxSizeMode.Zoom;
            ptImage.TabIndex = 13;
            ptImage.TabStop = false;
            // 
            // lblProductPrice
            // 
            lblProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = Color.FromArgb(126, 96, 191);
            lblProductPrice.Location = new Point(92, 311);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(73, 31);
            lblProductPrice.TabIndex = 12;
            lblProductPrice.Text = "label1";
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProductName.ForeColor = Color.FromArgb(255, 101, 0);
            lblProductName.Location = new Point(35, 82);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(86, 37);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "label1";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(255, 101, 0);
            btnAddToCart.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnAddToCart.BorderColor = Color.PaleVioletRed;
            btnAddToCart.BorderRadius = 10;
            btnAddToCart.BorderSize = 0;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI Semibold", 12F);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(40, 365);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Padding = new Padding(15, 8, 15, 8);
            btnAddToCart.Size = new Size(188, 50);
            btnAddToCart.TabIndex = 16;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.TextColor = Color.White;
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // ProductAdminControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(btnAddToCart);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(ptImage);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            Margin = new Padding(10);
            Name = "ProductAdminControl";
            Size = new Size(297, 467);
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnDelete;
        private PictureBox btnUpdate;
        private PictureBox ptImage;
        private Label lblProductPrice;
        private Label lblProductName;
        private ButtonComponent1 btnAddToCart;
    }
}
