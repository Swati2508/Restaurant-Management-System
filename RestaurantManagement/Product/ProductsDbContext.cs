using Microsoft.EntityFrameworkCore;

namespace RestaurantManagement.Product
{
    public class ProductsDbContext: DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> actions)
            : base(actions) 
        {
            
        }

        public DbSet<Products> products { get; set; }
    }
}
