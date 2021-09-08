using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EF
{
    public sealed class ShopContext : DbContext
    {
        public DbSet<BookingEntity> BookingEntities { get; set; }
        public DbSet<ProductEntity> ProductEntitys { get; set; }
        public DbSet<WarehouseEntity> WarehouseEntitys { get; set; }

        public ShopContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ShopBooking;Trusted_Connection=True;");
        }
    }
}
