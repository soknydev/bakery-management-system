namespace bakery_management_system.Views
{
    partial class CartForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btnMyOrders = new components.ButtonSidebar1();
            btnProducts = new components.ButtonSidebar();
            btnMyPayments = new components.ButtonSidebar1();
            btnCategories = new components.ButtonSidebar1();
            pbLogo = new PictureBox();
            panel5 = new Panel();
            logoutButton1 = new components.LogoutButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            pbProfile = new components.PictureBoxComponent1();
            panel2 = new Panel();
            lblWelcome = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new Panel();
            flpCarts = new FlowLayoutPanel();
            panel6 = new Panel();
            btnBuyAll = new components.ButtonComponent1();
            label1 = new Label();
            btnCustomers = new components.ButtonSidebar1();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1345, 792);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(214, 786);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnMyOrders);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnMyPayments);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(pbLogo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 630);
            panel1.TabIndex = 0;
            // 
            // btnMyOrders
            // 
            btnMyOrders.BackColor = SystemColors.Control;
            btnMyOrders.BackgroundColor = SystemColors.Control;
            btnMyOrders.BorderColor = Color.PaleVioletRed;
            btnMyOrders.BorderRadius = 10;
            btnMyOrders.BorderSize = 0;
            btnMyOrders.FlatAppearance.BorderSize = 0;
            btnMyOrders.FlatStyle = FlatStyle.Flat;
            btnMyOrders.Font = new Font("Segoe UI Semibold", 12F);
            btnMyOrders.ForeColor = Color.Black;
            btnMyOrders.Location = new Point(8, 138);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Padding = new Padding(15, 5, 30, 5);
            btnMyOrders.Size = new Size(188, 50);
            btnMyOrders.TabIndex = 14;
            btnMyOrders.Text = "Products";
            btnMyOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyOrders.TextColor = Color.Black;
            btnMyOrders.UseVisualStyleBackColor = false;
            btnMyOrders.Click += ProductsBtn_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(255, 101, 0);
            btnProducts.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 10;
            btnProducts.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 12F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(7, 250);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 5, 30, 5);
            btnProducts.Size = new Size(189, 50);
            btnProducts.TabIndex = 12;
            btnProducts.Text = "Carts";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextColor = Color.White;
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnMyPayments
            // 
            btnMyPayments.BackColor = SystemColors.Control;
            btnMyPayments.BackgroundColor = SystemColors.Control;
            btnMyPayments.BorderColor = Color.PaleVioletRed;
            btnMyPayments.BorderRadius = 10;
            btnMyPayments.BorderSize = 0;
            btnMyPayments.FlatAppearance.BorderSize = 0;
            btnMyPayments.FlatStyle = FlatStyle.Flat;
            btnMyPayments.Font = new Font("Segoe UI Semibold", 12F);
            btnMyPayments.ForeColor = Color.Black;
            btnMyPayments.Location = new Point(7, 306);
            btnMyPayments.Name = "btnMyPayments";
            btnMyPayments.Padding = new Padding(15, 5, 30, 5);
            btnMyPayments.Size = new Size(188, 50);
            btnMyPayments.TabIndex = 15;
            btnMyPayments.Text = "Payments";
            btnMyPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnMyPayments.TextColor = Color.Black;
            btnMyPayments.UseVisualStyleBackColor = false;
            btnMyPayments.Click += btnMyPayments_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.Control;
            btnCategories.BackgroundColor = SystemColors.Control;
            btnCategories.BorderColor = Color.PaleVioletRed;
            btnCategories.BorderRadius = 10;
            btnCategories.BorderSize = 0;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 12F);
            btnCategories.ForeColor = Color.Black;
            btnCategories.Location = new Point(7, 194);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(15, 5, 30, 5);
            btnCategories.Size = new Size(188, 50);
            btnCategories.TabIndex = 13;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextColor = Color.Black;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bms;
            pbLogo.Location = new Point(16, 6);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 11;
            pbLogo.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(logoutButton1);
            panel5.Location = new Point(3, 639);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 125);
            panel5.TabIndex = 1;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BackgroundColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BorderColor = Color.PaleVioletRed;
            logoutButton1.BorderRadius = 10;
            logoutButton1.BorderSize = 0;
            logoutButton1.FlatAppearance.BorderSize = 0;
            logoutButton1.FlatStyle = FlatStyle.Flat;
            logoutButton1.Font = new Font("Segoe UI Semibold", 12F);
            logoutButton1.ForeColor = Color.White;
            logoutButton1.Location = new Point(43, 3);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Padding = new Padding(15, 8, 15, 8);
            logoutButton1.Size = new Size(129, 51);
            logoutButton1.TabIndex = 2;
            logoutButton1.Text = "Logout";
            logoutButton1.TextColor = Color.White;
            logoutButton1.UseVisualStyleBackColor = false;
            logoutButton1.Click += LogoutBtn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(223, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1119, 786);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(panel3, 1, 0);
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1113, 79);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbProfile);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(966, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 73);
            panel3.TabIndex = 1;
            // 
            // pbProfile
            // 
            pbProfile.BackColor = Color.Transparent;
            pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            pbProfile.Location = new Point(40, 5);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(65, 65);
            pbProfile.TabIndex = 0;
            pbProfile.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 73);
            panel2.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.ForeColor = Color.FromArgb(255, 101, 0);
            lblWelcome.Location = new Point(22, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(78, 32);
            lblWelcome.TabIndex = 9;
            lblWelcome.Text = "label1";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(663, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 42);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(316, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 39);
            txtSearch.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(panel4, 0, 1);
            tableLayoutPanel5.Controls.Add(panel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 88);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1113, 695);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(flpCarts);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(1107, 609);
            panel4.TabIndex = 0;
            // 
            // flpCarts
            // 
            flpCarts.BackColor = Color.White;
            flpCarts.Dock = DockStyle.Fill;
            flpCarts.Location = new Point(0, 0);
            flpCarts.Name = "flpCarts";
            flpCarts.Size = new Size(1107, 609);
            flpCarts.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnBuyAll);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1107, 74);
            panel6.TabIndex = 1;
            // 
            // btnBuyAll
            // 
            btnBuyAll.BackColor = Color.FromArgb(255, 101, 0);
            btnBuyAll.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnBuyAll.BorderColor = Color.PaleVioletRed;
            btnBuyAll.BorderRadius = 10;
            btnBuyAll.BorderSize = 0;
            btnBuyAll.FlatAppearance.BorderSize = 0;
            btnBuyAll.FlatStyle = FlatStyle.Flat;
            btnBuyAll.Font = new Font("Segoe UI Semibold", 12F);
            btnBuyAll.ForeColor = Color.White;
            btnBuyAll.Location = new Point(440, 12);
            btnBuyAll.Name = "btnBuyAll";
            btnBuyAll.Padding = new Padding(15, 8, 15, 8);
            btnBuyAll.Size = new Size(188, 50);
            btnBuyAll.TabIndex = 1;
            btnBuyAll.Text = "Buy All";
            btnBuyAll.TextColor = Color.White;
            btnBuyAll.UseVisualStyleBackColor = false;
            btnBuyAll.Click += btnBuyAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(344, 28);
            label1.TabIndex = 0;
            label1.Text = "Here is your procuts, you can buy now";
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.Control;
            btnCustomers.BackgroundColor = SystemColors.Control;
            btnCustomers.BorderColor = Color.PaleVioletRed;
            btnCustomers.BorderRadius = 10;
            btnCustomers.BorderSize = 0;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI Semibold", 12F);
            btnCustomers.ForeColor = Color.Black;
            btnCustomers.Location = new Point(8, 362);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 5, 30, 5);
            btnCustomers.Size = new Size(188, 50);
            btnCustomers.TabIndex = 16;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextColor = Color.Black;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 792);
            Controls.Add(tableLayoutPanel1);
            Name = "CartForm";
            Text = "CartForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private components.ButtonSidebar1 btnMyOrders;
        private components.ButtonSidebar btnProducts;
        private components.ButtonSidebar1 btnMyPayments;
        private components.ButtonSidebar1 btnCategories;
        private PictureBox pbLogo;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private components.PictureBoxComponent1 pbProfile;
        private Panel panel2;
        private Panel panel5;
        private components.LogoutButton logoutButton1;
        private Label lblWelcome;
        private Button btnSearch;
        private TextBox txtSearch;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel4;
        private FlowLayoutPanel flpCarts;
        private Panel panel6;
        private components.ButtonComponent1 btnBuyAll;
        private Label label1;
        private components.ButtonSidebar1 btnCustomers;
    }
}