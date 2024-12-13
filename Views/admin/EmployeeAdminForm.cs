using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;

namespace bakery_management_system.Views.admin
{
    public partial class EmployeeAdminForm : Form
    {
        private readonly EmployeeController _employeeController;

        public EmployeeAdminForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _employeeController = new EmployeeController();

            // Load employees when the form is initialized
            LoadEmployees();
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

        private void LoadEmployees()
        {
            // Fetch all employees
            var employees = _employeeController.GetEmployees();

            // Clear existing controls
            flowLayoutPanelEmployees.Controls.Clear();

            // Add each employee as a CartEmployeeControl
            foreach (var employee in employees)
            {
                var employeeControl = new CartEmployeeControl();
                employeeControl.SetEmployee(employee);
                flowLayoutPanelEmployees.Controls.Add(employeeControl);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerAdminForm customerAdminForm = new CustomerAdminForm();
            customerAdminForm.Show();
            this.Hide();
        }

        private void btnCaetegory_Click(object sender, EventArgs e)
        {
            CategoryAdminForm categoryAdminForm = new CategoryAdminForm();
            categoryAdminForm.Show();
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

        private void cartEmployeeControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
