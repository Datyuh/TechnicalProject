using System;

namespace TechnicalProject.Data.Entities
{
    class Booking
    {
        public int Id { get; set; }
        public int NumberBooking { get; set; }
        public int CountProductBooking { get; set; }

        public int WerehouseId { get; set; }
        public Warehouse Warehouse { get; set;}

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
}
