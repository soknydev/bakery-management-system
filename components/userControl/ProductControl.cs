using bakery_management_system.Controllers;
using bakery_management_system.Models;
using bakery_management_system.Utils; // Assuming UserSession is implemented here

namespace bakery_management_system.components.userControl
{
    public partial class ProductControl : UserControl
    {
        private Product _product; // Store the current product
        private readonly CartController _cartController; // Dependency for adding to the cart

        public ProductControl()
        {
            InitializeComponent();
            _cartController = new CartController(); // Initialize the CartController
        }

        // Method to set the product details dynamically
        public void SetProduct(Product product)
        {
            _product = product; // Assign the product to the private field
            lblProductName.Text = product.Name;
            lblProductPrice.Text = $"${product.Price:F2}";

            // Load product image dynamically from the specified path
            try
            {
                if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                {
                    ptImage.Image = Image.FromFile(product.ImagePath);
                }
                else
                {
                    // Fallback: Set a default image if the product image is not found
                    ptImage.Image = Properties.Resources.bun_8447394_640;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image for product {product.Name}: {ex.Message}");
                ptImage.Image = Properties.Resources.bun_8447394_640;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("No product is associated with this control.", "Error");
                return;
            }

            // Get the current employee ID from the session or global state
            int employeeId = UserSession.CurrentUser?.EmployeeId ?? -1; // Replace -1 with a default or throw an error if needed
            if (employeeId <= 0)
            {
                MessageBox.Show("Invalid user session. Please log in again.", "Error");
                return;
            }

            // Call the CartController to add to the cart
            bool isAdded = _cartController.AddToCart(employeeId, _product.ProductId, 1);

            // Display result to the user
            if (isAdded)
            {
                MessageBox.Show("Product added to cart successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to add product to cart. Please try again.", "Error");
            }
        }
    }
}
