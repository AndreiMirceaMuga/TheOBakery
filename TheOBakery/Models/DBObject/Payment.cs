using System.ComponentModel.DataAnnotations;
using static TheOBakery.Data.Migrations.AddOrder;

namespace TheOBakery.Models.DBObject
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; }
        public Guid CustomerID { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public PaymentStatus StatusOfPayment { get; set; }
    }
}
