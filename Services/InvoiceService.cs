using bakery_management_system.Models;
using bakery_management_system.Utils;
using MySql.Data.MySqlClient;

namespace bakery_management_system.Services
{
    public class InvoiceService
    {
        public List<Invoice> GetInvoicesByEmployeeId(int employeeId)
        {
            var invoices = new List<Invoice>();
            string query = @"
                SELECT 
                    i.invoice_id, i.invoice_date, i.total_amount,
                    c.customer_name, c.phone AS customer_phone,
                    e.name AS employee_name,
                    p.name AS product_name, ii.quantity, ii.price
                FROM Invoices i
                JOIN Customers c ON i.customer_id = c.customer_id
                JOIN Employees e ON i.employee_id = e.employee_id
                JOIN InvoiceItems ii ON i.invoice_id = ii.invoice_id
                JOIN Products p ON ii.product_id = p.product_id
                WHERE i.employee_id = @employeeId";

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Extract the Invoice ID
                                int invoiceId = reader.GetInt32("invoice_id");

                                // Check if an invoice with this ID already exists in the list
                                var existingInvoice = invoices.FirstOrDefault(i => i.InvoiceId == invoiceId);

                                if (existingInvoice == null)
                                {
                                    // Create a new Invoice object and add it to the list
                                    existingInvoice = new Invoice
                                    {
                                        InvoiceId = invoiceId,
                                        InvoiceDate = reader.GetDateTime("invoice_date"),
                                        CustomerName = reader.GetString("customer_name"),
                                        CustomerPhone = reader.GetString("customer_phone"),
                                        EmployeeName = reader.GetString("employee_name"),
                                        TotalAmount = reader.GetDecimal("total_amount"),
                                        Items = new List<InvoiceItem>()
                                    };
                                    invoices.Add(existingInvoice);
                                }

                                // Add the current invoice item to the existing invoice
                                existingInvoice.Items.Add(new InvoiceItem
                                {
                                    ProductName = reader.GetString("product_name"),
                                    Quantity = reader.GetInt32("quantity"),
                                    UnitPrice = reader.GetDecimal("price")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching invoices: {ex.Message}");
                    throw;
                }
            }
            return invoices;
        }
    }
}
