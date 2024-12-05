using bakery_management_system.Models;
using bakery_management_system.Services;
using System.Data;

namespace bakery_management_system.Controllers
{
    public class ProductController
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public DataTable GetCategories()
        {
            return _productService.GetCategories();
        }

        public bool AddProduct(Product product)
        {
            return _productService.AddProduct(product);
        }

        public List<Product> GetAvailableProducts()
        {
            return _productService.GetAvailableProducts();
        }

        public List<Product> SearchProducts(string keyword)
        {
            return _productService.SearchProducts(keyword);
        }

        /*public List<Category> GetCategories()
        {
            return _productService.GetCategories();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productService.GetProductsByCategory(categoryId);
        */

    }
}
