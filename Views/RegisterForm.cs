using bakery_management_system.Controllers;
using bakery_management_system.Models;

namespace bakery_management_system.Views
{
    public partial class RegisterForm : Form
    {
        private readonly EmployeeController _employeeController;
        private string _role = "User"; // Default role
        private string _pathImage = "user.png"; // Default image path

        public RegisterForm()
        {
            InitializeComponent();
            _employeeController = new EmployeeController();

            // Make the form full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtFullname.Text) ||
                    string.IsNullOrWhiteSpace(txtGmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtSalary.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse salary
                if (!decimal.TryParse(txtSalary.Text, out decimal salary))
                {
                    MessageBox.Show("Invalid salary value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new employee instance
                var employee = new Employee
                {
                    Name = txtFullname.Text,
                    Role = _role,
                    Email = txtGmail.Text,
                    Phone = txtPhone.Text,
                    Salary = salary,
                    HireDate = DateTime.Now,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    ImagePath = _pathImage
                };

                // Register the employee
                bool isRegistered = _employeeController.RegisterEmployee(employee);

                if (isRegistered)
                {
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to the login form
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Upload Image";
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Load image into picture box
                pictureBox.Image = new Bitmap(ofd.FileName);

                // Assign the selected file path to _pathImage
                _pathImage = ofd.FileName;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }




    }
}
