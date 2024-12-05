using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;

namespace bakery_management_system.Views.admin
{
    public partial class PaymentAdminForm : Form
    {
        private readonly InvoiceController _invoiceController;
        public PaymentAdminForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _invoiceController = new InvoiceController();
            int employeeId = UserSession.CurrentUser.EmployeeId; // Example
            LoadInvoices(employeeId);

            UserInfo();
        }

        private void LoadInvoices(int employeeId)
        {
            flpInvoices.Controls.Clear();
            var invoices = _invoiceController.GetInvoicesByEmployeeId(employeeId);

            foreach (var invoice in invoices)
            {
                var invoiceControl = new InvoiceControl();
                invoiceControl.SetInvoice(invoice);
                flpInvoices.Controls.Add(invoiceControl);
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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DashboardAdminForm dashboardAdminForm = new DashboardAdminForm();
            dashboardAdminForm.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryAdminForm categoryAdminForm = new CategoryAdminForm();
            categoryAdminForm.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerAdminForm customerAdminForm = new CustomerAdminForm();
            customerAdminForm.Show();
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
