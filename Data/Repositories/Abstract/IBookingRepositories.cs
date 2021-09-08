using System.Collections.Generic;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface IBookingRepositories
    {
        void AddBooking(BookingEntity items);
        void UpdateBooking(BookingEntity items);
        IEnumerable<BookingEntity> GetBookingById(int id);
        void DeleteBookingById(int id);
    }
}
