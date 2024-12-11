using bakery_management_system.Controllers;
using bakery_management_system.Models;

namespace bakery_management_system.Views.admin
{
    public partial class UpdateProductForm : Form
    {
        private Product _product;
        private readonly CategoryController _categoryController;
        private string _selectedImagePath;

        public Product UpdatedProduct { get; private set; }

        public UpdateProductForm()
        {
            InitializeComponent();
            _categoryController = new CategoryController(); // Initialize the CategoryController
        }

        public void SetProduct(Product product)
        {
            if (product == null)
            {
                MessageBox.Show("Invalid product data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _product = product;

            // Populate fields
            txtProductName.Text = product.Name ?? string.Empty;
            txtDescription.Text = product.Name;
            txtPrice.Text = product.Price.ToString("F2"); // Format price as a decimal
            txtStockLevel.Text = product.StockLevel.ToString();

            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
            {
                picProductImage.Image = Image.FromFile(product.ImagePath);
            }
            else
            {
                picProductImage.Image = null;
            }

            // Fetch and populate categories
            var categories = _categoryController.GetCategories();
            if (categories != null && categories.Any())
            {
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedValue = product.CategoryId;
            }
            else
            {
                MessageBox.Show("No categories available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.DataSource = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("No product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStockLevel.Text.Trim(), out int stockLevel) || stockLevel < 0)
            {
                MessageBox.Show("Please enter a valid non-negative stock level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update product properties
            _product.Name = txtProductName.Text.Trim();
            _product.Description = txtDescription.Text.Trim();
            _product.Price = price;
            _product.StockLevel = stockLevel;
            _product.CategoryId = (int)cmbCategory.SelectedValue;

            if (!string.IsNullOrEmpty(_selectedImagePath))
            {
                _product.ImagePath = _selectedImagePath;
            }

            UpdatedProduct = _product;

            this.DialogResult = DialogResult.OK; // Mark the dialog as successful
            this.Close();
        }


        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Product Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = openFileDialog.FileName;

                    // Preview the image
                    if (File.Exists(_selectedImagePath))
                    {
                        picProductImage.Image = Image.FromFile(_selectedImagePath);
                    }
                    else
                    {
                        MessageBox.Show("Selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
