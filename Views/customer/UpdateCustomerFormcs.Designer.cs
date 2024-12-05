namespace bakery_management_system.Views.customer
{
    partial class UpdateCustomerFormcs
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
            btnUpdateCustomer = new components.ButtonComponent1();
            txtAddress = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCustomerPhone = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(255, 101, 0);
            btnUpdateCustomer.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnUpdateCustomer.BorderColor = Color.PaleVioletRed;
            btnUpdateCustomer.BorderRadius = 10;
            btnUpdateCustomer.BorderSize = 0;
            btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            btnUpdateCustomer.FlatStyle = FlatStyle.Flat;
            btnUpdateCustomer.Font = new Font("Segoe UI Semibold", 12F);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(574, 481);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Padding = new Padding(15, 8, 15, 8);
            btnUpdateCustomer.Size = new Size(186, 53);
            btnUpdateCustomer.TabIndex = 26;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.TextColor = Color.White;
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(486, 373);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(274, 34);
            txtAddress.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(232, 376);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 24;
            label4.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(486, 264);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 34);
            txtEmail.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 267);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 22;
            label3.Text = "Email:";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerPhone.Location = new Point(486, 159);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(274, 34);
            txtCustomerPhone.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(232, 162);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 20;
            label2.Text = "Phone Number";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(486, 70);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(274, 34);
            txtCustomerName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 73);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 18;
            label1.Text = "Customer Name";
            // 
            // UpdateCustomerFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 617);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "UpdateCustomerFormcs";
            Text = "UpdateCustomerFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components.ButtonComponent1 btnUpdateCustomer;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCustomerPhone;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label1;
    }
}