using System;
using Microsoft.EntityFrameworkCore;
using TechnicalProject.Data.EF;
using TechnicalProject.Data.Entities;
using TechnicalProject.Data.Interfaces;

namespace TechnicalProject.Data.Repositories
{
    class EfUnitOfWork : IUnitOfWork
    {
        private readonly BookingContext _db;
        private ProductClothesRepositories _clothesRepositories;
        private WarehouseRepositories _warehouseRepositories;
        private BookingRepositories _bookingRepositories;

        public EfUnitOfWork(DbContextOptions<BookingContext> options)
        {
            _db = new BookingContext(options);
        }

        public IRepository<ProductClothes> ProductClothess
        {
            get
            {
                if (_clothesRepositories == null)
                    _clothesRepositories = new ProductClothesRepositories(_db);
                return _clothesRepositories;
            }
        }

        public IRepository<Warehouse> Warehouses
        {
            get
            {
                if (_warehouseRepositories == null)
                    _warehouseRepositories = new WarehouseRepositories(_db);
                return _warehouseRepositories;
            }
        }

        public IRepository<Booking> Bookings
        {
            get
            {
                if (_bookingRepositories == null)
                    _bookingRepositories = new BookingRepositories(_db);
                return _bookingRepositories;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
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