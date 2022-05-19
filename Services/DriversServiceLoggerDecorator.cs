using Domain;
using Services.Abstract;

namespace Services
{
    //Данный декоратор так же будет логировать все события в сервисе.
    public class DriversServiceLoggerDecorator : IDriversService
    {
        private readonly IDriversService _driversService;

        private List<Driver> _drivers = new();
        public DriversServiceLoggerDecorator(IDriversService driversService)
        {
            _driversService = driversService;
        }

        public void AddDriver(Driver driver)
        {
            //какое нибудь логирование.
            _driversService.AddDriver(driver);
        }

        public void DeleteDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public Driver GetDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDriver(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
