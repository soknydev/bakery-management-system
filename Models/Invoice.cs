namespace bakery_management_system.Models
{
    public class Invoice
    {
        // Invoice ID
        public int InvoiceId { get; set; }

        // Invoice Date
        public DateTime InvoiceDate { get; set; }

        // Customer Details
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        // Employee Details
        public string EmployeeName { get; set; }

        // List of Invoice Items (Products purchased with details)
        public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();

        // Total Amount for the Invoice
        public decimal TotalAmount { get; set; }

        // Constructor to initialize defaults
        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }
    }
}
