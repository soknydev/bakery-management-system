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
            label1.Location = new Point(269, 91);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Input customer phone:";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(492, 91);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(151, 27);
            txtCustomerPhone.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 157);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Payment method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(492, 157);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(151, 28);
            cmbPaymentMethod.TabIndex = 3;
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
            btnConfirm.Location = new Point(413, 276);
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
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label2);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label1);
            Name = "PaymentForm";
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