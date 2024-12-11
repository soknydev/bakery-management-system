using bakery_management_system.Controllers;
using bakery_management_system.Models;
using bakery_management_system.Views.admin;

namespace bakery_management_system.components.userControl
{
    public partial class CartEmployeeControl : UserControl
    {
        private Employee _employee;

        public CartEmployeeControl()
        {
            InitializeComponent();
        }

        // Sets employee data and stores the object
        public void SetEmployee(Employee employee)
        {
            _employee = employee;
            lblUsername.Text = employee.Username;
            lblName.Text = employee.Name;
            lblRole.Text = employee.Role ?? "N/A";
            lblEmail.Text = employee.Email ?? "N/A";
            lblPhone.Text = employee.Phone ?? "N/A";

            if (!string.IsNullOrEmpty(employee.ImagePath) && File.Exists(employee.ImagePath))
            {
                pbEmployee.Image = Image.FromFile(employee.ImagePath);
            }
            else
            {
                // Set default avatar if no image is found
                pbEmployee.Image = Properties.Resources.photo_2023_08_01_20_25_42; // Replace with actual default image resource
            }
        }

        // Handles the Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_employee != null)
            {
                // Open the UpdateEmployeeForm with the current employee
                var updateForm = new UpdateEmployeeForm(_employee);
                updateForm.ShowDialog();

                // Update the displayed employee data after the form closes
                RefreshEmployeeData();
            }
            else
            {
                MessageBox.Show("No employee data available to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refreshes the employee data to reflect updates
        private void RefreshEmployeeData()
        {
            if (_employee != null)
            {
                // Refresh employee details, assuming they are updated in the UpdateEmployeeForm
                lblName.Text = _employee.Name;
                lblUsername.Text = _employee.Username;
                lblRole.Text = _employee.Role ?? "N/A";
                lblEmail.Text = _employee.Email ?? "N/A";
                lblPhone.Text = _employee.Phone ?? "N/A";

                if (!string.IsNullOrEmpty(_employee.ImagePath) && File.Exists(_employee.ImagePath))
                {
                    pbEmployee.Image = Image.FromFile(_employee.ImagePath);
                }
                else
                {
                    // Set default avatar if no image is found
                    pbEmployee.Image = Properties.Resources.photo_2023_08_01_20_25_42; // Replace with actual default image resource
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_employee != null)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete {_employee.Name}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    //Use EmployeeController to handle deletion
                    var controller = new EmployeeController();
                    bool isDeleted = controller.DeleteEmployee(_employee.EmployeeId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, remove the control from its parent container
                        this.Parent?.Controls.Remove(this);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No employee data available to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
