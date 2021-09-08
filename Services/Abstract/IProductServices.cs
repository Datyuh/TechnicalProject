using System.Collections.Generic;
using Domain;

namespace Services.Abstract
{
    public interface IProductServices
    {
        void AddProduct(Product items);
        void UpdateProduct(Product items);
        IEnumerable<Product> GetProductById(int id);
        void DeleteProductById(int id);
    }
}
