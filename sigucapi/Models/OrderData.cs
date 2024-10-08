﻿using Azure.Messaging.EventGrid;
using System.ComponentModel.DataAnnotations.Schema;

namespace sigucapi.Models
{
    public class OrderData
    {
        public int id { get; set; }
        public string? target_customer { get; set; }
        public string? order_number { get; set; }
        public decimal net_weight { get; set; }
        public decimal gross_weight { get; set; }
        public string? client_address { get; set; }
        public string? unit_load { get; set; }
        [Column("statu_id")]
        public string? statu { get; set; }
        public string? proforma_id { get; set; }
    }
}
