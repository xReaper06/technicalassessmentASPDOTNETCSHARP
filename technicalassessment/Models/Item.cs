namespace technicalassessment.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int ProductId { get; set; }
        public required string Currency { get; set; }
        public required string PaymentMethod { get; set; }
        public decimal RetailCost { get; set; }
        public decimal AccountDiscount { get; set; }
        public decimal CouponDiscount { get; set; }
        public decimal NetCost { get; set; }
        public required JobData JobData { get; set; } // Nested object
    }
}
