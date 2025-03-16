using DDD.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infrastructure
{
    public class AppDbContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().OwnsMany(o => o.Items, oi =>
            {
                oi.WithOwner().HasForeignKey("OrderId");
                oi.Property<int>("Id"); // Shadow property for EF
                oi.HasKey("Id");
            });
        }
    }
}
