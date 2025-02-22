using System.ComponentModel.DataAnnotations;

namespace TheOBakery.Models.DBObject
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }
        public string NameOfProduct { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public int Kcal { get; set; }
        public string ImageURL { get; set; }
    }
}
