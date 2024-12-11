using bakery_management_system.Controllers;
using bakery_management_system.Models;

namespace bakery_management_system.Views.admin
{
    public partial class UpdateEmployeeForm : Form
    {
        private Employee _employee;
        private string _imagePath;

        public UpdateEmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            LoadEmployeeData();
            InitializeRoleComboBox();
        }

        // Initialize the Role ComboBox with Admin and Staff options
        private void InitializeRoleComboBox()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Staff");

            if (!string.IsNullOrEmpty(_employee.Role))
            {
                cmbRole.SelectedItem = _employee.Role;
            }
        }

        // Loads employee data into form controls
        private void LoadEmployeeData()
        {
            txtName.Text = _employee.Name;
            txtUsername.Text = _employee.Username;
            txtPassword.Text = _employee.Password;
            cmbRole.Text = _employee.Role;
            txtEmail.Text = _employee.Email;
            txtPhone.Text = _employee.Phone;
            txtSalary.Text = _employee.Salary.ToString();
            dtpTimePicker.Value = _employee.HireDate;
            _imagePath = _employee.ImagePath;

            if (!string.IsNullOrEmpty(_employee.ImagePath) && File.Exists(_employee.ImagePath))
            {
                pictureBox.Image = Image.FromFile(_employee.ImagePath);
            }
            else
            {
                pictureBox.Image = Properties.Resources.photo_2023_08_01_20_25_42; // Replace with actual default image resource
            }
        }

        // Handles the Upload Image button click
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Employee Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the selected image path
                    _imagePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    if (File.Exists(_imagePath))
                    {
                        pictureBox.Image = Image.FromFile(_imagePath);
                    }
                    else
                    {
                        MessageBox.Show("Failed to load the selected image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Handles the Save button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Role selection
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role (Admin or Staff).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields (example for Full Name and Email)
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Full Name and Email are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assign updated values to the employee object
            _employee.Name = txtName.Text;
            _employee.Username = txtUsername.Text; // Capture Username
            _employee.Password = txtPassword.Text; // Capture Password
            _employee.Role = cmbRole.SelectedItem.ToString(); // Capture Role
            _employee.Email = txtEmail.Text;
            _employee.Phone = txtPhone.Text;
            _employee.Salary = decimal.TryParse(txtSalary.Text, out var salary) ? salary : 0;
            _employee.HireDate = dtpTimePicker.Value;
            _employee.ImagePath = _imagePath; // Capture the uploaded image path

            // Save updates using the controller
            var controller = new EmployeeController();
            if (controller.UpdateEmployee(_employee))
            {
                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after a successful update
            }
            else
            {
                MessageBox.Show("Failed to update employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
