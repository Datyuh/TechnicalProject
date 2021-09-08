using Domain;
using Data.Repositories.Abstract;
using Services.Abstract;
using System.Collections.Generic;

namespace Services
{
    public class BookingServices : IBookingServices
    {
        private readonly IBookingRepositories _bookingRepositories;

        public BookingServices(IBookingRepositories bookingRepositories)
        {
            _bookingRepositories = bookingRepositories;
        }

        public void AddBooking(Booking items)
        {
            _bookingRepositories.AddBooking(items);
        }

        public void DeleteBookingById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Booking> GetBookingById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBooking(Booking items)
        {
            throw new System.NotImplementedException();
        }
    }
}
