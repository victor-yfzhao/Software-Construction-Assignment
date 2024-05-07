using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }
        public DbSet<OrderModel> Orders { get; set; }

        public DbSet<OrderDetailModel> OrderDetails { get; set; }
    }
}
