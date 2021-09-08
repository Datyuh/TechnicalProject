using Entities.Abstract;

namespace Entities
{
    public class ProductEntity : BaseEntity
    {
        public int CashCheck { get; set; }
        public string PaymentMethod { get; set; }
        public int WarehouseId { get; set; }
    }
}
