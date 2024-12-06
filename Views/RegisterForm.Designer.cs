namespace bakery_management_system.Views
{
    partial class RegisterForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnClose = new components.ButtonComponent2();
            btnRegister = new components.ButtonComponent1();
            txtSalary = new TextBox();
            txtGmail = new TextBox();
            dtpTimePicker = new DateTimePicker();
            pictureBox = new PictureBox();
            btnUpload = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtFullname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 800F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1528, 833);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtSalary);
            panel1.Controls.Add(txtGmail);
            panel1.Controls.Add(dtpTimePicker);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtFullname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(17, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1494, 794);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 96, 191);
            btnClose.BackgroundColor = Color.FromArgb(126, 96, 191);
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 8;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(763, 656);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(15, 8, 15, 8);
            btnClose.Size = new Size(127, 54);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 101, 0);
            btnRegister.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnRegister.BorderColor = Color.PaleVioletRed;
            btnRegister.BorderRadius = 10;
            btnRegister.BorderSize = 0;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(941, 658);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(15, 8, 15, 8);
            btnRegister.Size = new Size(134, 50);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Add";
            btnRegister.TextColor = Color.White;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(1233, 251);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(178, 34);
            txtSalary.TabIndex = 25;
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(1233, 159);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(178, 34);
            txtGmail.TabIndex = 24;
            // 
            // dtpTimePicker
            // 
            dtpTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimePicker.Location = new Point(782, 527);
            dtpTimePicker.Name = "dtpTimePicker";
            dtpTimePicker.Size = new Size(324, 34);
            dtpTimePicker.TabIndex = 23;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.bms;
            pictureBox.Location = new Point(1233, 419);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(178, 180);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 19;
            pictureBox.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(1233, 339);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(178, 46);
            btnUpload.TabIndex = 18;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(613, 525);
            label9.Name = "label9";
            label9.Size = new Size(98, 28);
            label9.TabIndex = 16;
            label9.Text = "Hire Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1064, 339);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 14;
            label8.Text = "Profile:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1064, 251);
            label7.Name = "label7";
            label7.Size = new Size(69, 28);
            label7.TabIndex = 12;
            label7.Text = "Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1064, 162);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 10;
            label6.Text = "Gmail:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(782, 428);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(178, 34);
            txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(613, 428);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 8;
            label5.Text = "Phone:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(782, 339);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 34);
            txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(613, 339);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(782, 254);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(178, 34);
            txtUsername.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(613, 254);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(782, 162);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(178, 34);
            txtFullname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(613, 162);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 2;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 101, 0);
            label1.Location = new Point(613, 42);
            label1.Name = "label1";
            label1.Size = new Size(392, 50);
            label1.TabIndex = 1;
            label1.Text = "Create New Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mobile_login;
            pictureBox1.Location = new Point(22, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 833);
            Controls.Add(tableLayoutPanel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtFullname;
        private TextBox textBox8;
        private Label label9;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtPassword;
        private Label label4;
        private PictureBox pictureBox;
        private Button btnUpload;
        private DateTimePicker dtpTimePicker;
        private TextBox txtSalary;
        private TextBox txtGmail;
        private components.ButtonComponent1 btnRegister;
        private components.ButtonComponent2 btnClose;
    }
}