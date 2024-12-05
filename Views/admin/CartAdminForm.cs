using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;

namespace bakery_management_system.Views.admin
{
    public partial class CartAdminForm : Form
    {
        private readonly CartController _cartController;
        private int _employeeId;
        public CartAdminForm(int employeeId)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _cartController = new CartController();
            _employeeId = employeeId; // Assign the passed employeeId

            LoadCartItems();
            UserInfo();
        }

        private void LoadCartItems()
        {
            try
            {
                var carts = _cartController.GetCartsByEmployeeId(_employeeId);

                flpCarts.Controls.Clear();

                foreach (var cart in carts)
                {
                    var cartControl = new CartControl();
                    cartControl.SetCart(cart);
                    flpCarts.Controls.Add(cartControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cart items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserInfo()
        {
            // Section: User Information Display
            if (UserSession.CurrentUser != null)
            {
                lblWelcome.Text = $"Hello, {UserSession.CurrentUser.Name}";
                if (!string.IsNullOrEmpty(UserSession.CurrentUser.ImagePath) && File.Exists(UserSession.CurrentUser.ImagePath))
                {
                    pbProfile.Image = Image.FromFile(UserSession.CurrentUser.ImagePath);
                }
                else
                {
                    // defual avatar
                    pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
                }
            }
            else
            {
                lblWelcome.Text = "Welcome, Guest!";
                pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            }

        }

        private void btnBuyAll_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve all cart items for the employee
                var carts = _cartController.GetCartsByEmployeeId(_employeeId);

                if (carts == null || carts.Count == 0)
                {
                    MessageBox.Show("No items in the cart to purchase.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var paymentForm = new PaymentForm())
                {
                    if (paymentForm.ShowDialog() == DialogResult.OK)
                    {
                        var customerId = paymentForm.CustomerId;
                        var paymentMethod = paymentForm.PaymentMethod;

                        foreach (var cart in carts)
                        {
                            try
                            {
                                string errorMessage;
                                bool success = _cartController.PayNow(
                                    _employeeId,
                                    customerId,
                                    cart.CartId,
                                    paymentMethod,
                                    out errorMessage
                                );

                                if (!success)
                                {
                                    MessageBox.Show($"Payment failed for {cart.ProductName}: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Exit early on first failure
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Payment error for {cart.ProductName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Exit early on exception
                            }
                        }

                        // If all payments are successful
                        MessageBox.Show("All items have been successfully purchased!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Notify parent form to refresh the cart list
                        LoadCartItems();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing payments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
