using System;
using Microsoft.EntityFrameworkCore;
using TechnicalProject.Data.EF;
using TechnicalProject.Data.Entities;
using TechnicalProject.Data.Interfaces;

namespace TechnicalProject.Data.Repositories
{
    class EfUnitOfWork : IUnitOfWork
    {
        private BookingContext db;
        private ProductClothesRepositories clothesRepositories;
        private WarehouseRepositories warehouseRepositories;
        private BookingRepositories bookingRepositories;

        public EfUnitOfWork(DbContextOptions<BookingContext> options)
        {
            db = new BookingContext(options);
        }

        public IRepository<ProductClothes> ProductClothess
        {
            get
            {
                if (clothesRepositories == null)
                    clothesRepositories = new ProductClothesRepositories(db);
                return clothesRepositories;
            }
        }

        public IRepository<Warehouse> Warehouses
        {
            get
            {
                if (warehouseRepositories == null)
                    warehouseRepositories = new WarehouseRepositories(db);
                return warehouseRepositories;
            }
        }

        public IRepository<Booking> Bookings
        {
            get
            {
                if (bookingRepositories == null)
                    bookingRepositories = new BookingRepositories(db);
                return bookingRepositories;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}