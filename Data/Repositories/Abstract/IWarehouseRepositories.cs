using System.Collections.Generic;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface IWarehouseRepositories
    {
        void AddWarehouse(WarehouseEntity items);
        void UpdateWarehouse(WarehouseEntity items);
        IEnumerable<WarehouseEntity> GetWarehouseById(int id);
        void DeleteWarehouseById(int id);
    }
}
