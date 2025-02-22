using TheOBakery.Data;
using TheOBakery.Models.DBObject;

namespace TheOBakery.Repositories
{
    public class CustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        { 
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        public void DeleteCustomer(Guid id) 
        {
            var customer = _context.Customers.FirstOrDefault(a => a.CustomerID == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
        public IEnumerable<Customer> GetCustomer()
        {
            return _context.Customers.ToList();
        }
        public Customer GetCustomerById( Guid id )
        {
            return _context.Customers.FirstOrDefault(a => a.CustomerID == id);  
        }
    }
}
