using bakery_management_system.Controllers;
using bakery_management_system.Models;

namespace bakery_management_system.Views.customer
{
    public partial class UpdateCustomerFormcs : Form
    {
        private readonly CustomerController _customerController;
        private readonly Customer _currentCustomer;

        public UpdateCustomerFormcs(Customer customer)
        {
            InitializeComponent();
            _customerController = new CustomerController();
            _currentCustomer = customer;

            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            txtCustomerName.Text = _currentCustomer.Name;
            txtCustomerPhone.Text = _currentCustomer.Phone;
            txtEmail.Text = _currentCustomer.Email;
            txtAddress.Text = _currentCustomer.Address;
        }


        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Name = txtCustomerName.Text.Trim();
                _currentCustomer.Phone = string.IsNullOrEmpty(txtCustomerPhone.Text.Trim()) ? "000-000-0000" : txtCustomerPhone.Text.Trim();
                _currentCustomer.Email = txtEmail.Text.Trim();
                _currentCustomer.Address = txtAddress.Text.Trim();

                bool isUpdated = _customerController.UpdateCustomer(_currentCustomer);

                if (isUpdated)
                {
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
