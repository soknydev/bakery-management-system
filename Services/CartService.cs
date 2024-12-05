using bakery_management_system.Models;
using bakery_management_system.Utils;
using MySql.Data.MySqlClient;

namespace bakery_management_system.Services
{
    public class CartService
    {

        // remove cart
        public bool RemoveCartItem(int cartId)
        {
            string query = "DELETE FROM Cart WHERE cart_id = @cartId";
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        return cmd.ExecuteNonQuery() > 0; // Return true if a row is deleted
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error removing cart item: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Cart> GetCartsByEmployeeId(int employeeId)
        {
            var carts = new List<Cart>();
            string query = @"
                SELECT 
                    c.cart_id, c.product_id, c.quantity, c.added_date,
                    p.name AS product_name, p.price, p.image_path
                FROM Cart c
                INNER JOIN Products p ON c.product_id = p.product_id
                WHERE c.employee_id = @EmployeeId
                AND c.is_paid = FALSE;
                ";

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                carts.Add(new Cart
                                {
                                    CartId = reader.GetInt32("cart_id"),
                                    EmployeeId = employeeId,
                                    ProductId = reader.GetInt32("product_id"),
                                    ProductName = reader.GetString("product_name"),
                                    Price = reader.GetDecimal("price"),
                                    ImagePath = reader.GetString("image_path"),
                                    Quantity = reader.GetInt32("quantity"),
                                    AddedDate = reader.GetDateTime("added_date")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching carts: {ex.Message}");
                    throw;
                }
            }
            return carts;
        }

        public List<Cart> GetCarts()
        {
            var carts = new List<Cart>();
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
                            /*while (reader.Read())
                            {
                                cart.Add(new Product
                                {
                                    ProductId = reader.GetInt32("product_id"),
                                    Name = reader.GetString("name"),
                                    Price = reader.GetDecimal("price"),
                                    ImagePath = reader.GetString("image_path")
                                });
                            }*/
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching products: {ex.Message}");
                    throw;
                }
            }
            return carts;
        }

        public bool AddToCart(int employeeId, int productId, int quantity)
        {
            string checkQuery = @"
                                SELECT quantity 
                                FROM Cart 
                                WHERE employee_id = @employeeId AND product_id = @productId AND is_paid = FALSE";

            string updateQuery = @"
                                UPDATE Cart 
                                SET quantity = quantity + @quantity 
                                WHERE employee_id = @employeeId AND product_id = @productId AND is_paid = FALSE";

            string insertQuery = @"
                                INSERT INTO Cart (employee_id, product_id, quantity) 
                                VALUES (@employeeId, @productId, @quantity)";

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Check if the product already exists in the cart
                    using (var checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@employeeId", employeeId);
                        checkCmd.Parameters.AddWithValue("@productId", productId);

                        var existingQuantity = checkCmd.ExecuteScalar();
                        if (existingQuantity != null) // Product exists in the cart
                        {
                            using (var updateCmd = new MySqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@quantity", quantity);
                                updateCmd.Parameters.AddWithValue("@employeeId", employeeId);
                                updateCmd.Parameters.AddWithValue("@productId", productId);

                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }

                    // Product does not exist in the cart; insert a new row
                    using (var insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@employeeId", employeeId);
                        insertCmd.Parameters.AddWithValue("@productId", productId);
                        insertCmd.Parameters.AddWithValue("@quantity", quantity);

                        return insertCmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding to cart: {ex.Message}");
                    throw;
                }
            }
        }

    }
}
