namespace sigucapi.Models
{
    public class OrderData
    {
        public int Id { get; set; }
        public string? target_customer { get; set; }
        public string? order_number { get; set; }
        public decimal total_weighht { get; set; }
        public string? client_address { get; set; }
        public string? container { get; set; }
    }
}
