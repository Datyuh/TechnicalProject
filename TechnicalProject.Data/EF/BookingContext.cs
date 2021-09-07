using Microsoft.EntityFrameworkCore;
using TechnicalProject.Data.Entities;

namespace TechnicalProject.Data.EF
{
    public sealed class BookingContext : DbContext
    {
        DbSet<Warehouse> Warehouses { get; set; }
        DbSet<Booking> Bookings { get; set; }

        public BookingContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookingDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().HasData(
                new() { Id=1, NameProduct = "Костюм Спортивный муж.", CountProduct = 30, Price = 3500.54M}, 
                new() { Id=2, NameProduct = "Брюки муж.", CountProduct = 10, Price = 1500.65M}, 
                new() { Id=3, NameProduct = "Футболки жен.", CountProduct = 30, Price = 500.47M});
        }
    }
}
