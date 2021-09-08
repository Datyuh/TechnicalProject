using System.Collections.Generic;
using AutoMapper;
using TechnicalProject.BLL.BusinessModels;
using TechnicalProject.BLL.DTO;
using TechnicalProject.BLL.Infrastructure;
using TechnicalProject.BLL.Interfaces;
using TechnicalProject.Data.Entities;
using TechnicalProject.Data.Interfaces;

namespace TechnicalProject.BLL.Services
{
    public class BookingService : IBookingService
    {
        private IUnitOfWork Database { get; set; }
        public BookingService(IUnitOfWork iUnitOfWork)
        {
            Database = iUnitOfWork;
        }

        public void MakeBooking(BookingDTO bookingDto)
        {
            Warehouse warehouse = Database.Warehouses.Get(bookingDto.WerehouseId);

            if (warehouse is null)
                throw new ValidationException("Товар не найден", "");
            int count = new ShopStorage()
        }
            
        public IEnumerable<WarehouseDTO> GetCountProds()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Warehouse, WarehouseDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Warehouse>, List<WarehouseDTO>>(Database.Warehouses.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
