namespace bakery_management_system.Views.customer
{
    partial class AddCustomerForm
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
            label1 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            btnAddCustomer = new components.ButtonComponent1();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 84);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(446, 81);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(276, 34);
            txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerPhone.Location = new Point(446, 170);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(276, 34);
            txtCustomerPhone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(194, 173);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(446, 275);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 34);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 278);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(446, 384);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(276, 34);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(194, 387);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 6;
            label4.Text = "Address:";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(255, 101, 0);
            btnAddCustomer.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnAddCustomer.BorderColor = Color.PaleVioletRed;
            btnAddCustomer.BorderRadius = 10;
            btnAddCustomer.BorderSize = 0;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Segoe UI Semibold", 12F);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(534, 492);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Padding = new Padding(15, 8, 15, 8);
            btnAddCustomer.Size = new Size(188, 50);
            btnAddCustomer.TabIndex = 8;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextColor = Color.White;
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 592);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private components.ButtonComponent1 btnAddCustomer;
    }
}