using System.ComponentModel.DataAnnotations;


namespace TheOBakery.Models.DBObject
{
    public class CartContent
    {
        [Key]
        public Guid CartContentID { get; set; }
        public Guid ProductID { get; set; }
        public Guid OrderID { get; set; }
    }
}
