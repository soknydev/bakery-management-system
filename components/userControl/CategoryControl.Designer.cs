namespace bakery_management_system.components.userControl
{
    partial class CategoryControl
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
            lblCategoryName = new Label();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblCategoryName.Location = new Point(44, 21);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(225, 41);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "CategoryName";
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(44, 76);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(1568, 435);
            flowLayoutPanelProducts.TabIndex = 1;
            flowLayoutPanelProducts.WrapContents = false;
            // 
            // CategoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(lblCategoryName);
            Name = "CategoryControl";
            Size = new Size(1637, 540);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryName;
        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}
