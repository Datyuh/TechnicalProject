using System;
using TechnicalProject.Data.Entities;

namespace TechnicalProject.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ProductClothes> ProductClothess { get; }
        IRepository<Booking> Bookings { get; }
        IRepository<Warehouse> Warehouses { get; }
        void Save();
    }
}
