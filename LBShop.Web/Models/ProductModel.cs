namespace LBShop.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
    }
}
