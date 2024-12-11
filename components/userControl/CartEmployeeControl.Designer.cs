namespace bakery_management_system.components.userControl
{
    partial class CartEmployeeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartEmployeeControl));
            lblName = new Label();
            lblRole = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            pbEmployee = new PictureBox();
            btnUpdate = new PictureBox();
            lblUsername = new Label();
            btnDelete = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(42, 17);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(478, 17);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 28);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(626, 17);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(863, 17);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone";
            // 
            // pbEmployee
            // 
            pbEmployee.Image = (Image)resources.GetObject("pbEmployee.Image");
            pbEmployee.Location = new Point(1132, 3);
            pbEmployee.Name = "pbEmployee";
            pbEmployee.Size = new Size(62, 58);
            pbEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmployee.TabIndex = 4;
            pbEmployee.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.edit;
            btnUpdate.Location = new Point(1285, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(49, 37);
            btnUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdate.TabIndex = 6;
            btnUpdate.TabStop = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(296, 17);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 28);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(1364, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(49, 37);
            btnDelete.SizeMode = PictureBoxSizeMode.Zoom;
            btnDelete.TabIndex = 8;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // CartEmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(lblUsername);
            Controls.Add(btnUpdate);
            Controls.Add(pbEmployee);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "CartEmployeeControl";
            Size = new Size(1765, 64);
            ((System.ComponentModel.ISupportInitialize)pbEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblRole;
        private Label lblEmail;
        private Label lblPhone;
        private PictureBox pbEmployee;
        private PictureBox btnUpdate;
        private Label lblUsername;
        private PictureBox btnDelete;
    }
}
