using System.ComponentModel.DataAnnotations;

namespace TheOBakery.Models.DBObject
{
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
