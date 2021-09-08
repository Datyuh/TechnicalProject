using System.Collections.Generic;
using Domain;

namespace Services.Abstract
{
    public interface IWarehouseServices
    {
        void AddWarehouse(Warehouse items);
        void UpdateWarehouse(Warehouse items);
        IEnumerable<Warehouse> GetWarehouseById(int id);
        void DeleteWarehouseById(int id);
    }
}
