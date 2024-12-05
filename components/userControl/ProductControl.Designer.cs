namespace bakery_management_system.components.userControl
{
    partial class ProductControl
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
            lblProductName = new Label();
            lblProductPrice = new Label();
            ptImage = new PictureBox();
            btnAddToCart = new ButtonComponent1();
            ((System.ComponentModel.ISupportInitialize)ptImage).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProductName.ForeColor = Color.FromArgb(255, 101, 0);
            lblProductName.Location = new Point(52, 21);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(86, 37);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "label1";
            // 
            // lblProductPrice
            // 
            lblProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = Color.FromArgb(126, 96, 191);
            lblProductPrice.Location = new Point(102, 241);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(73, 31);
            lblProductPrice.TabIndex = 1;
            lblProductPrice.Text = "label1";
            // 
            // ptImage
            // 
            ptImage.Image = Properties.Resources.bakery1;
            ptImage.Location = new Point(38, 81);
            ptImage.Name = "ptImage";
            ptImage.Size = new Size(220, 145);
            ptImage.SizeMode = PictureBoxSizeMode.Zoom;
            ptImage.TabIndex = 2;
            ptImage.TabStop = false;
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
            btnAddToCart.Location = new Point(52, 299);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Padding = new Padding(15, 8, 15, 8);
            btnAddToCart.Size = new Size(188, 50);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.TextColor = Color.White;
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnAddToCart);
            Controls.Add(ptImage);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            Margin = new Padding(20);
            Name = "ProductControl";
            Size = new Size(316, 373);
            ((System.ComponentModel.ISupportInitialize)ptImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblProductPrice;
        private PictureBox ptImage;
        private ButtonComponent1 btnAddToCart;
    }
}
