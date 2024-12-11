using bakery_management_system.Controllers;
using bakery_management_system.Models;
using bakery_management_system.Utils;
using bakery_management_system.Views.admin;

namespace bakery_management_system.components.userControl.admin
{
    public partial class ProductAdminControl : UserControl
    {
        private Product _product; // Store the current product
        private readonly ProductController _productController;
        private readonly CartController _cartController;

        public ProductAdminControl()
        {
            InitializeComponent();
            _cartController = new CartController();
            _productController = new ProductController(); // Initialize the ProductController
        }

        public void SetProduct(Product product)
        {
            _product = product;
            lblProductName.Text = product.Name;
            lblProductPrice.Text = $"${product.Price:F2}";

            try
            {
                if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                {
                    ptImage.Image = Image.FromFile(product.ImagePath);
                }
                else
                {
                    ptImage.Image = Properties.Resources.bun_8447394_640;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image for product {product.Name}: {ex.Message}");
                ptImage.Image = Properties.Resources.bun_8447394_640;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("No product selected for updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updateForm = new UpdateProductForm();
            updateForm.SetProduct(_product); // Pass the current product to the form

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                var updatedProduct = updateForm.UpdatedProduct; // Get the updated product
                bool isUpdated = _productController.UpdateProduct(updatedProduct);

                if (isUpdated)
                {
                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetProduct(updatedProduct); // Update the UI with the new product details
                }
                else
                {
                    MessageBox.Show("Failed to update the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("No product selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete {_product.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool isDeleted = _productController.DeleteProduct(_product.ProductId);

                if (isDeleted)
                {
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Parent?.Controls.Remove(this); // Remove this control from the parent container
                }
                else
                {
                    MessageBox.Show("Failed to delete the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
