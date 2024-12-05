using bakery_management_system.Models;
using bakery_management_system.Utils;
using MySql.Data.MySqlClient;

namespace bakery_management_system.Services
{
    public class CategoryService
    {
        public List<Category> SearchCategories(string keyword)
        {
            var categories = new List<Category>();
            string query = "SELECT category_id, category_name FROM Categories WHERE category_name LIKE @keyword";

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
                                categories.Add(new Category
                                {
                                    CategoryId = reader.GetInt32("category_id"),
                                    CategoryName = reader.GetString("category_name")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error searching categories: {ex.Message}");
                    throw;
                }
            }
            return categories;
        }


        public List<Category> GetCategories()
        {
            var categories = new List<Category>();
            string query = "SELECT category_id, category_name FROM Categories";

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
                                    CategoryName = reader.GetString("category_name")
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
