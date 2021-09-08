using System.Collections.Generic;
using Domain;

namespace Services.Abstract
{
    public interface IBookingServices
    {
        void AddBooking(Booking items);
        void UpdateBooking(Booking items);
        IEnumerable<Booking> GetBookingById(int id);
        void DeleteBookingById(int id);
    }
}
