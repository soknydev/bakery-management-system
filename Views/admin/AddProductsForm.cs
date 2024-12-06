using bakery_management_system.Controllers;
using bakery_management_system.Models;

namespace bakery_management_system.Views.admin
{
    public partial class AddProductsForm : Form
    {
        private readonly ProductController _productController;
        private string _selectedImagePath; // Store selected image path
        private string _imagePath;

        public AddProductsForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _productController = new ProductController();
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                var categories = _productController.GetCategories();
                cmbCategories.DataSource = categories;
                cmbCategories.DisplayMember = "category_name";
                cmbCategories.ValueMember = "category_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
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
                    _imagePath = _selectedImagePath;

                    // Preview the image
                    if (File.Exists(_selectedImagePath))
                    {
                        picProductImage.Image = Image.FromFile(_selectedImagePath);
                    }
                }
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                cmbCategories.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                var product = new Product
                {
                    Name = txtProductName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Price = Convert.ToDecimal(txtPrice.Text),
                    StockLevel = string.IsNullOrWhiteSpace(txtStock.Text) ? 0 : Convert.ToInt32(txtStock.Text),
                    CategoryId = Convert.ToInt32(cmbCategories.SelectedValue),
                    ImagePath = _selectedImagePath // Include the uploaded image path
                };

                bool success = _productController.AddProduct(product);

                if (success)
                {
                    MessageBox.Show("Product added successfully.");
                    ClearForm();

                    DashboardAdminForm dashboardAdminForm = new DashboardAdminForm();
                    dashboardAdminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to add the product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtProductName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            //txtImagePath.Clear();
            cmbCategories.SelectedIndex = -1;
            picProductImage.Image = null;
            _selectedImagePath = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DashboardAdminForm form = new DashboardAdminForm();
            form.Show();
            this.Hide();
        }

    }
}
