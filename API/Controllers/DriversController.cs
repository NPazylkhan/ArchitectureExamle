using Mappers;
using Models;
using Services.Abstract;

namespace API.Controllers
{
    public class DriversController
    {
        private readonly IDriversService _driversService;

        public DriversController(IDriversService driversService)
        {
            _driversService = driversService;
        }

        public void AddDriver(DriverModel model)
        {
            _driversService.AddDriver(model.ToDomain());
        }
    }
}
