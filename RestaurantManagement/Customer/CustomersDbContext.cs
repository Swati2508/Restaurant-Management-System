using Microsoft.EntityFrameworkCore;

namespace RestaurantManagement.Customer
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) 
            : base(options)
        {
        
        }
        public DbSet<Customers> Customer { get; set; }
    }
}
