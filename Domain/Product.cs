using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public int CashCheck { get; set; }
        public string PaymentMethod { get; set; }
        public List<Warehouse> Warehouses { get; set; }
    }
}
