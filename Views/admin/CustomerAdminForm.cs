using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;
using bakery_management_system.Views.customer;

namespace bakery_management_system.Views.admin
{
    public partial class CustomerAdminForm : Form
    {
        private readonly CustomerController _customerController;

        public CustomerAdminForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _customerController = new CustomerController();

            LoadCustomers();
            UserInfo();
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

        private void LoadCustomers()
        {
            // Fetch all customers
            var customers = _customerController.GetAllCustomers();

            // Clear existing controls in the FlowLayoutPanel
            flowLayoutPanelCustomers.Controls.Clear();

            // Add customers to the FlowLayoutPanel
            foreach (var customer in customers)
            {
                var customerControl = new CartCustomerControl();
                customerControl.SetCustomer(customer);
                flowLayoutPanelCustomers.Controls.Add(customerControl);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Show AddCustomerForm and refresh the customer list after closing
            using (var addCustomerForm = new AddCustomerForm())
            {
                var dialogResult = addCustomerForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    // Reload customers when a new customer is added
                    LoadCustomers();
                }
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DashboardAdminForm dashboardAdminForm = new DashboardAdminForm();
            dashboardAdminForm.Show();
            this.Hide();
        }

        private void btnMyPayments_Click(object sender, EventArgs e)
        {
            PaymentAdminForm paymentAdminForm = new PaymentAdminForm();
            paymentAdminForm.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryAdminForm categoryAdminForm = new CategoryAdminForm();
            categoryAdminForm.Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeAdminForm employeeAdminForm = new EmployeeAdminForm();
            employeeAdminForm.Show();
            this.Hide();
        }

        private void btnMyOrders_Click_1(object sender, EventArgs e)
        {
            CartAdminForm cartAdminForm = new CartAdminForm(UserSession.CurrentUser.EmployeeId);
            cartAdminForm.Show();
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
    }
}
