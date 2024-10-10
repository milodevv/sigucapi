using System.ComponentModel.DataAnnotations.Schema;

namespace sigucapi.Models
{
    [Table("proforma")]
    public class Proforma
    {
        public int id { get; set; }
        public string? target_customer { get; set; }
        public string? order_number { get; set; }
        public decimal net_weight { get; set; }
        public decimal gross_weight { get; set; }
        public string? client_address { get; set; }
        public string? statu {  get; set; }
        [NotMapped]
        public List<OrderData> orders { get; set; } = [];
    }
}
