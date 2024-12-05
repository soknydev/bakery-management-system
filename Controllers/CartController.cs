using bakery_management_system.Models;
using bakery_management_system.Services;

namespace bakery_management_system.Controllers
{
    public class CartController
    {
        private readonly CartService _cartService;
        private readonly PaymentService _paymentService;

        public CartController()
        {
            _cartService = new CartService();
            _paymentService = new PaymentService();
        }

        public bool PayNow(int employeeId, int customerId, int cartId, string paymentMethod, out string errorMessage)
        {
            return _paymentService.ProcessPayment(employeeId, customerId, cartId, paymentMethod, out errorMessage);
        }

        public bool RemoveCartItem(int cartId)
        {
            return _cartService.RemoveCartItem(cartId);
        }


        public List<Cart> GetCartsByEmployeeId(int employeeId)
        {
            return _cartService.GetCartsByEmployeeId(employeeId);
        }

        public bool AddToCart(int employeeId, int productId, int quantity)
        {
            return _cartService.AddToCart(employeeId, productId, quantity);
        }
    }
}
