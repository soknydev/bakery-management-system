namespace bakery_management_system.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
