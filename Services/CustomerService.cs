using bakery_management_system.Models;
using bakery_management_system.Utils;
using MySql.Data.MySqlClient;
using System.Data;

namespace bakery_management_system.Services
{
    public class CustomerService
    {
        public bool UpdateCustomer(Customer customer)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                        UPDATE Customers 
                        SET customer_name = @name, 
                            phone = @phone, 
                            email = @email, 
                            address = @address 
                        WHERE customer_id = @id";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", customer.Name);
                        cmd.Parameters.AddWithValue("@phone", customer.Phone);
                        cmd.Parameters.AddWithValue("@email", customer.Email ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@address", customer.Address ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@id", customer.CustomerId);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating customer: {ex.Message}");
                }
            }
        }

        public bool AddCustomer(Customer customer)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Customers (customer_name, phone, email, address)
                        VALUES (@name, @phone, @email, @address)";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", customer.Name);
                        cmd.Parameters.AddWithValue("@phone", customer.Phone);
                        cmd.Parameters.AddWithValue("@email", customer.Email ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@address", customer.Address ?? DBNull.Value.ToString());

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error adding customer: {ex.Message}");
                }
            }
        }

        public Customer GetCustomerByPhone(string phone)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT customer_id, customer_name, phone, email, address FROM Customers WHERE phone = @phone LIMIT 1";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@phone", phone);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Customer
                                {
                                    CustomerId = reader.GetInt32("customer_id"),
                                    Name = reader.GetString("customer_name"),
                                    Phone = reader.GetString("phone"),
                                    Email = reader.IsDBNull("email") ? null : reader.GetString("email"),
                                    Address = reader.IsDBNull("address") ? null : reader.GetString("address")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error fetching customer by phone: {ex.Message}");
                }
            }

            return null;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT customer_id, customer_name, phone, email, address FROM Customers";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customers.Add(new Customer
                                {
                                    CustomerId = Convert.ToInt32(reader["customer_id"]),
                                    Name = reader["customer_name"].ToString(),
                                    Phone = reader["phone"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Address = reader["address"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }

            return customers;
        }

    }
}
