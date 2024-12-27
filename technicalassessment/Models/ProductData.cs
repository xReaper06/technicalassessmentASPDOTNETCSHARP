namespace technicalassessment.Models
{
    public class ProductData
    {
        public int ProductId { get; set; }
        public int SiteId { get; set; }
        public required string product_name { get; set; }
        public decimal Cost { get; set; }
        public bool InventoryOnly { get; set; }
        public bool Private { get; set; }
    }
}
