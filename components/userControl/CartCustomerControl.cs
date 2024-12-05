using bakery_management_system.Models;
using bakery_management_system.Views.customer;

namespace bakery_management_system.components.userControl
{
    public partial class CartCustomerControl : UserControl
    {
        private Customer _customer;

        public CartCustomerControl()
        {
            InitializeComponent();
        }

        // Sets customer data and stores the object
        public void SetCustomer(Customer customer)
        {
            _customer = customer;

            lblName.Text = customer.Name;
            lblPhone.Text = customer.Phone ?? "N/A";
            lblEmail.Text = customer.Email ?? "N/A";
            lblAddress.Text = customer.Address ?? "N/A";
        }

        // Handles the Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                // Open the UpdateCustomerForm with the current customer
                var updateForm = new UpdateCustomerFormcs(_customer);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No customer data available to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
