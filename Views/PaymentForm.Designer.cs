namespace bakery_management_system.Views
{
    partial class PaymentForm
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
            txtCustomerPhone = new TextBox();
            label2 = new Label();
            cmbPaymentMethod = new ComboBox();
            btnConfirm = new components.ButtonComponent1();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(167, 99);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 0;
            label1.Text = "Input customer phone:";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Font = new Font("Segoe UI", 12F);
            txtCustomerPhone.Location = new Point(470, 99);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(220, 34);
            txtCustomerPhone.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(167, 200);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 2;
            label2.Text = "Payment method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Font = new Font("Segoe UI", 12F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(470, 200);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(220, 36);
            cmbPaymentMethod.TabIndex = 3;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(255, 101, 0);
            btnConfirm.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnConfirm.BorderColor = Color.PaleVioletRed;
            btnConfirm.BorderRadius = 10;
            btnConfirm.BorderSize = 0;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(502, 323);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Padding = new Padding(15, 8, 15, 8);
            btnConfirm.Size = new Size(188, 50);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 450);
            Controls.Add(btnConfirm);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label2);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label1);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerPhone;
        private Label label2;
        private ComboBox cmbPaymentMethod;
        private components.ButtonComponent1 btnConfirm;
    }
}