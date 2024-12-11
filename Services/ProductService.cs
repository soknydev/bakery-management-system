using bakery_management_system.Models;
using bakery_management_system.Utils;
using MySql.Data.MySqlClient;
using System.Data;

namespace bakery_management_system.Services
{
    public class ProductService
    {
        public bool DeleteProduct(int productId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Products WHERE product_id = @product_id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", productId);
                    return cmd.ExecuteNonQuery() > 0; // Returns true if at least one row was deleted
                }
            }
        }

        public bool UpdateProduct(Product product)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE Products
            SET name = @name, 
                description = @description, 
                price = @price, 
                category_id = @category_id, 
                stock_level = @stock_level, 
                image_path = @image_path
            WHERE product_id = @product_id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@category_id", product.CategoryId);
                    cmd.Parameters.AddWithValue("@stock_level", product.StockLevel);
                    cmd.Parameters.AddWithValue("@image_path", product.ImagePath);
                    cmd.Parameters.AddWithValue("@product_id", product.ProductId);

                    return cmd.ExecuteNonQuery() > 0; // Returns true if at least one row was updated
                }
            }
        }

        public bool AddProduct(Product product)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    INSERT INTO Products (name, description, price, category_id, stock_level, image_path)
                    VALUES (@name, @description, @price, @category_id, @stock_level, @image_path)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@category_id", product.CategoryId);
                    cmd.Parameters.AddWithValue("@stock_level", product.StockLevel);
                    cmd.Parameters.AddWithValue("@image_path", product.ImagePath);

                    return cmd.ExecuteNonQuery() > 0; // Returns true if at least one row was inserted
                }
            }
        }

        public DataTable GetCategories()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT category_id, category_name FROM Categories";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

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
