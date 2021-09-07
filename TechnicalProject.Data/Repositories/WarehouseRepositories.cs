using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalProject.Data.EF;
using TechnicalProject.Data.Entities;
using TechnicalProject.Data.Interfaces;

namespace TechnicalProject.Data.Repositories
{
    class WarehouseRepositories : IRepository<Warehouse>
    {
        private BookingContext db;

        public WarehouseRepositories(BookingContext context)
        {
            db = context;
        }

        public IEnumerable<Warehouse> GetAll()
        {
            return db.Warehouses;
        }

        public Warehouse Get(int id)
        {
            return db.Warehouses.Find(id);
        }

        public IEnumerable<Warehouse> Find(Func<Warehouse, bool> predicate)
        {
            return db.Warehouses.Where(predicate).ToList();
        }

        public void Create(Warehouse item)
        {
            db.Warehouses.Add(item);
        }

        public void Update(Warehouse item)
        {
            db.Warehouses.Update(item);
        }

        public void Delete(int id)
        {
            Warehouse book = db.Warehouses.Find(id);
            if (book != null)
                db.Warehouses.Remove(book);
        }
    }
}
