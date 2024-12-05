namespace bakery_management_system.Models
{
    public class Product
    {
        public int ProductId { get; set; }           // product_id (Primary Key)
        public string Name { get; set; }             // name
        public string Description { get; set; }      // description
        public decimal Price { get; set; }           // price
        public int CategoryId { get; set; }          // category_id (Foreign Key)
        public string ImagePath { get; set; }        // image_path
        public bool IsAvailable { get; set; }        // is_available
        public int StockLevel { get; set; }          // stock_level
    }
}
