using System.Collections.Generic;
using Data.EF;
using Data.Repositories.Abstract;
using Entities;

namespace Data.Repositories
{
    class ProductRepositories : IProductRepositories
    {
        private readonly ShopContext _db;

        public ProductRepositories(ShopContext context)
        {
            _db = context;
        }

        public void AddProduct(ProductEntity items)
        {
            _db.ProductEntitys.Add(items);
        }

        public void DeleteProductById(int id)
        {
            ProductEntity ProductEntity = _db.ProductEntitys.Find(id);
            if (ProductEntity != null)
                _db.ProductEntitys.Remove(ProductEntity);
        }

        public IEnumerable<ProductEntity> GetProductById(int id)
        {
            return _db.ProductEntitys;

        }

        public void UpdateProduct(ProductEntity items)
        {
            _db.ProductEntitys.Update(items);
        }
    }
}
