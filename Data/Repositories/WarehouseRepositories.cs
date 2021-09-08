using System.Collections.Generic;
using Data.EF;
using Data.Repositories.Abstract;
using Entities;

namespace Data.Repositories
{
    class WarehouseRepositories : IWarehouseRepositories
    {
        private readonly ShopContext _db;

        public WarehouseRepositories(ShopContext context)
        {
            _db = context;
        }

        public void AddWarehouse(WarehouseEntity items)
        {
            _db.WarehouseEntitys.Add(items);
        }

        public void DeleteWarehouseById(int id)
        {
            WarehouseEntity WarehouseEntity = _db.WarehouseEntitys.Find(id);
            if (WarehouseEntity != null)
                _db.WarehouseEntitys.Remove(WarehouseEntity);
        }

        public IEnumerable<WarehouseEntity> GetWarehouseById(int id)
        {
            return _db.WarehouseEntitys;

        }

        public void UpdateWarehouse(WarehouseEntity items)
        {
            _db.WarehouseEntitys.Update(items);
        }
    }
}
