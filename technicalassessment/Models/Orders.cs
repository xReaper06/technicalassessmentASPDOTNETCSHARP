namespace technicalassessment.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public required string Status { get; set; }
        public required string PaymentMethod { get; set; }
        public int RecruiterId { get; set; }
        public int DivisionId { get; set; }
        public int CompanyId { get; set; }
        public bool Validated { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Completed { get; set; }
        public required List<Item> Items { get; set; } // List of items
    }
}
