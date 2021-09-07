using System;
using System.Collections.Generic;

namespace TechnicalProject.Data.Entities
{
    public class ProductClothes
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int SizeProduct { get; set; }
        public string GenderProduct { get; set; }

        public ICollection<Warehouse> Warehouses { get; set; }

        public DateTime Date { get; set; }

    }
}
