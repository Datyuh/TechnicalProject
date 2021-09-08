using System.Collections.Generic;
using TechnicalProject.BLL.DTO;

namespace TechnicalProject.BLL.Interfaces
{
    public interface IBookingService
    {
        void MakeBooking(BookingDTO bookingDto);
        WarehouseDTO GetCountProd(int? id);
        IEnumerable<WarehouseDTO> GetCountProds();
        void Dispose();
    }
}
