using bakery_management_system.Models;

namespace bakery_management_system.components.userControl
{
    public partial class CartEmployeeControl : UserControl
    {
        public CartEmployeeControl()
        {
            InitializeComponent();
        }

        // Method to set employee details
        public void SetEmployee(Employee employee)
        {
            lblName.Text = employee.Name;
            lblRole.Text = employee.Role;
            lblEmail.Text = employee.Email;
            lblPhone.Text = employee.Phone;
            //pbEmployee.Image = Image.FromFile(employee.ImagePath);

            if (!string.IsNullOrEmpty(employee.ImagePath) && File.Exists(employee.ImagePath))
            {
                pbEmployee.Image = Image.FromFile(employee.ImagePath);
            }
            else
            {
                // Set default avatar if no image is found
                pbEmployee.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            }
        }
    }
}
