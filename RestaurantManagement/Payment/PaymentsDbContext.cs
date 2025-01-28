using Microsoft.EntityFrameworkCore;

namespace RestaurantManagement.Payment
{
    public class PaymentsDbContext : DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> pickups)
            : base(pickups) 
        {
        
        }
        
        public DbSet<Payments> Payment {  get; set; }
    }
}
