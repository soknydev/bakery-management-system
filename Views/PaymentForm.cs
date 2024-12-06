using bakery_management_system.Controllers;
using bakery_management_system.Models;

namespace bakery_management_system.Views
{
    public partial class PaymentForm : Form
    {
        public int CustomerId { get; private set; }
        public string PaymentMethod { get; private set; }

        private readonly PaymentController _paymentController;

        private const string ErrorTitle = "Input Error";
        private const string PaymentMethodError = "Please select a valid payment method.";

        public PaymentForm()
        {
            InitializeComponent();
            InitializePaymentMethods();

            _paymentController = new PaymentController();
        }

        private void InitializePaymentMethods()
        {
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Credit Card");
            cmbPaymentMethod.Items.Add("Mobile Payment");
            cmbPaymentMethod.SelectedIndex = 0; // Default selection
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Default phone if no input is provided
            string customerPhone = string.IsNullOrWhiteSpace(txtCustomerPhone.Text)
                                   ? "000-000-0000"
                                   : txtCustomerPhone.Text.Trim();

            // Fetch customer using phone (or default)
            Customer customer = _paymentController.GetCustomerByPhone(customerPhone);

            // Validate customer retrieval
            if (customer == null)
            {
                MessageBox.Show($"Customer with phone '{customerPhone}' not found.", ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Payment Method
            if (cmbPaymentMethod.SelectedItem == null || string.IsNullOrWhiteSpace(cmbPaymentMethod.SelectedItem.ToString()))
            {
                MessageBox.Show(PaymentMethodError, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assign values
            CustomerId = customer.CustomerId;
            PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            // Confirm dialog result
            DialogResult = DialogResult.OK;
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
