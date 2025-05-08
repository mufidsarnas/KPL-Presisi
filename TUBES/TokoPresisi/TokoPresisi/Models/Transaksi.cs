using System;

namespace TokoPresisi.Models
{
    public class Transaksi
    {
        public string TransactionId { get; set; }
        public string UserId { get; set; }
        public string ItemName { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string TransactionType { get; set; } // "sale", "topup", dll.
    }
}
