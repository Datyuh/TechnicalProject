using Entities.Abstract;

namespace Entities
{
    public class WarehouseEntity : BaseEntity
    {
        public string NameProduct { get; set; }
        public int StorageSpace { get; set; }
        public int CountProduct { get; set; }
    }
}
