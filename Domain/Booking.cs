using System.Collections.Generic;

namespace Domain
{
    public class Booking
    {
        public int NumberBooking { get; set; }
        public int BookingCheck { get; set; }
        public string PaymentMethod { get; set; }
        public List<Warehouse> Warehouses { get; set; }
    }
}
