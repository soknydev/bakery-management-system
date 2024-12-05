namespace bakery_management_system.Models
{
    public class InvoiceItem
    {
        // Product Name
        public string ProductName { get; set; }

        // Quantity of the Product
        public int Quantity { get; set; }

        // Unit Price of the Product
        public decimal UnitPrice { get; set; }

        // Total Price for this Item (Quantity * UnitPrice)
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
