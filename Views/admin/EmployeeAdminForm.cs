using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;

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
    }
}
