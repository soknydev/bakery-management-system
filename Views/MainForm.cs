using bakery_management_system.Controllers;

namespace bakery_management_system.Views
{
    public partial class MainForm : Form
    {
        private readonly ProductController _productController;

        public MainForm()
        {
            InitializeComponent();
            _productController = new ProductController();
            LoadProducts();
        }

        private void LoadProducts()
        {
            /*try
            {
                // Get available products from the controller
                var products = _productController.GetAvailableProducts();

                // Clear existing controls
                flpProducts.Controls.Clear();

                foreach (var product in products)
                {
                    // Create and configure ProductControl
                    var productControl = new ProductControl();
                    productControl.SetProduct(product);

                    // Add ProductControl to the FlowLayoutPanel
                    flpProducts.Controls.Add(productControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }*/
        }
    }
}
