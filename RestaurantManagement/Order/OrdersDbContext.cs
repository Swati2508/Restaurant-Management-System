using Microsoft.EntityFrameworkCore;

namespace RestaurantManagement.Order
{
    public class OrdersDbContext: DbContext
    {
        public OrdersDbContext(DbContextOptions<OrdersDbContext> choices)
            : base(choices) 
        { 
            
        }

        public DbSet<Orders> Order {  get; set; }
    }
}
