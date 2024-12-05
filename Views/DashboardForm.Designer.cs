namespace bakery_management_system.Views
{
    partial class DashboardForm
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
            fplContainer = new components.PanelComponent1();
            flpProducts = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            pbProfile = new components.PictureBoxComponent1();
            panel4 = new Panel();
            lblWelcome = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            btnMyOrders = new components.ButtonSidebar1();
            btnProducts = new components.ButtonSidebar();
            btnMyPayments = new components.ButtonSidebar1();
            btnCategories = new components.ButtonSidebar1();
            pbLogo = new PictureBox();
            panel3 = new Panel();
            logoutButton1 = new components.LogoutButton();
            btnCustomers = new components.ButtonSidebar1();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            fplContainer.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1924, 1055);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(fplContainer, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(223, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1698, 1049);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // fplContainer
            // 
            fplContainer.BackColor = Color.White;
            fplContainer.Controls.Add(flpProducts);
            fplContainer.Dock = DockStyle.Fill;
            fplContainer.Location = new Point(3, 105);
            fplContainer.Margin = new Padding(3, 20, 30, 20);
            fplContainer.Name = "fplContainer";
            fplContainer.Size = new Size(1665, 924);
            fplContainer.TabIndex = 0;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.Dock = DockStyle.Fill;
            flpProducts.Location = new Point(0, 0);
            flpProducts.Margin = new Padding(50, 100, 50, 20);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(1665, 924);
            flpProducts.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(panel2, 1, 0);
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1692, 79);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbProfile);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1545, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 73);
            panel2.TabIndex = 0;
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
            // panel4
            // 
            panel4.Controls.Add(lblWelcome);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(txtSearch);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1536, 73);
            panel4.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.ForeColor = Color.FromArgb(255, 101, 0);
            lblWelcome.Location = new Point(24, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(78, 32);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "label1";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(665, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 42);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(318, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 39);
            txtSearch.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(panel3, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.Size = new Size(214, 1049);
            tableLayoutPanel3.TabIndex = 2;
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
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 949);
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
            btnMyOrders.Location = new Point(9, 248);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Padding = new Padding(15, 5, 30, 5);
            btnMyOrders.Size = new Size(188, 50);
            btnMyOrders.TabIndex = 6;
            btnMyOrders.Text = "Carts";
            btnMyOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyOrders.TextColor = Color.Black;
            btnMyOrders.UseVisualStyleBackColor = false;
            btnMyOrders.Click += CartBtn_Click;
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
            btnProducts.Location = new Point(9, 136);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 5, 30, 5);
            btnProducts.Size = new Size(189, 50);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Products";
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
            btnMyPayments.Location = new Point(10, 304);
            btnMyPayments.Name = "btnMyPayments";
            btnMyPayments.Padding = new Padding(15, 5, 30, 5);
            btnMyPayments.Size = new Size(188, 50);
            btnMyPayments.TabIndex = 7;
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
            btnCategories.Location = new Point(10, 192);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(15, 5, 30, 5);
            btnCategories.Size = new Size(188, 50);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextColor = Color.Black;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bms;
            pbLogo.Location = new Point(19, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(logoutButton1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 952);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 94);
            panel3.TabIndex = 1;
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
            logoutButton1.Location = new Point(39, 0);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Padding = new Padding(15, 8, 15, 8);
            logoutButton1.Size = new Size(129, 51);
            logoutButton1.TabIndex = 1;
            logoutButton1.Text = "Logout";
            logoutButton1.TextColor = Color.White;
            logoutButton1.UseVisualStyleBackColor = false;
            logoutButton1.Click += logoutButton1_Click;
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
            btnCustomers.Location = new Point(9, 360);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 5, 30, 5);
            btnCustomers.Size = new Size(188, 50);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextColor = Color.Black;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            fplContainer.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbLogo;
        private TableLayoutPanel tableLayoutPanel2;
        private components.ButtonSidebar btnProducts;
        private components.ButtonSidebar1 btnMyOrders;
        private components.ButtonSidebar1 btnCategories;
        private components.ButtonSidebar1 btnMyPayments;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Panel panel3;
        private components.LogoutButton logoutButton1;
        private components.PanelComponent1 fplContainer;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private components.PictureBoxComponent1 pbProfile;
        public FlowLayoutPanel flpProducts;
        private Panel panel4;
        private Label lblWelcome;
        private Button btnSearch;
        private TextBox txtSearch;
        private components.ButtonSidebar1 btnCustomers;
    }
}