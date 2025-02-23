using TheOBakery.Data;
using TheOBakery.Models.DBObject;

namespace TheOBakery.Repositories
{

        public class ProductRepository
        {
            private readonly ApplicationDbContext _context;
            public ProductRepository(ApplicationDbContext context)
            {
                _context = context;
            }
            public void AddProduct(Product product)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }

            public void UpdateProduct(Product product)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
            }
            public void DeleteProduct(Guid id)
            {
                var product = _context.Products.FirstOrDefault(a => a.ProductID == id);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                }
            }
            public IEnumerable<Product> GetProducts()
            {
                return _context.Products.ToList();
            }
            public Product GetProductById(Guid id)
            {
                return _context.Products.FirstOrDefault(a => a.ProductID == id);
            }
        }
}
