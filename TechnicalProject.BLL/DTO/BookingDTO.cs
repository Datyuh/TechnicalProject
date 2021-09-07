using System;

namespace TechnicalProject.BLL.DTO
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public int NumberBooking { get; set; }
        public int CountProductBooking { get; set; }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
}
