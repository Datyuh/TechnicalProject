using Entities.Abstract;

namespace Entities
{
    public class BookingEntity : BaseEntity
    {
        public int NumberBooking { get; set; }
        public int BookingCheck { get; set; }
        public string PaymentMethod { get; set; }
        public int WarehouseId { get; set; }
    }
}
