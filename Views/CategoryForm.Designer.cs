namespace bakery_management_system.Views
{
    partial class CategoryForm
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
            btnCategories = new components.ButtonSidebar();
            btnMyPayments = new components.ButtonSidebar1();
            btnProducts = new components.ButtonSidebar1();
            pbLogo = new PictureBox();
            panel2 = new Panel();
            logoutButton1 = new components.LogoutButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            panelComponent11 = new components.PanelComponent1();
            flowLayoutPanelCategories = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            pbProfile = new components.PictureBoxComponent1();
            panel3 = new Panel();
            lblWelcome = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnCustomers = new components.ButtonSidebar1();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelComponent11.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            panel3.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1395, 716);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(214, 710);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnMyOrders);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnMyPayments);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(pbLogo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 554);
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
            btnMyOrders.Location = new Point(9, 247);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Padding = new Padding(15, 5, 30, 5);
            btnMyOrders.Size = new Size(188, 50);
            btnMyOrders.TabIndex = 11;
            btnMyOrders.Text = "Carts";
            btnMyOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyOrders.TextColor = Color.Black;
            btnMyOrders.UseVisualStyleBackColor = false;
            btnMyOrders.Click += btnMyOrders_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(255, 101, 0);
            btnCategories.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnCategories.BorderColor = Color.PaleVioletRed;
            btnCategories.BorderRadius = 10;
            btnCategories.BorderSize = 0;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 12F);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(10, 191);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(15, 5, 30, 5);
            btnCategories.Size = new Size(189, 50);
            btnCategories.TabIndex = 9;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextColor = Color.White;
            btnCategories.UseVisualStyleBackColor = false;
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
            btnMyPayments.Location = new Point(10, 303);
            btnMyPayments.Name = "btnMyPayments";
            btnMyPayments.Padding = new Padding(15, 5, 30, 5);
            btnMyPayments.Size = new Size(188, 50);
            btnMyPayments.TabIndex = 12;
            btnMyPayments.Text = "Payments";
            btnMyPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnMyPayments.TextColor = Color.Black;
            btnMyPayments.UseVisualStyleBackColor = false;
            btnMyPayments.Click += btnMyPayments_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.Control;
            btnProducts.BackgroundColor = SystemColors.Control;
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 10;
            btnProducts.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 12F);
            btnProducts.ForeColor = Color.Black;
            btnProducts.Location = new Point(10, 135);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 5, 30, 5);
            btnProducts.Size = new Size(188, 50);
            btnProducts.TabIndex = 10;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextColor = Color.Black;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bms;
            pbLogo.Location = new Point(19, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(logoutButton1);
            panel2.Location = new Point(3, 563);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 144);
            panel2.TabIndex = 1;
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
            logoutButton1.Location = new Point(44, 0);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Padding = new Padding(15, 8, 15, 8);
            logoutButton1.Size = new Size(129, 51);
            logoutButton1.TabIndex = 2;
            logoutButton1.Text = "Logout";
            logoutButton1.TextColor = Color.White;
            logoutButton1.UseVisualStyleBackColor = false;
            logoutButton1.Click += logoutButton1_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panelComponent11, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(223, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1169, 710);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panelComponent11
            // 
            panelComponent11.BackColor = Color.White;
            panelComponent11.Controls.Add(flowLayoutPanelCategories);
            panelComponent11.Dock = DockStyle.Fill;
            panelComponent11.Location = new Point(3, 88);
            panelComponent11.Name = "panelComponent11";
            panelComponent11.Size = new Size(1163, 619);
            panelComponent11.TabIndex = 0;
            // 
            // flowLayoutPanelCategories
            // 
            flowLayoutPanelCategories.AutoScroll = true;
            flowLayoutPanelCategories.Dock = DockStyle.Fill;
            flowLayoutPanelCategories.Location = new Point(0, 0);
            flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            flowLayoutPanelCategories.Size = new Size(1163, 619);
            flowLayoutPanelCategories.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(panel4, 1, 0);
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1163, 79);
            tableLayoutPanel4.TabIndex = 1;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbProfile);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1016, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 73);
            panel4.TabIndex = 1;
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
            // panel3
            // 
            panel3.Controls.Add(lblWelcome);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1007, 73);
            panel3.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.ForeColor = Color.FromArgb(255, 101, 0);
            lblWelcome.Location = new Point(24, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(78, 32);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "label1";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(665, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 42);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(318, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 39);
            txtSearch.TabIndex = 4;
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
            btnCustomers.Location = new Point(11, 359);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 5, 30, 5);
            btnCustomers.Size = new Size(188, 50);
            btnCustomers.TabIndex = 13;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextColor = Color.Black;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 716);
            Controls.Add(tableLayoutPanel1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panelComponent11.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private components.PanelComponent1 panelComponent11;
        private FlowLayoutPanel flowLayoutPanelCategories;
        private Panel panel1;
        private components.ButtonSidebar1 btnMyOrders;
        private components.ButtonSidebar btnCategories;
        private components.ButtonSidebar1 btnMyPayments;
        private components.ButtonSidebar1 btnProducts;
        private PictureBox pbLogo;
        private Panel panel2;
        private components.LogoutButton logoutButton1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Label lblWelcome;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel4;
        private components.PictureBoxComponent1 pbProfile;
        private components.ButtonSidebar1 btnCustomers;
    }
}