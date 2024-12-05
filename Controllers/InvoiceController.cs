using bakery_management_system.Models;
using bakery_management_system.Services;

namespace bakery_management_system.Controllers
{
    public class InvoiceController
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceController()
        {
            _invoiceService = new InvoiceService();
        }

        public List<Invoice> GetInvoicesByEmployeeId(int employeeId)
        {
            return _invoiceService.GetInvoicesByEmployeeId(employeeId);
        }
    }
}
