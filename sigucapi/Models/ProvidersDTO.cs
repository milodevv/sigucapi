using System.ComponentModel.DataAnnotations.Schema;

namespace sigucapi.Models
{
    [Table("sig_provider")]
    public class ProvidersDTO
    {
        public int id { get; set; }
        public string? company_name { get; set; }
        public string? email { get; set; }
        public string? username { get; set; }
        public byte[]? hash_password { get; set; }
        public string? nit { get; set; }
    }
}
