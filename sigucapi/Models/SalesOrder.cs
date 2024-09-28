using System.ComponentModel.DataAnnotations.Schema;

namespace sigucapi.Models
{
    [Table("bps_com_salesorder")]
    public class SalesOrder
    {
        [Column("sord_codsec")]
        public int id { get; set; }
        [Column("sord_fkEntity")]
        public int id_entity { get; set; }
        [Column("sord_number")]
        public string? order {  get; set; }
    }
}
