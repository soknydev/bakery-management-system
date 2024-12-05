using bakery_management_system.Models;
using System.Text;

namespace bakery_management_system.components.userControl
{
    public partial class InvoiceControl : UserControl
    {
        public InvoiceControl()
        {
            InitializeComponent();
        }

        public void SetInvoice(Invoice invoice)
        {
            // Set Invoice ID and Date
            lblInvoiceId.Text = $"Invoice ID: {invoice.InvoiceId}";
            lblDate.Text = $"Date: {invoice.InvoiceDate.ToShortDateString()}";

            // Set Customer Info
            lblCustomer.Text = $"Customer: {invoice.CustomerName}";
            lblPhone.Text = $"Phone: {invoice.CustomerPhone}";

            // Set Employee Info
            lblEmployeeName.Text = $"Employee: {invoice.EmployeeName}";

            // Handle Product Information
            var productDetails = new StringBuilder();
            foreach (var item in invoice.Items)
            {
                productDetails.AppendLine(
                    $" - {item.ProductName} (Qty: {item.Quantity}, Price: ${item.UnitPrice:F2})"
                );
            }
            lblProductName.Text = productDetails.ToString();

            // Display Total Amount
            lblTotal.Text = $"Total: ${invoice.TotalAmount:F2}";
        }
    }
}
