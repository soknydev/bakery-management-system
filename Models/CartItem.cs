namespace bakery_management_system.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; } // ID for the cart item
        public Product Product { get; set; } // The product added to the cart
        public int Quantity { get; set; } // Number of this product in the cart
    }
}