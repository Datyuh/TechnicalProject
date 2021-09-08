using System.Collections.Generic;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface IProductRepositories
    {
        void AddProduct(ProductEntity items);
        void UpdateProduct(ProductEntity items);
        IEnumerable<ProductEntity> GetProductById(int id);
        void DeleteProductById(int id);
    }
}
