using bakery_management_system.Models;
using bakery_management_system.Services;

namespace bakery_management_system.Controllers
{
    public class PaymentController
    {
        private readonly CustomerService _customerService;

        public PaymentController()
        {
            _customerService = new CustomerService();
        }

        public Customer GetCustomerByPhone(string phone)
        {
            return _customerService.GetCustomerByPhone(phone);
        }
    }
}
