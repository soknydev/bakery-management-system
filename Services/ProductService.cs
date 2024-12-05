using bakery_management_system.Models;
using bakery_management_system.Utils;
using MySql.Data.MySqlClient;

namespace bakery_management_system.Services
{
    public class ProductService
    {
        public List<Product> GetAvailableProducts()
        {
            var products = new List<Product>();
            string query = "SELECT product_id, name, price, image_path FROM Products WHERE is_available = TRUE";

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new Product
                                {
                                    ProductId = reader.GetInt32("product_id"),
                                    Name = reader.GetString("name"),
                                    Price = reader.GetDecimal("price"),
                                    ImagePath = reader.GetString("image_path")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching products: {ex.Message}");
                    throw;
                }
            }
            return products;
        }

        public List<Product> SearchProducts(string keyword)
        {
            var products = new List<Product>();
            string query = "SELECT product_id, name, price, image_path FROM Products WHERE is_available = TRUE AND name LIKE @keyword";

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new Product
                                {
                                    ProductId = reader.GetInt32("product_id"),
                                    Name = reader.GetString("name"),
                                    Price = reader.GetDecimal("price"),
                                    ImagePath = reader.GetString("image_path")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error searching products: {ex.Message}");
                    throw;
                }
            }
            return products;
        }

        // Fetch all categories
        public List<Category> GetCategories()
        {
            var categories = new List<Category>();
            string query = "SELECT category_id, name FROM Categories";

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categories.Add(new Category
                                {
                                    CategoryId = reader.GetInt32("category_id"),
                                    CategoryName = reader.GetString("name")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching categories: {ex.Message}");
                    throw;
                }
            }
            return categories;
        }

        // Filter products by category
        public List<Product> GetProductsByCategory(int categoryId)
        {
            var products = new List<Product>();
            string query = "SELECT product_id, name, price, image_path FROM Products WHERE is_available = TRUE AND category_id = @categoryId";

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new Product
                                {
                                    ProductId = reader.GetInt32("product_id"),
                                    Name = reader.GetString("name"),
                                    Price = reader.GetDecimal("price"),
                                    ImagePath = reader.GetString("image_path")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching products by category: {ex.Message}");
                    throw;
                }
            }
            return products;
        }

    }
}
