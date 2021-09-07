using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalProject.Data.EF;
using TechnicalProject.Data.Entities;
using TechnicalProject.Data.Interfaces;

namespace TechnicalProject.Data.Repositories
{
    class BookingRepositories : IRepository<Booking>
    {
        private BookingContext db;

        public BookingRepositories(BookingContext context)
        {
            db = context;
        }

        public IEnumerable<Booking> GetAll()
        {
            return db.Bookings;
        }

        public Booking Get(int id)
        {
            return db.Bookings.Find(id);
        }

        public IEnumerable<Booking> Find(Func<Booking, bool> predicate)
        {
            return db.Bookings.Where(predicate).ToList();
        }

        public void Create(Booking item)
        {
            db.Bookings.Add(item);
        }

        public void Update(Booking item)
        {
            db.Bookings.Update(item);
        }

        public void Delete(int id)
        {
            Booking book = db.Bookings.Find(id);
            if (book != null)
                db.Bookings.Remove(book);
        }
    }
}