namespace bakery_management_system.components.userControl
{
    partial class InvoiceControl
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
            pbLogo = new PictureBox();
            label1 = new Label();
            lblInvoiceId = new Label();
            lblDate = new Label();
            lblCustomer = new Label();
            lblPhone = new Label();
            lblEmployeeName = new Label();
            lblProductName = new Label();
            label = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bms;
            pbLogo.Location = new Point(32, 16);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(50, 49);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 101, 0);
            label1.Location = new Point(151, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 31);
            label1.TabIndex = 2;
            label1.Text = "INVOICE";
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceId.ForeColor = Color.FromArgb(126, 96, 191);
            lblInvoiceId.Location = new Point(249, 77);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(89, 23);
            lblInvoiceId.TabIndex = 3;
            lblInvoiceId.Text = "Invoice Id:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(126, 96, 191);
            lblDate.Location = new Point(249, 120);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 23);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 12F);
            lblCustomer.Location = new Point(32, 163);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(157, 28);
            lblCustomer.TabIndex = 5;
            lblCustomer.Text = "Customer Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F);
            lblPhone.Location = new Point(32, 217);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 12F);
            lblEmployeeName.Location = new Point(32, 274);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(159, 28);
            lblEmployeeName.TabIndex = 7;
            lblEmployeeName.Text = "Employee Name:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 12F);
            lblProductName.Location = new Point(32, 395);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(89, 28);
            lblProductName.TabIndex = 8;
            lblProductName.Text = "Products";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.Location = new Point(32, 335);
            label.Name = "label";
            label.Size = new Size(93, 28);
            label.TabIndex = 9;
            label.Text = "Products:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(255, 101, 0);
            lblTotal.Location = new Point(128, 509);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 28);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total";
            // 
            // InvoiceControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(lblTotal);
            Controls.Add(label);
            Controls.Add(lblProductName);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblPhone);
            Controls.Add(lblCustomer);
            Controls.Add(lblDate);
            Controls.Add(lblInvoiceId);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Margin = new Padding(20);
            Name = "InvoiceControl";
            Size = new Size(441, 614);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private Label lblInvoiceId;
        private Label lblDate;
        private Label lblCustomer;
        private Label lblPhone;
        private Label lblEmployeeName;
        private Label lblProductName;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblTotal;
        private Label label;
    }
}
