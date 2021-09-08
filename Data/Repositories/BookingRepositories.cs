using Data.Repositories.Abstract;
using Entities;
using System.Collections.Generic;
using Data.EF;

namespace Data.Repositories
{
    class BookingRepositories : IBookingRepositories
    {
        private readonly ShopContext _db;

        public BookingRepositories(ShopContext context)
        {
            _db = context;
        }

        public void AddBooking(BookingEntity items)
        {
             _db.BookingEntities.Add(items);
        }

        public void DeleteBookingById(int id)
        {
            BookingEntity bookingEntity = _db.BookingEntities.Find(id);
            if (bookingEntity != null)
                _db.BookingEntities.Remove(bookingEntity);
        }

        public IEnumerable<BookingEntity> GetBookingById(int id)
        {
           return _db.BookingEntities;
             
        }

        public void UpdateBooking(BookingEntity items)
        {
            _db.BookingEntities.Update(items);
        }
    }
}
