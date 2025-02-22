using System.ComponentModel.DataAnnotations;
using static TheOBakery.Data.Migrations.AddOrder;

namespace TheOBakery.Models.DBObject
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid ProductID { get; set; }

        public int Quantity { get; set; }
        public PaymentStatus StatusOfPayment { get; set; }
    }
}
