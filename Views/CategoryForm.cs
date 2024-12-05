using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;

namespace bakery_management_system.Views
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryController _categoryController;
        private readonly ProductController _productController;
        private readonly ProductControl _productControl;

        public CategoryForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _categoryController = new CategoryController();
            _productController = new ProductController();
            _productControl = new ProductControl();
            LoadCategory();

            // user info.
            UserInfo();
        }

        private void LoadCategory()
        {
            // Fetch categories from the database
            var categories = _categoryController.GetCategories();

            // Dynamically add rows for each category
            foreach (var category in categories)
            {
                var categoryControl = new CategoryControl();
                categoryControl.LoadCategory(category.CategoryId, category.CategoryName);
                flowLayoutPanelCategories.Controls.Add(categoryControl);
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm(UserSession.CurrentUser.EmployeeId);
            cart.Show();
            this.Hide();
        }

        private void btnMyPayments_Click(object sender, EventArgs e)
        {
            MyPaymentForm myPaymentForm = new MyPaymentForm();
            myPaymentForm.Show();
            this.Hide();
        }

        private void logoutButton1_Click(object sender, EventArgs e)
        {
            // Confirm logout action
            var confirmLogout = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmLogout == DialogResult.Yes)
            {
                // Clear user session or any logged-in state
                UserSession.CurrentUser = null;

                // Navigate to the LoginForm
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Close the current form
                this.Close();
            }
        }

        private void UserInfo()
        {
            // Section: User Information Display
            if (UserSession.CurrentUser != null)
            {
                lblWelcome.Text = $"Hello, {UserSession.CurrentUser.Name}";
                if (!string.IsNullOrEmpty(UserSession.CurrentUser.ImagePath) && File.Exists(UserSession.CurrentUser.ImagePath))
                {
                    pbProfile.Image = Image.FromFile(UserSession.CurrentUser.ImagePath);
                }
                else
                {
                    // defual avatar
                    pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
                }
            }
            else
            {
                lblWelcome.Text = "Welcome, Guest!";
                pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            }

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                // Search products
                var filteredProducts = _productController.SearchProducts(keyword);

                // Search categories
                var filteredCategories = _categoryController.SearchCategories(keyword);

                // Clear existing controls
                //flowLayoutPanelProducts.Controls.Clear();
                flowLayoutPanelCategories.Controls.Clear();

                // Load filtered products
                foreach (var product in filteredProducts)
                {
                    var productControl = new ProductControl();
                    productControl.SetProduct(product);
                    //flowLayoutPanelProducts.Controls.Add(productControl);
                }

                // Load filtered categories
                foreach (var category in filteredCategories)
                {
                    var categoryControl = new CategoryControl();
                    categoryControl.LoadCategory(category.CategoryId, category.CategoryName);
                    flowLayoutPanelCategories.Controls.Add(categoryControl);
                }

                if (!filteredProducts.Any() && !filteredCategories.Any())
                {
                    MessageBox.Show("No matching products or categories found.", "Search Results");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}");
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

    }
}
