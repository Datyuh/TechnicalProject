using Microsoft.EntityFrameworkCore;
using TechnicalProject.Data.Entities;

namespace TechnicalProject.Data.EF
{
    public sealed partial class BookingContext : DbContext
    {
        public DbSet<ProductClothes> ProductClothess { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
