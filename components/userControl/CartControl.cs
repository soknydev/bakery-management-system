using bakery_management_system.Controllers;
using bakery_management_system.Models;
using bakery_management_system.Utils;
using bakery_management_system.Views;

namespace bakery_management_system.components.userControl
{
    public partial class CartControl : UserControl
    {
        private Cart _cart;
        private readonly CartController _cartController;

        public event EventHandler CartUpdated; // Event to notify the parent form of changes

        public CartControl()
        {
            InitializeComponent();
            _cartController = new CartController();
        }

        public void SetCart(Cart cart)
        {
            _cart = cart; // Store the cart object for reference
            lblProductName.Text = cart.ProductName;
            lblProductPrice.Text = $"${cart.Price:F2}";
            lblQuantity.Text = $"Quantity: {cart.Quantity}";

            try
            {
                if (!string.IsNullOrEmpty(cart.ImagePath) && File.Exists(cart.ImagePath))
                {
                    pbProductImage.Image = Image.FromFile(cart.ImagePath);
                }
                else
                {
                    pbProductImage.Image = Properties.Resources.bakery1; // Replace with default image
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image for product {cart.ProductName}: {ex.Message}");
                pbProductImage.Image = Properties.Resources.bakery1;
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if (_cart == null)
            {
                MessageBox.Show("No items available for payment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var paymentForm = new PaymentForm())
            {
                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    var customerId = paymentForm.CustomerId;
                    var paymentMethod = paymentForm.PaymentMethod;

                    try
                    {
                        string errorMessage;
                        bool success = _cartController.PayNow(UserSession.CurrentUser.EmployeeId, customerId, _cart.CartId, paymentMethod, out errorMessage);

                        if (success)
                        {
                            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CartUpdated?.Invoke(this, EventArgs.Empty); // Notify parent form to refresh the cart list
                        }
                        else
                        {
                            MessageBox.Show($"Payment failed: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Payment error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ptRemove_Click(object sender, EventArgs e)
        {
            if (_cart == null) return;

            // Confirm before removing
            var confirmResult = MessageBox.Show($"Are you sure you want to remove {_cart.ProductName} from the cart?",
                "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                bool isRemoved = _cartController.RemoveCartItem(_cart.CartId);
                if (isRemoved)
                {
                    MessageBox.Show("Item removed from cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CartUpdated?.Invoke(this, EventArgs.Empty); // Notify parent form
                }
                else
                {
                    MessageBox.Show("Failed to remove item from cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
