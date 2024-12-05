using bakery_management_system.Controllers;
using bakery_management_system.Models;

namespace bakery_management_system.Views.customer
{
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerController _customerController;

        public AddCustomerForm()
        {
            InitializeComponent();
            _customerController = new CustomerController();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    Name = txtCustomerName.Text.Trim(),
                    Phone = string.IsNullOrEmpty(txtCustomerPhone.Text.Trim()) ? "000-000-0000" : txtCustomerPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                bool isAdded = _customerController.AddCustomer(customer);

                if (isAdded)
                {
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }


    }
}
