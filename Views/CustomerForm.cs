using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Views.customer;

namespace bakery_management_system.Views
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerController _customerController;

        public CustomerForm()
        {
            InitializeComponent();

            // Make the form full screen
            this.WindowState = FormWindowState.Maximized;

            _customerController = new CustomerController();

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            // Fetch all customers
            var customers = _customerController.GetAllCustomers();

            // Clear existing controls in the FlowLayoutPanel
            flowLayoutPanelCustomers.Controls.Clear();

            // Add customers to the FlowLayoutPanel
            foreach (var customer in customers)
            {
                var customerControl = new CartCustomerControl();
                customerControl.SetCustomer(customer);
                flowLayoutPanelCustomers.Controls.Add(customerControl);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

    }
}
