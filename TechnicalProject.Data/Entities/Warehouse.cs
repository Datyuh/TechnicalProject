using System.Collections.Generic;

namespace TechnicalProject.Data.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public int CountProduct { get; set; }
        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public ProductClothes Product { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
