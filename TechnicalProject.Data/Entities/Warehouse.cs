using System.Collections.Generic;

namespace TechnicalProject.Data.Entities
{
    class Warehouse
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int CountProduct { get; set; }
        public decimal Price { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
