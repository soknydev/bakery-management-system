namespace bakery_management_system.Views
{
    partial class LoginForm
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnRegister = new components.ButtonComponent2();
            btnLogin = new components.ButtonComponent1();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 800F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1475, 753);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(40, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1394, 794);
            panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(126, 96, 191);
            btnRegister.BackgroundColor = Color.FromArgb(126, 96, 191);
            btnRegister.BorderColor = Color.PaleVioletRed;
            btnRegister.BorderRadius = 10;
            btnRegister.BorderSize = 0;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(814, 472);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(15, 8, 15, 8);
            btnRegister.Size = new Size(132, 50);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Sign up";
            btnRegister.TextColor = Color.White;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 101, 0);
            btnLogin.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 10;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(1003, 472);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(15, 8, 15, 8);
            btnLogin.Size = new Size(118, 50);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Log in";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(936, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 34);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "1234";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(693, 347);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(936, 256);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(185, 34);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Sokny";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(693, 256);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 101, 0);
            label1.Location = new Point(869, 144);
            label1.Name = "label1";
            label1.Size = new Size(116, 50);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tablet_login;
            pictureBox1.Location = new Point(65, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 432);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 753);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1200, 800);
            Name = "LoginForm";
            Text = "LoginForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private components.ButtonComponent2 btnRegister;
        private components.ButtonComponent1 btnLogin;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}