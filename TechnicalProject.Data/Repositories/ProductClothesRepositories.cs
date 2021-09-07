using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalProject.Data.EF;
using TechnicalProject.Data.Entities;
using TechnicalProject.Data.Interfaces;

namespace TechnicalProject.Data.Repositories
{
    class ProductClothesRepositories : IRepository<ProductClothes>
    {
        private BookingContext db;

        public ProductClothesRepositories(BookingContext context)
        {
            db = context;
        }

        public IEnumerable<ProductClothes> GetAll()
        {
            return db.ProductClothess;
        }

        public ProductClothes Get(int id)
        {
            return db.ProductClothess.Find(id);
        }

        public IEnumerable<ProductClothes> Find(Func<ProductClothes, bool> predicate)
        {
            return db.ProductClothess.Where(predicate).ToList();
        }

        public void Create(ProductClothes item)
        {
            db.ProductClothess.Add(item);
        }

        public void Update(ProductClothes item)
        {
            db.ProductClothess.Update(item);
        }

        public void Delete(int id)
        {
            ProductClothes book = db.ProductClothess.Find(id);
            if (book != null)
                db.ProductClothess.Remove(book);
        }
    }
}
