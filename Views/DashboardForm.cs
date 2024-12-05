using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Models;
using bakery_management_system.Utils;

namespace bakery_management_system.Views
{
    public partial class DashboardForm : Form
    {
        private readonly ProductController _productController;

        public DashboardForm()
        {
            InitializeComponent();
            _productController = new ProductController();

            LoadProducts();

            // Make the form full screen
            this.WindowState = FormWindowState.Maximized;

            // section user
            UserInfo();
        }


        private void LoadProducts(List<Product>? products = null)
        {
            try
            {
                // If no products are provided, load all available products
                products ??= _productController.GetAvailableProducts();

                // Clear existing controls
                flpProducts.Controls.Clear();

                foreach (var product in products)
                {
                    // Create and configure ProductControl
                    var productControl = new ProductControl();
                    productControl.SetProduct(product);

                    // Add ProductControl to the FlowLayoutPanel
                    flpProducts.Controls.Add(productControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                var filteredProducts = _productController.SearchProducts(keyword);

                // Load filtered products
                LoadProducts(filteredProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}");
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


        private void CartBtn_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm(UserSession.CurrentUser.EmployeeId);
            cart.Show();
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

        private void btnMyPayments_Click(object sender, EventArgs e)
        {
            MyPaymentForm myPaymentForm = new MyPaymentForm();
            myPaymentForm.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

    }
}
